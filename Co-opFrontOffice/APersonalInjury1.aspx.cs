using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class APersonalInjury1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPersonalInjury APersonalInjury = new clsPersonalInjury();
        //capture the properties
        string TypeOfInjury = ddlTypeOfInjury.Text;
        string Severity = txtSeverity.Text;
        string Compensation = txtCompensation.Text;
        string Error = "";
        //validate the data
        Error = APersonalInjury.Valid(TypeOfInjury, Severity, Compensation);
        if (Error == "")
        {
            APersonalInjury.TypeOfInjury = TypeOfInjury;
            APersonalInjury.Severity = txtSeverity.Text;
            //APersonalInjury.Compensation = Convert.ToDecimal(Compensation);
            //store personal injury in the session object
            Session["APersonalInjury"] = APersonalInjury;
            Response.Redirect("AClaim1.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    /*protected void btnFind_Click(object sender, EventArgs e)
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
    }*/
}