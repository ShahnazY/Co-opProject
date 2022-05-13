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
    public partial class frmPersonalInjury : Form
    {
        public frmPersonalInjury()
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

        Int32 DisplayPersonalInjuries()
        {
            clsPersonalInjuryCollection PersonalInjuries = new clsPersonalInjuryCollection();
            //find all claims
            lstPersonalInjuries.DataSource = PersonalInjuries.PersonalInjuriesList;
            lstPersonalInjuries.DisplayMember = "AllDetails";
            lstPersonalInjuries.ValueMember = "PersonalInjuryID";
            return PersonalInjuries.Count;
        }

        void Add()
        {
            clsPersonalInjuryCollection NewPersonalInjury = new clsPersonalInjuryCollection();
            String Error = NewPersonalInjury.ThisPersonalInjury.Valid(txtTypeOfInjury.Text, txtSeverity.Text, txtCompensation.Text);
            if (Error == "")
            {
                NewPersonalInjury.ThisPersonalInjury.TypeOfInjury = txtTypeOfInjury.Text;
                NewPersonalInjury.ThisPersonalInjury.Severity = txtSeverity.Text;
                NewPersonalInjury.ThisPersonalInjury.Compensation = Convert.ToDecimal(txtCompensation.Text);
                //add the record
                NewPersonalInjury.Add();
                //confirmation message box
                MessageBox.Show("New Personal Injury has been added successfully. ", "Personal Injuries list", MessageBoxButtons.OK);
                ClearTextBoxes();
                lblError.Text = DisplayPersonalInjuries() + "  Personal Injuries found";
            }
            else
            {
                MessageBox.Show("There were problems with the data entered. " + Error);
            }
        }

        void ClearTextBoxes()
        {
            txtTypeOfInjury.Text = string.Empty;
            txtSeverity.Text = string.Empty;
            txtCompensation.Text = string.Empty;
        }

   
        void DeletePersonalInjuries()
        {
            Int32 PersonalInjuryID;
            clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
            PersonalInjuryID = Convert.ToInt32(lstPersonalInjuries.SelectedValue);
            AllPersonalInjuries.ThisPersonalInjury.Find(PersonalInjuryID);
            AllPersonalInjuries.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DeletePersonalInjuries();
            lblConfirmation.Text = "Record has been deleted";
            btnYes.Visible = false;
            btnNO.Visible = false;
            lblError.Text = DisplayPersonalInjuries() + "  personal injuries found";
        }
       

        private void btnNO_Click(object sender, EventArgs e)
        {
            lblConfirmation.Text = string.Empty;
            btnNO.Visible = false;
            btnYes.Visible = false;
        }

      
        void Update()
        {
            Int32 PersonalInjuryID;
            PersonalInjuryID = Convert.ToInt32(lstPersonalInjuries.SelectedValue);
            clsPersonalInjuryCollection PersonalInjuriesCollection = new clsPersonalInjuryCollection();
            clsDataConnection DB = new clsDataConnection();
            String Error = PersonalInjuriesCollection.ThisPersonalInjury.Valid(txtTypeOfInjury.Text, txtSeverity.Text, txtCompensation.Text);
            if (Error == "")
            {
                PersonalInjuriesCollection.ThisPersonalInjury.Find(PersonalInjuryID);
                PersonalInjuriesCollection.ThisPersonalInjury.TypeOfInjury = txtTypeOfInjury.Text;
                PersonalInjuriesCollection.ThisPersonalInjury.Severity = txtSeverity.Text;
                PersonalInjuriesCollection.ThisPersonalInjury.Compensation = Convert.ToDecimal(txtCompensation.Text);
                //update the record
                PersonalInjuriesCollection.Update();
                ClearTextBoxes();
                lblError.Text = DisplayPersonalInjuries() + "  personal injuries found";
                lblConfirmation.Text = "The record has been updated.";
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
            }
            else
            {
                lblConfirmation.Text = "There were problems with the data entered " + Error;
            }
        }


        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayPersonalInjuries() + " personal injuries found";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 PersonalInjuryID;
            if (lstPersonalInjuries.SelectedIndex != -1)
            {
                PersonalInjuryID = Convert.ToInt32(lstPersonalInjuries.SelectedValue);
                lblConfirmation.Text = "Are you sure you want to delete this Injury? ";
                btnNO.Visible = true;
                btnYes.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a record from the list first .", "Personal Injuries List", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 PersonalInjuryID;
            if (lstPersonalInjuries.SelectedIndex != -1)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                PersonalInjuryID = Convert.ToInt32(lstPersonalInjuries.SelectedIndex);
                clsPersonalInjuryCollection AllPersonalInjuries = new clsPersonalInjuryCollection();
                AllPersonalInjuries.ThisPersonalInjury.Find(PersonalInjuryID);
                txtTypeOfInjury.Text = AllPersonalInjuries.ThisPersonalInjury.TypeOfInjury;
                txtSeverity.Text = AllPersonalInjuries.ThisPersonalInjury.Severity;
                txtCompensation.Text = AllPersonalInjuries.ThisPersonalInjury.Compensation.ToString();
            }
            else
            {
                lblError.Text = "Please select a record to be edited from the list";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            frmMenu MainPage = new frmMenu();
            MainPage.Show();
            this.Hide();
        }

        private void btnFilterTypeOfInjury_Click(object sender, EventArgs e)
        {

        }

        /*private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text != "")
            {
                Int32 Count;
                Count = DisplayClaimsByStatus(txtFilterStatus.Text);
                lblError.Text = Count + "  records found";
            }
            else
            {
                lblFilterError.Text = "Provide a valid filter";
            }
        }

        Int32 DisplayPersonalInjuriesByType(string StatusFilter)
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            Int32 Count;
            string Status;
            Int32 Index = 0;
            //lstClaims.Items.Clear();
            AllClaims.ReportByStatus(StatusFilter);
            Count = AllClaims.Count;
            while (Index < Count)
            {
                Status = Convert.ToString(AllClaims.ClaimsList[Index].Status);
                lstClaims.DataSource = AllClaims.ClaimsList;
                lstClaims.DisplayMember = "AllDetails";
                Index++;
            }
            return Count;
        }*/
    }
}
