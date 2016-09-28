using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WorkingWithBigFiles
{
    public class Config
    {
        public static string outputFilePath
        {
            get
            {
                return ConfigurationManager.AppSettings["ouputFilePath"];
            }
        }
    }
}