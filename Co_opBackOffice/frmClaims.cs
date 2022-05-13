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
    public partial class frmClaims : Form
    {
        public frmClaims()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnYes.Visible = false;
            btnNO.Visible = false;
        }

        private void frmClaims_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        Int32 DisplayClaims()
        {
            clsClaimCollection Claims = new clsClaimCollection();
            //find all claims
            lstClaims.DataSource = Claims.ClaimsList;
            lstClaims.DisplayMember = "AllDetails";
            lstClaims.ValueMember = "ClaimID";
            return Claims.Count;
        }

        void Add()
        {
            clsClaimCollection NewClaim = new clsClaimCollection();
            String Error = NewClaim.ThisClaim.Valid(txtLocation.Text, txtDateOfClaim.Text, txtDateOfInjury.Text);
            if (Error == "")
            {
                NewClaim.ThisClaim.Location = txtLocation.Text;
                NewClaim.ThisClaim.DateOfClaim = Convert.ToDateTime(txtDateOfClaim.Text);
                NewClaim.ThisClaim.DateOfInjury = Convert.ToDateTime(txtDateOfInjury.Text);
                NewClaim.ThisClaim.Status = txtStatus.Text;
                NewClaim.ThisClaim.EvidenceProvided = chkYes.Checked;
                //add the record
                NewClaim.Add();
                //confirmation message box
                MessageBox.Show("New Claim has been added successfully. ", "Claims list", MessageBoxButtons.OK);
                ClearTextBoxes();
                lblError.Text = DisplayClaims() + "  trainers found";
            }
            else
            {
                MessageBox.Show("There were problems with the data entered. " + Error);
            }
        }

        void ClearTextBoxes()
        {
            txtLocation.Text = string.Empty;
            txtDateOfClaim.Text = string.Empty;
            txtDateOfInjury.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 ClaimID;
            if (lstClaims.SelectedIndex != -1)
            {
                ClaimID = Convert.ToInt32(lstClaims.SelectedValue);
                lblConfirmation.Text = "Are you sure you want to delete this claim? ";
                btnNO.Visible = true;
                btnYes.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a record from the list first .", "Claims List", MessageBoxButtons.OK);
            }
        }

        void DeleteClaims()
        {
            Int32 ClaimID;
            clsClaimCollection AllClaims = new clsClaimCollection();
            ClaimID = Convert.ToInt32(lstClaims.SelectedValue);
            AllClaims.ThisClaim.Find(ClaimID);
            AllClaims.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DeleteClaims();
            lblConfirmation.Text = "Record has been deleted";
            btnYes.Visible = false;
            btnNO.Visible = false;
            lblError.Text = DisplayClaims() + "  claims found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayClaims() + " claims found";
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            lblConfirmation.Text = string.Empty;
            btnNO.Visible = false;
            btnYes.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 ClaimID;
            if (lstClaims.SelectedIndex != -1)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                ClaimID = Convert.ToInt32(lstClaims.SelectedIndex);
                clsClaimCollection AllClaims = new clsClaimCollection();
                AllClaims.ThisClaim.Find(ClaimID);
                txtLocation.Text = AllClaims.ThisClaim.Location;
                txtStatus.Text = AllClaims.ThisClaim.Status;
                txtDateOfClaim.Text = AllClaims.ThisClaim.DateOfClaim.ToString();
                txtDateOfInjury.Text = AllClaims.ThisClaim.DateOfInjury.ToString();
                chkYes.Checked = AllClaims.ThisClaim.EvidenceProvided;
            }
            else
            {
                lblError.Text = "Please select a record to be edited from the list";
            }
        }

        void Update()
        {
            Int32 ClaimID;
            ClaimID = Convert.ToInt32(lstClaims.SelectedValue);
            clsClaimCollection ClaimsCollection = new clsClaimCollection();
            clsDataConnection DB = new clsDataConnection();
            String Error = ClaimsCollection.ThisClaim.Valid(txtLocation.Text, txtDateOfClaim.Text, txtDateOfInjury.Text);
            if (Error == "")
            {
                ClaimsCollection.ThisClaim.Find(ClaimID);
                ClaimsCollection.ThisClaim.Location = txtLocation.Text;
                ClaimsCollection.ThisClaim.DateOfClaim = Convert.ToDateTime(txtDateOfClaim.Text);
                ClaimsCollection.ThisClaim.DateOfInjury = Convert.ToDateTime(txtDateOfInjury.Text);
                ClaimsCollection.ThisClaim.Status = txtStatus.Text;
                ClaimsCollection.ThisClaim.EvidenceProvided = chkYes.Checked;
                //update the record
                ClaimsCollection.Update();
                ClearTextBoxes();                
                lblError.Text = DisplayClaims() + "  claims found";
                lblConfirmation.Text = "The record has been updated.";
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
            }
            else
            {
                lblConfirmation.Text = "There were problems with the data entered " + Error;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
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

        Int32 DisplayClaimsByStatus(string StatusFilter)
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
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            frmMenu MainPage = new frmMenu();
            MainPage.Show();
            this.Hide();
        }
    }
}
