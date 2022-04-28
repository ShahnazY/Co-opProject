using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class DeleteClaim : System.Web.UI.Page
{
    Int32 ClaimID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ClaimID = Convert.ToInt32(Session["ClaimID"]);
    }

    void DeleteAClaim()
    {
        clsClaimCollection Claims = new clsClaimCollection();
        //find the record to delete
        Claims.ThisClaim.Find(ClaimID);
        //delete the record 
        Claims.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteAClaim();
        Response.Redirect("ClaimList.aspx");
    }
}