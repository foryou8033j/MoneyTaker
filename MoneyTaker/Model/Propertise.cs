﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{
    
    public class Propertise
    {

        private static String documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

        public static readonly String APPNAME = "MoneyTaker";
        public static readonly String MODEL_PATH = documentPath + "\\MoneyTaker\\data.xml";
    }

    public class USERConfig
    {
        public static String EMAIL = "";
    }

    public class SMTPConfig
    {
        public static readonly String ID = "nightskyteam@gmail.com";
        public static readonly String PASSWORD = "Wjd3TkaTj##";
    }

    public class DBConfig
    {
        public static readonly String SERVER = "alcoholcoding.com";
        public static readonly String DB = "MoneyTaker";
        public static readonly String ID = "MoneyTaker";
        public static readonly String PASSWORD = @"9k5rmf\ht1a";
    }
}
