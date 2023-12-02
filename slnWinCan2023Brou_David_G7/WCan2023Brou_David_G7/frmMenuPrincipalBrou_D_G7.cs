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
    public partial class frmMenuPrincipalBrou_D_G7 : Form
    {
        public frmMenuPrincipalBrou_D_G7()
        {
            InitializeComponent();
        }

        private void encadreurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncardreurBrou_D_G7 frm = new frmEncardreurBrou_D_G7();
            frm.ShowDialog();
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipalBrou_D_G7_Load(object sender, EventArgs e)
        {

        }

        private void dELEGATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void competitionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJoueursBrou_D_G7 frm = new frmJoueursBrou_D_G7();
            frm.ShowDialog();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotelBrou_D_G7 frm = new frmHotelBrou_D_G7();
            frm.ShowDialog();
        }

        private void nationParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationParticipe_Brou_D_G7 frm = new NationParticipe_Brou_D_G7();
            frm.ShowDialog();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUtilisateurBrou_D_G7 frm = new frmUtilisateurBrou_D_G7();
            frm.ShowDialog();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatch_Jouer_G7 frm = new frmMatch_Jouer_G7();
            frm.ShowDialog();
        }

        private void mVTHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMVTHotel_Brou_D_G7 frm = new frmMVTHotel_Brou_D_G7();
            frm.ShowDialog();
        }
    }
}
