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
    public partial class frmMVTHotel_Brou_D_G7 : Form
    {
        char optionAppel = 'A';
        MySqlConnection SqlConX = new MySqlConnection();
        public frmMVTHotel_Brou_D_G7()
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

                if (!DBNull.Value.Equals(row["mvtHotelID_Brou_K_G7"])) vJoueur_ID = row["mvtHotelID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["HotelCode_Brou_K_G7"])) vNom = row["HotelCode_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["dateDepart_Brou_K_G7"])) vPrenom = (string)row["dateDepart_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["dateArrivee_Brou_K_G7"])) vDate_Naiss = row["dateArrivee_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["CoutTotalSejour_Brou_K_G7"])) vLieu_Naiss = row["CoutTotalSejour_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatParticipID_Brou_K_G7"])) vPoste = row["NatParticipID_Brou_K_G7"].ToString();


                ListViewItem itm = lviewRech.Items.Add(vJoueur_ID);
                itm.SubItems.Add(vNom);
                itm.SubItems.Add(vPrenom);
                itm.SubItems.Add(vDate_Naiss);
                itm.SubItems.Add(vLieu_Naiss);
                itm.SubItems.Add(vPoste);
                itm.Tag = vJoueur_ID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Mouvement";
        }
        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            using (MySqlConnection SqlConX = new MySqlConnection(ConxStr))
            {
                SqlConX.Open();
                MySqlCommand cmd = new MySqlCommand("SPX_mvthotel_Brou_K_G7_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter prm;
                prm = new MySqlParameter("pHotelCode_Brou_K_G7", MySqlDbType.VarChar, 50);
                prm.Value = pUserNom;
                cmd.Parameters.Add(prm);

                DataTable dt = new DataTable();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        public IDataReader GetEncadreur(string pEncadreurID)
        {
            IDataReader? dr = null;
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_mvthotel_Brou_K_G7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("pmvtHotelID_Brou_K_G7", MySqlDbType.VarChar);
            prm.Value = pEncadreurID;
            cmd.Parameters.Add(prm);

            dr = cmd.ExecuteReader();
            return dr;
        }
        private void ChargerEncadreur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["NatParticipID_Brou_K_G7"])))
            {
                txtNatPartcipID.Text = pDreader["NatParticipID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["mvtHotelID_Brou_K_G7"])))
            {
                txtMouvHotelId.Text = pDreader["mvtHotelID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["HotelCode_Brou_K_G7"])))
            {
                txtHotelCode.Text = pDreader["HotelCode_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["dateDepart_Brou_K_G7"])))
            {
                dtDepard.Text = pDreader["dateDepart_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["dateArrivee_Brou_K_G7"])))
            {
                dtArriv.Text = pDreader["dateArrivee_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["CoutTotalSejour_Brou_K_G7"])))
            {
                txtCoutTOtalSejourne.Text = pDreader["CoutTotalSejour_Brou_K_G7"].ToString();
            }
        }
        private void MiseABlanc()
        {
            txtNatPartcipID.Text = "";
            txtMouvHotelId.Text = "";
            txtHotelCode.Text = "";
            dtDepard.Text = "";
            dtArriv.Text = "";
            txtCoutTOtalSejourne.Text = "";
            label7.Text = "Nom de Nation";
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtNatPartcipID.Text))
            {
                MessageBox.Show("ID Nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNatPartcipID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMouvHotelId.Text))
            {
                MessageBox.Show("Nom de nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMouvHotelId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHotelCode.Text))
            {
                MessageBox.Show("Rôle d'Encardreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHotelCode.Focus();
                return false;
            }
            return true;
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pNatParticipID_Brou_K_G7", txtNatPartcipID.Text);
            pCmd.Parameters.AddWithValue("pmvtHotelID_Brou_K_G7", txtMouvHotelId.Text);
            pCmd.Parameters.AddWithValue("pHotelCode_Brou_K_G7", txtHotelCode.Text);
            pCmd.Parameters.AddWithValue("pdateDepart_Brou_K_G7", dtDepard.Text);
            pCmd.Parameters.AddWithValue("pdateArrivee_Brou_K_G7", dtArriv.Text);
            pCmd.Parameters.AddWithValue("pCoutTotalSejour_Brou_K_G7", txtCoutTOtalSejourne.Text);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMVTHotel_Brou_D_G7_Load(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
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
                        cmd = new MySqlCommand("SPX_mvthotel_Brou_K_G7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La saisie a été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        cmd = new MySqlCommand("SPX_mvthotel_Brou_K_G7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La modification a été enregistrée", Application.ProductName);
                        break;
                    case 'S':
                        cmd = new MySqlCommand("SPX_mvthotel_Brou_K_G7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pmvtHotelID_Brou_K_G7", txtMouvHotelId.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La suppression a été effectuée", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                con.Close();
            }
        }
        private Image GetImageForNation(string nationId)
        {
            // Chemin du répertoire où se trouvent les images des nations
            string imagePath = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier NationParticip\";

            // Obtenez le nom de fichier correspondant à l'ID de la nation
            string imageName = nationId + ".jpg"; // Extension de fichier supposée être .jpg

            // Chemin complet du fichier image
            string imagePathWithName = Path.Combine(imagePath, imageName);

            // Vérifiez si le fichier image existe
            if (File.Exists(imagePathWithName))
            {
                try
                {
                    // Chargez l'image depuis le fichier et retournez-la
                    return Image.FromFile(imagePathWithName);
                }
                catch (Exception ex)
                {
                    // Gestion de l'erreur de chargement de l'image
                    Console.WriteLine("Erreur lors du chargement de l'image : " + ex.Message);
                    return null;
                }
            }
            else
            {
                // Si l'image n'est pas trouvée, retournez une image par défaut ou null
                return null;
            }
        }


        // Méthode pour accéder au nom de la nation sélectionnée depuis frmChoixNation
        private string GetNomForNation(string nationId)
        {
            frmChoixNation frmChoixNationInstance = new frmChoixNation();
            string nationName = frmChoixNationInstance.GetNationNameFromId(nationId);
            return nationName;
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtNatPartcipID.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel encadreur]";
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

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[5].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);



                    btnEnregistrer.Enabled = false;
                    btnEnregistrer.Text = "Enregistrer";
                }
                SqlConX.Close();
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

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[5].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);


                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Ok_Modifier";
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

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[5].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);


                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Supprimer";
                }
                SqlConX.Close();
            }
        }
        private void FrmSelecListNatEnc_NationSelected(string nationId, string nationNom, Image nationImage)
        {
            txtNatPartcipID.Text = nationId;
            label8.Text = nationNom;

        }

        private void btnOPtion_Click(object sender, EventArgs e)
        {
            frmChoixNation frm = new frmChoixNation();
            frm.NationSelected += FrmSelecListNatEnc_NationSelected;
            frm.ShowDialog();
        }
    }
}
