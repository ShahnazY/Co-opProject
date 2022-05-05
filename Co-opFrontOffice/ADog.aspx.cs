using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Co_opClasses;
using ClassLibrary;

public partial class ADog : System.Web.UI.Page
{
    Int32 DogID;
    protected void Page_Load(object sender, EventArgs e)
    {
        DogID = Convert.ToInt32(Session["DogID"]);
    }

    protected void btnAddDog_Click(object sender, EventArgs e)
    {
        Add();
        //dispaly  added dog ID
        //create an instance of the dog class
        clsDog ADog = new clsDog();
        //variable to store the primary key 
        //variable to store the result of the find operation
        Boolean Found = false;
        //find the last  record
        Found = ADog.FindLastDogID();

        //if found

        if (Found == true)

        {
            //display the values of the properties in the labels

            lblDogID.Text = "Your Dog's ID is: " + Convert.ToString(ADog.DogID) + ". Remeber the Dog ID to add a insurance cover";
        }

        else

        {

            lblDogID.Text = "";

        }
    }
     void Add()
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

    protected void txtDogName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnAddInsuranceCover_Click(object sender, EventArgs e)
    {
        Response.Redirect("InsuranceCoverage.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }
}