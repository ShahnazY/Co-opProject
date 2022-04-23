using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class APersonalInjury : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (IsPostBack == false)
        {
            DisplayPersonalInjuries();
        }*/

        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPersonalInjury APersonalInjury = new clsPersonalInjury();
        //capture the properties
        APersonalInjury.TypeOfInjury = ddlTypeOfInjury.Text;
        APersonalInjury.Severity = txtSeverity.Text;
        APersonalInjury.Compensation = Convert.ToDecimal(txtCompensation.Text);
        //store personal injury in the session object
        Session["APersonalInjury"] = APersonalInjury;
        Response.Redirect("PersonalInjuryViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    /*void DisplayPersonalInjuries()
    {
        clsPersonalInjuryCollection TypeOfInjuries = new clsPersonalInjuryCollection();
        ddlTypeOfInjury.DataSource = TypeOfInjuries.AllPersonalInjuries;
        ddlTypeOfInjury.DataValueField = "PersonalInjuryID";
        ddlTypeOfInjury.DataTextField = "TypeOfInjury";
        ddlTypeOfInjury.DataBind();
    }*/
}