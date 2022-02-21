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
        if (IsPostBack == false)
        {
            DisplayPersonalInjuries();
        }
            
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPersonalInjury APersonalInjury = new clsPersonalInjury();
        string Error;
        string Severity;
        Severity = txtSeverity.Text;
        Error = APersonalInjury.Valid(Severity);
        lblError.Text = Error;
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    void DisplayPersonalInjuries()
    {
        clsPersonalInjuryCollection TypeOfInjuries = new clsPersonalInjuryCollection();
        ddlTypeOfInjury.DataSource = TypeOfInjuries.AllPersonalInjuries;
        ddlTypeOfInjury.DataValueField = "PersonalInjuryID";
        ddlTypeOfInjury.DataTextField = "TypeOfInjury";
        ddlTypeOfInjury.DataBind();
    }
}