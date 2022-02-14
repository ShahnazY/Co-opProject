using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AClaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        string Error;
        string Status;
        Status = txtStatus.Text;
        Error = AClaim.Valid(Status);
        lblError.Text = Error;
    }
}