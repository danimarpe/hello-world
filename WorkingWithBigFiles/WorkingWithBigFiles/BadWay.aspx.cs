using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithBigFiles
{
    public partial class BadWay : BasePage
    {
        public BadWay():base()
        { }

        /// <summary>
        /// Fired when the user clicks on "Try it!" button
        /// It calls to the BadWay read method, to read the file causing errors and using too much memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnBadWay_Click(object sender, EventArgs e)
        {
            if (FileBadWay.HasFile)
            {
                ReadMethodResponse response = ReadFileMethods.BadWay(FileBadWay.PostedFile);

                if (response.success)
                    ShowSuccessMessage(response.message);
                else
                    ShowFailMessage(response.message);
            }
        }
    }
}