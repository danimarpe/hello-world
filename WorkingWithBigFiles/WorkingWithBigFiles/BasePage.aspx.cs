using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithBigFiles
{
    public partial class BasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowSuccessMessage(string message)
        {
            LabelSuccess.Text = message;
            LabelSuccess.Visible = true;
        }

        protected void ShowFailMessage(string message)
        {
            LabelFail.Text = message;
            LabelFail.Visible = true;
        }
    }
}