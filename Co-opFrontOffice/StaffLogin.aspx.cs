using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaffLogin AStaffLogin = new clsStaffLogin();
        Int32 StaffLoginID;
        Boolean Found = false;
        StaffLoginID = Convert.ToInt32(txtStaffLoginID.Text);
        Found = AStaffLogin.Find(StaffLoginID);
        if (Found == true)
        {
            txtStaffID.Text = AStaffLogin.StaffID.ToString();
            txtEmail.Text = AStaffLogin.Email;
            txtPassword.Text = AStaffLogin.Password;
        }
        else
        {
            lblError.Text = "Staff could not be found";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaffLogin AStaffLogin = new clsStaffLogin();
        //capture the properties
        string StaffID = txtStaffID.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        //validate the data
        String Error = "";
        Error = AStaffLogin.Valid(StaffID, Email, Password);
        if (Error == "")
        {
            AStaffLogin.StaffID = Convert.ToInt32(StaffID);
            AStaffLogin.Email = Email;
            AStaffLogin.Password = Password;
            Session["AStaffLogin"] = AStaffLogin;
            Response.Write("StaffLoginViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}