using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithBigFiles
{
    public partial class GoodWay : BasePage
    {
        public GoodWay():base()
        { }

        protected void BtnGoodWay_Click(object sender, EventArgs e)
        {
            if (FileGoodWay.HasFile)
            {
                ReadMethodResponse response = ReadFileMethods.GoodWay(FileGoodWay.PostedFile);

                if (response.success)
                    ShowSuccessMessage(response.message);
                else
                    ShowFailMessage(response.message);
            }
        }
    }
}