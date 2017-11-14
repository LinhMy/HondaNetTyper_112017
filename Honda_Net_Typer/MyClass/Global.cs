using DevExpress.Office.Utils;
using System.Collections.Generic;

namespace Honda_Net_Typer.MyClass
{
    internal class Global
    {
        
        public static Honda_Net_Typer_BPODataContext DbBpo = new Honda_Net_Typer_BPODataContext();
        public static Honda_Net_Typer_DataDataContext Db =new Honda_Net_Typer_DataDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = "";
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string StrToken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.248\Honda_net_typer$";
        public static string Webservice = "http://10.10.10.248:8888/Honda_net_typer/";
        public static string StrIdProject = "Honda_Net_Typer";
        public static string Version = "1.0.1";
        public static string UrlUpdateVersion = @"\\10.10.10.254\DE_Viet\2017\Honda_Net_Typer\Tools";
        public static int FreeTime = 0;
        public static bool FlagTong = false;
    }
}