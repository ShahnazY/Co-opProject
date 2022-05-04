using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class AddStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create new instance of the class
        clsStaff AStaff = new clsStaff();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Gender = ddlGender.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Email = txtEmail.Text;
        string Department = txtDepartment.Text;
        string Error = "";
        //validate the data
        Error = AStaff.Valid(FirstName, LastName, Gender, DateOfBirth, Email, Department);
        if (Error == "")
        {
            //capture the properties
            AStaff.FirstName = FirstName;
            AStaff.LastName = LastName;
            AStaff.Gender = Gender;
            AStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AStaff.Email = Email;
            AStaff.Department = Department;
            //store the staff in the session object
            Session["AStaff"] = AStaff;
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            ddlGender.Text = AStaff.Gender;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtDepartment.Text = AStaff.Department;
        }
        else
        {
            lblError.Text = "Staff could not be found";
        }
    }
}
