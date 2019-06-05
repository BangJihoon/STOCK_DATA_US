using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YOACOMClientCSharp
{
    class insert_info
    {
        public ObjectId Id { get; set; }
        public string ticker { get; set; }
        public double curprice { get; set; }
        //public double startprice { get; set; }
        //public double highprice { get; set; }
        //public double lowprice { get; set; }
        public double medohoka { get; set; }
        public double mesuhoka { get; set; }
        //public double debi { get; set; }
        //public string filler1 { get; set; }
        public double volume { get; set; }
        public double money { get; set; }
        public double nowmoney { get; set; }
        public double debirate { get; set; }
        public double nowvol { get; set; }
        public string time { get; set; }
        public string save_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public override string ToString()
        {
            //  추가되면 뒤에 변수 + " "붙여 줄것
            return ticker + "" + curprice + "" +  medohoka + "" + mesuhoka + "" + volume + "" + money + "" + nowmoney + "" + debirate + "" + nowvol + "" + time + "" + save_time;
            //return ticker + "" + curprice + "" + startprice + "" + highprice + "" + lowprice + ""+ medohoka + ""+ mesuhoka + "" + debi + "" + filler1 + "" + volume + "" + money + "" + nowmoney + "" + debirate + "" + nowvol + "" + time + "" + save_time;
        }
    }

    class jongCode_info
    {
        public ObjectId Id { get; set; }
        public string ticker { get; set; }
        public string standard_code { get; set; }
        public string kor_name { get; set; }
        public string us_name { get; set; }
        public string market { get; set; }

        public override string ToString()
        {
            //  추가되면 뒤에 변수 + " "붙여 줄것
            return ticker + "" + standard_code + "" + kor_name + "" + us_name + "" + market;
        }
    }
}
