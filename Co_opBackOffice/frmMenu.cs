using Co_opBackOffice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFunds Funds = new frmFunds();
            Funds.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPersonalInjury Injuries = new frmPersonalInjury();
            Injuries.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomer Customers = new frmCustomer();
            Customers.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClaims Claims = new frmClaims();
            Claims.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDog Dogs = new frmDog();
            Dogs.Show();
            this.Hide();
        }
    }
}
