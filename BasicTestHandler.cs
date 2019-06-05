using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YuantaCOMLib;


namespace YOACOMClientCSharp
{
    class BasicTestHandler
    {
        public MainForm m_mainForm;
        public IYuantaAPI m_iYuantaAPI;
        public Dictionary<int, string> m_mapRequestTR = new Dictionary<int, string>();
        public Dictionary<int, string> m_mapAutoTR = new Dictionary<int, string>();
        public string m_strJongCode;

        public BasicTestHandler()
        {
            m_mainForm = null;
            m_iYuantaAPI = null;
            m_strJongCode = "";
        }
        
        public void RegistAuto()
        {
            try
            {
                m_iYuantaAPI.YOA_SetTRFieldString("4b", "InBlock1", "jongcode", m_strJongCode, 0);      //m_mainForm.txtBTJongCode.Text를 i로 바꿈
                int nReqID = m_iYuantaAPI.YOA_RegistAuto("4b");
                if (nReqID == -1)
                    Console.WriteLine(m_strJongCode);

                if (CommDef.ERROR_MAX_CODE < nReqID)
                {
                    m_mapAutoTR[nReqID] = "4b";
                    m_mainForm.lbLog.Items.Insert(0, "[4b]주식 실시간체결 Auto가 등록 되었습니다.");
                    MainForm.regist_count++;
                    // MainForm.Master종합정보[m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "jongcode", 0)]= "null";
                }
                else
                {
                    string strMsg = m_iYuantaAPI.YOA_GetErrorMessage(nReqID);     // 실시간 등록 실패에 대한 메시지를 얻을 수 있습니다.
                    m_mainForm.lbLog.Items.Add(strMsg);
                }
            }
            catch
            {
                Console.WriteLine(m_strJongCode);
            }
        }

        public void UnRegistAuto()
        {
            foreach (KeyValuePair<int, string> autoTR in m_mapAutoTR)
            {
                int nResult = m_iYuantaAPI.YOA_UnRegistAutoWithReqID(autoTR.Key);

                if (CommDef.RESULT_SUCCESS == nResult)
                {
                    m_mainForm.lbLog.Items.Insert(0, "[4b]주식 실시간체결 Auto가 해지 되었습니다.");
                }
                else
                {
                    m_mainForm.lbLog.Items.Insert(0, "[4b]주식 실시간체결 Auto 해지가 실패하였습니다.");

                    string strMsg = m_iYuantaAPI.YOA_GetErrorMessage(nResult);     // 실시간 해지 실패에 대한 메시지를 얻을 수 있습니다.
                    m_mainForm.lbLog.Items.Insert(0, strMsg);
                }
            }
            m_mapAutoTR.Clear();
        }

        public void ReceiveError(int nReqID, int nErrCode, string strErrMsg)
        {
            string strTRID = m_mapRequestTR[nReqID];
            string strName = "";
            if (strTRID.Equals("300001"))
            {
                strName = "[300001]주식현재가 ";
            }

            if (nErrCode == CommDef.ERROR_TIMEOUT_DATA)
            {
                m_mainForm.lbLog.Items.Insert(0, "Timeout " + strName + "요청의 응답이 없습니다.");
            }
            else if (nErrCode == CommDef.ERROR_REQUEST_FAIL)
            {
                //m_mainForm.lbLog.Items.Insert(0, strName + m_iYuantaAPI.YOA_GetErrorMessage(nErrCode));       // 많은 종목에 대해서 최초수신시에 dso 요청실패 오류가 뜸 - 잠시 주석처리
            }
        }

        public void ReceiveData(int nReqID)
        {
            string strTRID = m_mapRequestTR[nReqID];
            if (-1 != strTRID.CompareTo("300001"))
            {
                m_mainForm.txtBTJongName.Text = m_iYuantaAPI.YOA_GetTRFieldString("300001", "OutBlock1", "jongname", 0);    // GetTRFieldString 은 set,get동시
                m_mainForm.txtBTCurJuka.Text = m_iYuantaAPI.YOA_GetTRFieldString("300001", "OutBlock1", "curjuka", 0);
                m_iYuantaAPI.YOA_SetTRInfo("300001", "OutBlock1");  // SetTRInfo -> GetFieldString 값 접근
                m_mainForm.txtBTDebi.Text = m_iYuantaAPI.YOA_GetFieldString("debi", 0);
                m_mainForm.txtBTDebiRate.Text = m_iYuantaAPI.YOA_GetFieldString("debirate", 0);
                m_mainForm.txtBTVolume.Text = m_iYuantaAPI.YOA_GetFieldString("volume", 0);

                m_mainForm.lbLog.Items.Insert(0, "[300001]주식현재가 응답을 수신하였습니다.");
                //Console.WriteLine("2");

            }
        }
        public void ReceiveRealData(int nReqID, string strAutoID)
        {
            if (MainForm.receive_flag == true)
            {
                if (-1 != strAutoID.CompareTo("4b"))
                {
                    string strOutCode = m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "jongcode", 0).Trim();
                    string price = m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "curprice", 0);
                    MainForm.Master종합정보[strOutCode][2] = price; //price 가 들어올때마다 딕셔너리값 변경
                    /*
                    // 추가부분 - 메인 로그에 정보찍기
                    Console.WriteLine("종목코드 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "jongcode", 0));       
                    Console.WriteLine("현재가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "curprice", 0));      
                    Console.WriteLine("시가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "startprice", 0));         
                    Console.WriteLine("고가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "highprice", 0));
                    Console.WriteLine("저가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "lowprice", 0));
                    Console.WriteLine("매도호가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "medohoka", 0));    
                    Console.WriteLine("매수호가 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "mesuhoka", 0));
                    Console.WriteLine("전일대비 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "debi", 0));
                    Console.WriteLine("filler :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "filler1", 0));
                    Console.WriteLine("누적거래량_주단위 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "volume", 0));
                    Console.WriteLine("누적거래대금_천단위 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "money", 0));
                    Console.WriteLine("직전거래대금 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "nowmoney", 0));
                    Console.WriteLine("등락률 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "debirate", 0));
                    Console.WriteLine("직전체결량 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "nowvol", 0));
                    Console.WriteLine("시간 :" + m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "time", 0));
                    Console.WriteLine("--------------------------------------------");

    */


                    List<string> value = new List<string>();
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "jongcode", 0));   
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "curprice", 0));    
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "startprice", 0));       
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "highprice", 0));    
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "lowprice", 0));     
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "medohoka", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "mesuhoka", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "debi", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "filler1", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "volume", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "money", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "nowmoney", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "debirate", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "nowvol", 0));
                    value.Add(m_iYuantaAPI.YOA_GetTRFieldString("4b", "OutBlock1", "time", 0));
                    value.Add(MainForm.Master종합정보[strOutCode][1]);

                    MainForm.testdb_insert(value);


                }
            }
        }

    }
}