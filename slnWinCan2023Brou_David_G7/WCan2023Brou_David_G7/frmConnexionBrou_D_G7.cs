using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCan2023Brou_David_G7
{
    public partial class frmConnexionBrou_D_G7 : Form
    {
        public frmConnexionBrou_D_G7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void frmConnexionBrou_D_G7_Load(object sender, EventArgs e)
        {

        }



        private void btnok_Click_1(object sender, EventArgs e)
        {
            if (txtlogin.Text == "Brou David" && txtpassword.Text == "1234")
            {
                frmMenuPrincipalBrou_D_G7 frm = new frmMenuPrincipalBrou_D_G7();
                frm.ShowDialog();
            }
            else MessageBox.Show("Login ou mot de passe incorrect", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
