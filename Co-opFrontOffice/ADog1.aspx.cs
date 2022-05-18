using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;
using ClassLibrary;

public partial class ADog1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnAddInsuranceCover_Click(object sender, EventArgs e)
    {
        Response.Redirect("InsuranceCoverage1.aspx");
    }

    protected void btnAddDog_Click(object sender, EventArgs e)
    {
        //create an instance ofthe collection class
        clsDogCollection DogCollection = new clsDogCollection();
        clsDataConnection DB = new clsDataConnection();
        //validate the data on the web form
        String Error = DogCollection.ThisDog.Valid(txtDogName.Text, txtDogAge.Text, txtBreed.Text, txtSize.Text, txtGender.Text, txtDateAdded.Text);
        //if the data is ok the add it to the object
        if (Error == "")
        {
            //get the data entered by the user 
            DogCollection.ThisDog.Name = txtDogName.Text;
            DogCollection.ThisDog.Age = Convert.ToInt32(txtDogAge.Text);
            DogCollection.ThisDog.Breed = txtBreed.Text;
            DogCollection.ThisDog.Size = txtSize.Text;
            DogCollection.ThisDog.Gender = txtGender.Text;
            DogCollection.ThisDog.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //add the record
            DogCollection.Add();
            lblError.Text = "Account for dog has been created.";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
}