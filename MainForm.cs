using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using YuantaCOMLib;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Threading;
namespace YOACOMClientCSharp
{
    public partial class MainForm : Form, IYuantaAPIEvents
    {
        IYuantaAPI m_iYuantaAPI;

        // 종목리스트
        // public static string[] jongCodeList = new string[] { "DEL" };
        public static string tradeExchange = "all";

        public static Dictionary<string, List<string>> Master종합정보 = new Dictionary<string, List<string>>();
        public static int regist_count = 0;
        public static bool receive_flag= false;

        //19.05.20 igg added
        public static string mongo_admin = "mongodb://userAdmin:apsxl007!@14.63.166.197/admin";//몽고전체수신DB
        // 클라이언트 객체 생성
        public static MongoClient cli = new MongoClient(mongo_admin);
        // testdb 선택
        public static MongoDatabase stockdb = cli.GetServer().GetDatabase("us_stock");
        // 컬렉션 선택
        static string today = DateTime.Now.ToString("yyMMdd");
        public static MongoCollection realdata_nasdaq_collection = stockdb.GetCollection<BsonDocument>(today + "_nasdaq");
        public static MongoCollection realdata_nyse_collection = stockdb.GetCollection<BsonDocument>(today + "_nyse");
        public static MongoCollection nasdaq_collection = stockdb.GetCollection<BsonDocument>("nasdaq_you");
        public static MongoCollection nyse_collection = stockdb.GetCollection<BsonDocument>("nyse_you");
        public static MongoCollection Jong_collection;


        BasicTestHandler m_basicTestHandler;


        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def,StringBuilder retVal, int size, string filePath);

        public MainForm()
        {
            InitializeComponent();


            // 유안타 오픈 API 기본 설정 ///////////////////////////////
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            int dwCookie = 0;

            m_iYuantaAPI = new YuantaAPI();
            icpc = (IConnectionPointContainer)m_iYuantaAPI;
            Guid IID_QueryEvents = typeof(IYuantaAPIEvents).GUID;
            icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
            icp.Advise(this, out dwCookie);
            ////////////////////////////////////////////////////////////

            m_basicTestHandler = new BasicTestHandler();
            m_basicTestHandler.m_mainForm = this;
            m_basicTestHandler.m_iYuantaAPI = m_iYuantaAPI;

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 18);
            lvAcctList.SmallImageList = imgList;

            Initial();          //유안타증권 API 셋팅

