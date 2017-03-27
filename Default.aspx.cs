using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendSMS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            SendSMS("353831574902");
        }

        private void SendSMS(string phoneNumber)
        {

        }
    }
}