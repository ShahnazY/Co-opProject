using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;

public partial class ADog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAddDog_Click(object sender, EventArgs e)
    {

        //create a new instace of clsDog
        clsDog ADog = new clsDog();
        //capture the dog's name
        ADog.Name = txtDogName.Text;
        //store the name in the session object
        Session["ADog"] = ADog;
        //redirect to the viewer page
        Response.Redirect("DogViewer.aspx");

    }

    protected void txtDogName_TextChanged(object sender, EventArgs e)
    {

    }
}