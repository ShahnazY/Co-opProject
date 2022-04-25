using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;


public partial class AddingDogViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsDog
        clsDog ADog = new clsDog();
        //get the data from the session object
        ADog = (clsDog)Session["ADog"];
        //display the Dog ID for this entry
        Response.Write(ADog.Name);
    }
}