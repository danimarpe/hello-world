using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithBigFiles
{
    public class ReadMethodResponse
    {
        public string message
        {
            get; set;
        }

        public bool success
        {
            get; set;
        }

        public static ReadMethodResponse GoodResponse()
        {
            return new ReadMethodResponse { message = "Reading complete succesfully", success = true };
        }

        public static ReadMethodResponse BadResponse(Exception ex = null)
        {
            if (ex == null)
                ex = new Exception("An unknown error has occurred");

            return new ReadMethodResponse { message = "Reading failed: " + ex.Message, success = false };
        }
    }
}