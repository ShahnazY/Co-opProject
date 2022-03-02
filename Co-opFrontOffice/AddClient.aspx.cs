using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Co_op_Front_Office
{
    public partial class AddClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContinueClient.aspx");
        }

        protected void Submitbtn_Click(object sender, EventArgs e)
        {
            lblError.Text = "Thank you, an advisor will be with you with next 24 hours.";
        }
    }
}