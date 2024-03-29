﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Co_opClasses;

namespace BackOffice
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSecurity Sec = new clsSecurity();
            //get the new users details
            string EMail = txtEMail.Text;
            string Password1 = txtPassword1.Text;
            string Password2 = txtPassword2.Text;
            //try to sign up the new user
            lblError.Text = Sec.SignUp(EMail, Password1, Password2,true);
        }
    }
}
