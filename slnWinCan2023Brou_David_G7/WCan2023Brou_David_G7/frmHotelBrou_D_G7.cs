using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Brou_Davidspace;

namespace WCan2023Brou_David_G7
{
    public partial class frmHotelBrou_D_G7 : Form
    {
        char optionAppel = 'A';
        MySqlConnection SqlConX = new MySqlConnection();
        public frmHotelBrou_D_G7()
        {
            InitializeComponent();
            rafraichirList();
        }
        private void rafraichirList()
        {
            lviewRech.Items.Clear();
            DataTable dt = SelectAll(txtRecherche.Text);
            foreach (DataRow row in dt.Rows)
            {
                string vJoueur_ID = "";
                string vNom = "";
                string vPrenom = "";
                string vDate_Naiss = "";
                string vLieu_Naiss = "";
                string vPoste = "";
                string vPoste2 = "";

                if (!DBNull.Value.Equals(row["HotelID_Brou_K_G7"])) vJoueur_ID = row["HotelID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelNom_Brou_K_G7"])) vNom = row["HotelNom_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelEmail_Brou_K_G7"])) vPrenom = row["HotelEmail_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelNbreEtoile_Brou_K_G7"])) vDate_Naiss = row["HotelNbreEtoile_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelTel_Brou_K_G7"])) vPoste = row["HotelTel_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelAdrVille_Brou_K_G7"])) vPoste2 = row["HotelAdrVille_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelTarifJour_Brou_K_G7"])) vLieu_Naiss = row["HotelTarifJour_Brou_K_G7"].ToString();


                ListViewItem itm = lviewRech.Items.Add(vJoueur_ID);
                itm.SubItems.Add(vNom);
                itm.SubItems.Add(vPrenom);
                itm.SubItems.Add(vDate_Naiss);
                itm.SubItems.Add(vPoste2);
                itm.SubItems.Add(vPoste);
                itm.SubItems.Add(vLieu_Naiss);
                itm.Tag = vJoueur_ID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Hotel";
        }

        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            DataTable dt = new DataTable();

            using (MySqlConnection SqlConX = new MySqlConnection(ConxStr))
            {
                SqlConX.Open();

                MySqlCommand cmd = new MySqlCommand("SPX_hotel_Brou_K_G7_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                // Créer le paramètre pour le nom de l'hôtel
                MySqlParameter prm = new MySqlParameter("pHotelNom_Brou_K_G7", MySqlDbType.VarChar, 100);
                prm.Value = pUserNom;
                cmd.Parameters.Add(prm);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtHotelID.Text))
            {
                MessageBox.Show("ID Nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHotelID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Nom de nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAdress.Text))
            {
                MessageBox.Show("Rôle d'Encardreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdress.Focus();
                return false;
            }
            return true;
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pHotelID_Brou_K_G7", txtHotelID.Text);
            pCmd.Parameters.AddWithValue("pHotelNom_Brou_K_G7", txtNom.Text);
            pCmd.Parameters.AddWithValue("pHotelEmail_Brou_K_G7", txtEmail.Text);
            pCmd.Parameters.AddWithValue("pHotelNbreEtoile_Brou_K_G7", txtNbreEtoile.Text);
            pCmd.Parameters.AddWithValue("pHotelTel_Brou_K_G7", txtContact.Text);
            pCmd.Parameters.AddWithValue("pHotelAdrVille_Brou_K_G7", txtAdress.Text);
            pCmd.Parameters.AddWithValue("pHotelTarifJour_Brou_K_G7", txtTarrifday.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHotelBrou_D_G7_Load(object sender, EventArgs e)
        {

        }
        private void MiseABlanc()
        {
            txtHotelID.Text = "";
            txtNom.Text = "";
            txtEmail.Text = "";
            txtAdress.Text = "";
            txtNbreEtoile.Text = "";
            txtContact.Text = "";
            txtTarrifday.Text = "";
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                string constr = Divers.MySQLDBConX();
                MySqlConnection con = new MySqlConnection(constr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();

                switch (optionAppel)
                {
                    case 'A':
                        cmd = new MySqlCommand("SPX_hotel_Brou_K_G7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La saisie a été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        cmd = new MySqlCommand("SPX_hotel_Brou_K_G7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La modification a été enregistrée", Application.ProductName);
                        break;
                    case 'S':
                        cmd = new MySqlCommand("SPX_hotel_Brou_K_G7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pHotelID_Brou_K_G7", txtHotelID.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La suppression a été effectuée", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                con.Close();
            }
        }
        public IDataReader GetEncadreur(string pEncadreurID)
        {
            IDataReader? dr = null;
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_hotel_Brou_K_G7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("pHotelID_Brou_K_G7", MySqlDbType.VarChar);
            prm.Value = pEncadreurID;
            cmd.Parameters.Add(prm);

            dr = cmd.ExecuteReader();
            return dr;
        }
        private void ChargerEncadreur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["HotelID_Brou_K_G7"])))
            {
                txtHotelID.Text = pDreader["HotelID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelNom_Brou_K_G7"])))
            {
                txtNom.Text = pDreader["HotelNom_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelEmail_Brou_K_G7"])))
            {
                txtEmail.Text = pDreader["HotelEmail_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelNbreEtoile_Brou_K_G7"])))
            {
                txtNbreEtoile.Text = pDreader["HotelNbreEtoile_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelTel_Brou_K_G7"])))
            {
                txtContact.Text = pDreader["HotelTel_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelAdrVille_Brou_K_G7"])))
            {
                txtAdress.Text = pDreader["HotelAdrVille_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelTarifJour_Brou_K_G7"])))
            {
                txtTarrifday.Text = pDreader["HotelTarifJour_Brou_K_G7"].ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Modification d'encadreur]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'M';
                string pEncadreurID = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetEncadreur(pEncadreurID);
                if (dreader.Read())
                {
                    ChargerEncadreur(dreader);
                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Ok_Modifier";
                }
                SqlConX.Close();
            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Consultation d'encadreur]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'C';
                string pEncadreurID = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetEncadreur(pEncadreurID);
                if (dreader.Read())
                {
                    ChargerEncadreur(dreader);
                    btnEnregistrer.Enabled = false;
                    btnEnregistrer.Text = "Enregistrer";
                }
                SqlConX.Close();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'S';

                string pEncadreurID = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetEncadreur(pEncadreurID);
                if (dreader.Read())
                {
                    ChargerEncadreur(dreader);
                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Supprimer";
                }
                SqlConX.Close();
            }
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtHotelID.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel utilisateur]";
        }
    }
}
