using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class PersonalInjuryViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //instance of the clsClaim
        clsPersonalInjury APersonalInjury = new clsPersonalInjury();
        //get the data from the session object
        APersonalInjury = (clsPersonalInjury)Session["APersonalInjury"];
        //display the house  number for this entry
        Response.Write(APersonalInjury.TypeOfInjury);
        Response.Write(APersonalInjury.Severity);
        Response.Write(APersonalInjury.Compensation);
    }
}