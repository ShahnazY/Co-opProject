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
using ClassLibrary;
using BackOffice;

namespace Co_opBackOffice
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnYes.Visible = false;
            btnNO.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        Int32 DisplayCustomers()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();
            //find all claims
            lstCustomers.DataSource = Customers.CustomersList;
            lstCustomers.DisplayMember = "AllDetails";
            lstCustomers.ValueMember = "CustomerID";
            return Customers.Count;
        }

        void Add()
        {
            clsCustomerCollection NewCustomer = new clsCustomerCollection();
            String Error = NewCustomer.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtGender.Text, txtEmail.Text, txtDateOfBirth.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostcode.Text);
            if (Error == "")
            {
                NewCustomer.ThisCustomer.FirstName = txtFirstName.Text;
                NewCustomer.ThisCustomer.LastName = txtLastName.Text;
                NewCustomer.ThisCustomer.Gender = txtGender.Text;
                NewCustomer.ThisCustomer.Email = txtEmail.Text;
                NewCustomer.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                NewCustomer.ThisCustomer.HouseNo = txtHouseNo.Text;
                NewCustomer.ThisCustomer.Street = txtStreet.Text;
                NewCustomer.ThisCustomer.Town = txtTown.Text;
                NewCustomer.ThisCustomer.PostCode = txtPostcode.Text;
                //add the record
                NewCustomer.Add();
                //confirmation message box
                MessageBox.Show("New customer has been added successfully. ", "Customers list", MessageBoxButtons.OK);
                ClearTextBoxes();
                lblError.Text = DisplayCustomers() + "  customers found";
            }
            else
            {
                MessageBox.Show("There were problems with the data entered. " + Error);
            }

           
        }
        void ClearTextBoxes()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtHouseNo.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtTown.Text = string.Empty;
            txtPostcode.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 CustomerID;
            if (lstCustomers.SelectedIndex != -1)
            {
                CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
                lblConfirmation.Text = "Are you sure you want to delete this customer? ";
                btnNO.Visible = true;
                btnYes.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a record from the list first .", "Customers List", MessageBoxButtons.OK);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //DeleteCustomers();
            lblConfirmation.Text = "Record has been deleted";
            btnYes.Visible = false;
            btnNO.Visible = false;
            lblError.Text = DisplayCustomers() + "  customers found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayCustomers() + " customers found";
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            lblConfirmation.Text = string.Empty;
            btnNO.Visible = false;
            btnYes.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 CustomerID;
            if (lstCustomers.SelectedIndex != -1)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                CustomerID = Convert.ToInt32(lstCustomers.SelectedIndex);
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                AllCustomers.ThisCustomer.Find(CustomerID);
                txtFirstName.Text = AllCustomers.ThisCustomer.FirstName;
                txtLastName.Text = AllCustomers.ThisCustomer.LastName;
                txtGender.Text = AllCustomers.ThisCustomer.Gender;
                txtEmail.Text = AllCustomers.ThisCustomer.Email;
                txtDateOfBirth.Text = AllCustomers.ThisCustomer.DateOfBirth.ToString();
                txtHouseNo.Text = AllCustomers.ThisCustomer.HouseNo;
                txtStreet.Text = AllCustomers.ThisCustomer.Street;
                txtTown.Text = AllCustomers.ThisCustomer.Town;
                txtPostcode.Text = AllCustomers.ThisCustomer.PostCode;
            }
            else
            {
                lblError.Text = "Please select a record to be edited from the list";
            }
        }

        void Update()
        {
            Int32 CustomerID;
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            clsCustomerCollection CustomersCollection = new clsCustomerCollection();
            clsDataConnection DB = new clsDataConnection();
            String Error = CustomersCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtGender.Text, txtEmail.Text, txtDateOfBirth.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostcode.Text);
            if (Error == "")
            {
                CustomersCollection.ThisCustomer.Find(CustomerID);
                CustomersCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomersCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomersCollection.ThisCustomer.Gender = txtGender.Text;
                CustomersCollection.ThisCustomer.Email = txtEmail.Text;
                CustomersCollection.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                CustomersCollection.ThisCustomer.HouseNo = txtHouseNo.Text;
                CustomersCollection.ThisCustomer.Street = txtStreet.Text;
                CustomersCollection.ThisCustomer.Town = txtTown.Text;
                CustomersCollection.ThisCustomer.PostCode = txtPostcode.Text;
                //update the record
                CustomersCollection.Update();
                ClearTextBoxes();
                lblError.Text = DisplayCustomers() + "  customers found";
                lblConfirmation.Text = "The record has been updated.";
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
            }
            else
            {
                lblConfirmation.Text = "There were problems with the data entered " + Error;
            }
        } 

        void DeleteCustomers()
        {
            Int32 CustomerID;
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            AllCustomers.ThisCustomer.Find(CustomerID);
            AllCustomers.Delete();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            frmMenu MainPage = new frmMenu();
            MainPage.Show();
            this.Hide();
        }
    }
}
