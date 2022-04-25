using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class InsuranceCoverage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsInsurance
        clsInsurance AInsurance = new clsInsurance();
        //capture the dog's name
        AInsurance.Cover = ddlCover.Text;
        //store the name in the session object
        Session["AInsurance"] = AInsurance;
        //redirect to the viewer page
        Response.Redirect("InsuranceCoverageViewer.aspx");
    }
}