using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Co_opClasses;

namespace Co_opBackOffice
{
    public partial class frmDog : Form
    {
        public frmDog()
        {
            InitializeComponent();
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUpdate.Visible = false;
        }

        private void frmDog_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //call the display customers function

 //           lblError.Text = DisplayDogs() + " dogs found";
        }
  //      Int32 DisplayDogs()

        

        

        private void btnAdd_Click(object sender, EventArgs e)
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
                lblID.Text = "New dog's ID is: " + Convert.ToString(ADog.DogID);
            }
            else
            {
                lblID.Text = "";
            }

            void Add()
            {
                //create an instance ofthe collection class
                clsDogCollection DogCollection = new clsDogCollection();
                //validate the data on the web form
                String Error = DogCollection.ThisDog.Valid(txtName.Text, txtAge.Text, txtBreed.Text, txtSize.Text, txtGender.Text, txtDateAdded.Text);
                //if the data is ok the add it to the object
                if (Error == "")
                {
                    //get the data entered by the user 
                    DogCollection.ThisDog.Name = txtName.Text;
                    DogCollection.ThisDog.Age = Convert.ToInt32(txtAge.Text);
                    DogCollection.ThisDog.Breed = txtBreed.Text;
                    DogCollection.ThisDog.Size = txtSize.Text;
                    DogCollection.ThisDog.Gender = txtGender.Text;
                    DogCollection.ThisDog.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                    DogCollection.Add();
                    //confirmation message
                    lblAddEditConf.Text = "New dog added successfully";
                    //clear the text boxes
                    //populate the list 
  //                  lblError.Text = DisplayDogs() + " dogs found";
 //                   ClearTextBoxes();
                }
                else
                {
                    //report an error

                    lblAddEditConf.Text = "There were problems with the data entered " + Error;
                }
            }
        }
    }
}
