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

        private void txtPersonalInjury_Click(object sender, EventArgs e)
        {
            frmClaims Claims = new frmClaims();
            Claims.Show();
            this.Hide();
        }

        private void btnDogInsurance_Click(object sender, EventArgs e)
        {
            frmDogs Dogs = new frmDogs();
            Dogs.Show();
            this.Hide();
        }
    }
}
