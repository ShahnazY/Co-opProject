using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_opBackOffice
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnClaimManagement_Click(object sender, EventArgs e)
        {
            frmClaims Claims = new frmClaims();
            Claims.Show();
            this.Hide();
        }

        private void btnPersonalInjury_Click(object sender, EventArgs e)
        {
            frmPersonalInjury PersonalInjuries = new frmPersonalInjury();
            PersonalInjuries.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer Customers = new frmCustomer();
            Customers.Show();
            this.Hide();
        }
    }
}
