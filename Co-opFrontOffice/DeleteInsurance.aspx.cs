using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class DeleteInsurance : System.Web.UI.Page
{
    Int32 InsuranceID;
    protected void Page_Load(object sender, EventArgs e)
    {
        InsuranceID = Convert.ToInt32(Session["InsuranceID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        {
            DeleteAnInsurance();
            Response.Redirect("InsuranceList.aspx");
        }
    }
    void DeleteAnInsurance()
    {
        clsInsuranceCollection Insurance = new clsInsuranceCollection();
        //find the record to delete
        Insurance.ThisInsurance.Find(InsuranceID);
        //delete the record 
        Insurance.Delete();
    }
}