            Login();            //자동로그인
        }

        void today_ticker_init()    // 종목정보 초기화 함수
        {
            nyse_collection.Drop();
            nasdaq_collection.Drop();
            
            int count = m_iYuantaAPI.YOA_GetCodeCount(CommDef.MARKET_TYPE_GLOBAL_STOCK); //해외주식종목숫자

            int c = 0;
            for (int i = 0; i < count; i++)
            {
                List<string> value = new List<string>();

                string ticker = m_iYuantaAPI.YOA_GetCodeInfoByIndex(CommDef.MARKET_TYPE_GLOBAL_STOCK, 0, i);
                string standard_code = m_iYuantaAPI.YOA_GetCodeInfoByIndex(CommDef.MARKET_TYPE_GLOBAL_STOCK, 1, i);
                string kor_name = m_iYuantaAPI.YOA_GetCodeInfoByIndex(CommDef.MARKET_TYPE_GLOBAL_STOCK, 2, i);
                string name = m_iYuantaAPI.YOA_GetCodeInfoByIndex(CommDef.MARKET_TYPE_GLOBAL_STOCK, 3, i);
                string market = m_iYuantaAPI.YOA_GetCodeInfoByIndex(CommDef.MARKET_TYPE_GLOBAL_STOCK, 4, i);
                if (market == "88" || market == "87")    // 88=나스닥, 87= 뉴욕거래소
                {
                    c++;
                    if (market == "88")
                        market = "nasdaq";
                    else if (market == "87")
                        market = "nyse";
                    value.Add(ticker);
                    value.Add(standard_code);
                    value.Add(kor_name);
                    value.Add(name);
                    value.Add(market);
                    jongCode_info_insert(value);
                }
            }
            Console.WriteLine(c+"개의 거래종목 정보를 DB에 초기화하였습니다.");
            
        }

        void get_ticker_info()   // 종목정보 사전으로 불러오는 함수
        {
            // nyse 종목정보 불러오기
            var jongList = nyse_collection.FindAllAs<BsonDocument>();
            foreach (var jong in jongList)
            {
                List<string> value = new List<string>();
                value.Add(jong[4].ToString());  // 티커에 종목명
                value.Add("nyse");              // 티커에 거래소
                value.Add("0");                 // 티커에 현재가         
                Master종합정보[jong[1].ToString()] = value;
            }
            jongList = nasdaq_collection.FindAllAs<BsonDocument>();
            foreach (var jong in jongList)
            {
                List<string> value = new List<string>();
                value.Add(jong[4].ToString());  // 티커에 종목명
                value.Add("nasdaq");            // 티커에 거래소
                value.Add("0");                 // 티커에 현재가         
                Master종합정보[jong[1].ToString()] = value;
            }

            Console.WriteLine("DB에서 거래소별 " + Master종합정보.Count + "개의 모든 종목정보를 불러왔습니다.");


        }
        //Test 버튼 클릭시
        private void textbtn_Click_1(object sender, EventArgs e)
        {
            
            // 뉴욕거래소 선택시
            if (tradeExchange == "nyse")
            {
                foreach (KeyValuePair<string, List<string>> val in Master종합정보)
                {
                    if (val.Value[1] == "nyse")
                    {
                        m_basicTestHandler.m_strJongCode = val.Key;
                        // Tr 등록후 nReqID  받기
                        int nReqID = m_iYuantaAPI.YOA_Request("4b", true, -1);
                        // auto 등록 
                        m_basicTestHandler.RegistAuto();
                        // ReceiveRealData 받기
                        m_basicTestHandler.ReceiveRealData(nReqID, "4b");
                    }
                }
            }
            //나스닥 선택시
            else if (tradeExchange == "nasdaq")
            {
                foreach (KeyValuePair<string, List<string>> val in Master종합정보)
                {
                    if (val.Value[1] == "nasdaq")
                    {
                        m_basicTestHandler.m_strJongCode = val.Key;
                        // Tr 등록후 nReqID  받기
                        int nReqID = m_iYuantaAPI.YOA_Request("4b", true, -1);
                        // auto 등록 
                        m_basicTestHandler.RegistAuto();
                        // ReceiveRealData 받기
                        m_basicTestHandler.ReceiveRealData(nReqID, "4b");
                    }
                }
            }
            // 선택을안하거나 전체선택시
            else
            {
                foreach (KeyValuePair<string, List<string>> val in Master종합정보)
                {
                    m_basicTestHandler.m_strJongCode = val.Key;
                    // Tr 등록후 nReqID  받기
                    int nReqID = m_iYuantaAPI.YOA_Request("4b", true, -1);
                    // auto 등록 
                    m_basicTestHandler.RegistAuto();
                    // ReceiveRealData 받기
                    m_basicTestHandler.ReceiveRealData(nReqID, "4b");
                }
            }
            LogMessage(tradeExchange + "선택 / " + regist_count+ "개의 종목이 모두 자동수신 등록되었습니다.");
            Console.WriteLine(tradeExchange + "선택 / "+ regist_count + "개의 종목이 모두 자동수신 등록되었습니다.");

            // 등록완료되면 flag설정 수신시작
           receive_flag = true;

        }

        public static void testdb_insert(List<string> value)
        {
            insert_info svi = new insert_info
            {
                ticker = value[0],
                curprice = Math.Round(double.Parse(value[1]), 4),
                //startprice = Math.Round(double.Parse(value[2]), 4),
                //highprice = Math.Round(double.Parse(value[3]), 4),
                //lowprice = Math.Round(double.Parse(value[4]), 4),
                medohoka = Math.Round(double.Parse(value[5]), 4),
                mesuhoka = Math.Round(double.Parse(value[6]), 4),
                //debi = Math.Round(double.Parse(value[7]), 4),
                //filler1 = value[8],
                volume = Math.Round(double.Parse(value[9]), 4),
                money = Math.Round(double.Parse(value[10]), 4),
                nowmoney = Math.Round(double.Parse(value[11]), 4), //거래대금
                debirate = Math.Round(double.Parse(value[12]), 4), //등락률
                nowvol = Math.Round(double.Parse(value[13]), 4), //체결량
                time = value[14]
            };
            if (value[15] == "nasdaq")
                realdata_nasdaq_collection.Insert(svi);
            else if (value[15] == "nyse")
                realdata_nyse_collection.Insert(svi);
        }
        public static void jongCode_info_insert(List<string> value)
        {
            jongCode_info svi = new jongCode_info
            {
                ticker = value[0],
                standard_code = value[1],
                kor_name = value[2],
                us_name =value[3],
                market = value[4]

            };
            if (value[4] == "nasdaq")
                nasdaq_collection.Insert(svi);
            else if (value[4] == "nyse")
                nyse_collection.Insert(svi);
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (null != m_iYuantaAPI)
                m_iYuantaAPI.YOA_UnInitial();
        }

        #region IYuantaAPIEvents 멤버

        void IYuantaAPIEvents.ReceiveSystemMessage(int nID, string strMsg)
        {
            //MessageBox.Show("[MsgID : " + nID + "] " + strMsg);
            LogMessage(strMsg);

            if (CommDef.NOTIFY_SYSTEM_NEED_TO_RESTART == nID)
            {
                m_iYuantaAPI.YOA_ReStart();
            }

            throw new NotImplementedException();
        }

        void IYuantaAPIEvents.Login(int nResult, string strMsg)
        {
            if (CommDef.RESPONSE_LOGIN_SUCCESS == nResult)
            {
                btnLogout.Enabled = true;
                btnGetAccount.Enabled = true;

                LogMessage("로그인이 완료되었습니다.");
                Console.WriteLine("로그인이 완료되었습니다.");
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnGetAccount.Enabled = false;

                LogMessage("로그인이 실패하였습니다.", CommDef.YOALOG_ERROR);

                if (CommDef.ERROR_TIMEOUT_DATA == nResult)
                {
                    LogMessage("서버로부터 로그인 응답이 없습니다. 다시 시도하여 주십시오.", CommDef.YOALOG_ERROR, false);
                }
                else
                {
                    LogMessage(m_iYuantaAPI.YOA_GetErrorMessage(nResult), CommDef.YOALOG_ERROR, false);
                }
            }

            throw new NotImplementedException();
        }

        void IYuantaAPIEvents.ReceiveError(int nReqID, int nErrCode, string strErrMsg)
        {
            if (m_basicTestHandler.m_mapRequestTR.ContainsKey(nReqID))
            {
                m_basicTestHandler.ReceiveError(nReqID, nErrCode, strErrMsg);
            }
           

            throw new NotImplementedException();
        }

        void IYuantaAPIEvents.ReceiveData(int nReqID, string strDSOID)
        {
            if (m_basicTestHandler.m_mapRequestTR.ContainsKey(nReqID))
            {
                m_basicTestHandler.ReceiveData(nReqID);
            }
           

            throw new NotImplementedException();
        }

        void IYuantaAPIEvents.ReceiveRealData(int nReqID, string strAutoID)
        {
            if (m_basicTestHandler.m_mapAutoTR.ContainsKey(nReqID))
            {
                m_basicTestHandler.ReceiveRealData(nReqID, strAutoID);
            }
           
        }

        #endregion

        private void LoadUserInfo()
        {
            string strPath = System.Windows.Forms.Application.ExecutablePath;
            strPath = System.IO.Path.GetDirectoryName(strPath);
            strPath = strPath + "\\testlogin.ini";

            StringBuilder strTemp = new StringBuilder(255);
            GetPrivateProfileString("TEST_INFO", "ID", string.Empty, strTemp, 255, strPath);
            txtUserID.Text = strTemp.ToString();

            GetPrivateProfileString("TEST_INFO", "PWD", string.Empty, strTemp, 255, strPath);
            txtUserPW.Text = strTemp.ToString();

            GetPrivateProfileString("TEST_INFO", "CERT_PWD", string.Empty, strTemp, 255, strPath);
            txtCertPW.Text = strTemp.ToString();

            if (0 < txtUserID.Text.Length && 0 < txtUserPW.Text.Length && 0 < txtCertPW.Text.Length)
                Login();
        }

        public void LogMessage(string strMsg, int nType = 0, bool bTimeStamp = true)
        {
            string strLog = "";

            if (true == bTimeStamp)
            {
                DateTime dt = DateTime.Now;

                if (0 == nType)
                {
                    strLog = "[LOG:" + dt.ToString("yyyy-MM-dd hh:mm:ss") + "] " + strMsg;
                }
                else if (1 == nType)
                {
                    strLog = "[ERR:" + dt.ToString("yyyy-MM-dd hh:mm:ss") + "] " + strMsg;
                }
            }
            else
            {
                strLog = "[ERR_MSG] " + strMsg;
            }

            lbMainLog.Items.Add(strLog);
        }

        public string Commify(int nData)
        {
            string strResult = "";
            strResult = string.Format("{0:#,###0}", nData);

            return strResult;
        }

        public string Commify(double dData)
        {
            string strResult = "";
            strResult = string.Format("{0:#,###.##0}", dData);

            return strResult;
        }

        public string Commify(string strData)
        {
            int nData = Convert.ToInt32(strData);
            return Commify(nData);
        }
       
 
        private void Initial()
        {
            btnInitial.Enabled = false;

            //string strURL = "simul.tradarglobal.api.com";
            //string strURL = "real.tradarglobal.api.com";
            string strURL = "real.tradar.api.com";
            //string strURL = "simul.tradar.api.com";
            string strPath = "C:\\Users\\Administrator\\Desktop\\us_version_cshap\\bin\\Release";

            if (CommDef.RESULT_SUCCESS == m_iYuantaAPI.YOA_Initial(strURL, strPath))
            {
                if (strURL == "real.tradar.api.com" || strURL == "real.tradar.api.com")
                    // MessageBox.Show("모의투자로 접속합니다.\n모의투자의 계좌비밀번호는 0000입니다.", "알림", MessageBoxButtons.OK);

                btnLogin.Enabled = true;
                txtUserID.Focus();

                LogMessage("유안타 Open API가 초기화되었습니다.");
            }
            else
            {
                btnInitial.Enabled = true;

                LogMessage("유안타 Open API가 초기화에 실패하였습니다.", CommDef.YOALOG_ERROR);
            }
        }

        private void Login()
        {
            int nResult = m_iYuantaAPI.YOA_Login(txtUserID.Text, txtUserPW.Text, txtCertPW.Text);

            if (CommDef.RESULT_SUCCESS == nResult)
            {
                btnLogin.Enabled = false;

                LogMessage("로그인 요청이 되었습니다.");
            }
            else
            {
                btnLogin.Enabled = true;

                LogMessage("로그인 요청이 실패하였습니다.", CommDef.YOALOG_ERROR);
                LogMessage(m_iYuantaAPI.YOA_GetErrorMessage(nResult), CommDef.YOALOG_ERROR, false);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void InitAccount()
        {
            lvAcctList.BeginUpdate();

            lvAcctList.Items.Clear();

            ListViewItem item = null;
            string strAccount = "";
            string strAcctName = "";

            int nCount = m_iYuantaAPI.YOA_GetAccountCount();
            for (int i = 0; i < nCount; i++)
            {
                item = new ListViewItem(Convert.ToString(i + 1));

                strAccount = m_iYuantaAPI.YOA_GetAccount(i);
                if (1 == strAccount.Length % 2)
                {
                    strAccount = strAccount.Insert(5, "-");
                    strAccount = strAccount.Insert(3, "-");
                }
                else
                {
                    strAccount = strAccount.Insert(8, "-");
                    strAccount = strAccount.Insert(4, "-");
                }

                strAcctName = m_iYuantaAPI.YOA_GetAccountInfo(CommDef.ACCOUNT_INFO_NAME, strAccount);

                item.SubItems.Add(strAccount);
                item.SubItems.Add(strAcctName);

                lvAcctList.Items.Add(item);
                
            }
            

            lvAcctList.EndUpdate();
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            Initial();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            InitAccount();
        }
        
        private void tabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (2 == tabPanel.SelectedIndex || 3 == tabPanel.SelectedIndex)
            {
                if (0 == lvAcctList.Items.Count)
                {
                    if (DialogResult.OK == MessageBox.Show("계좌정보가 없습니다.\n계좌가져오기를 하시겠습니까?", "알림", MessageBoxButtons.OKCancel))
                    {
                        InitAccount();
                    }
                }
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void NasdaqBtn_CheckedChanged(object sender, EventArgs e)
        {
            tradeExchange = "nasdaq";
        }

        private void NyseBtn_CheckedChanged(object sender, EventArgs e)
        {
            tradeExchange = "nyse";
        }

        private void AllBtn_CheckedChanged(object sender, EventArgs e)
        {
            tradeExchange = "all";

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (KeyValuePair<string, List<string>> val in Master종합정보)
            {
                if (val.Value[2] != "0")
                {
                    count++;
                }
            }
            Console.WriteLine("result : " + count + "/" + Master종합정보.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            today_ticker_init();    // 종목정보 초기화

            get_ticker_info();      // 종목정보 사전으로 불러오기
        }
    }
}
