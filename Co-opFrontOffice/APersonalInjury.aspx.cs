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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsPersonalInjury APersonalInjury = new clsPersonalInjury();
        //variable to store the primary key
        Int32 PersonalInjuryID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        PersonalInjuryID = Convert.ToInt32(txtInjuryID.Text);
        //find the record 
        Found = APersonalInjury.Find(PersonalInjuryID);
        //if found 
        if (Found == true)
        {
            //display the values in the textboxes
            txtSeverity.Text = APersonalInjury.Severity;
            txtCompensation.Text = APersonalInjury.Compensation.ToString();
        }
        else
        {
            lblError.Text = "Injury not found";
        }
    }
}