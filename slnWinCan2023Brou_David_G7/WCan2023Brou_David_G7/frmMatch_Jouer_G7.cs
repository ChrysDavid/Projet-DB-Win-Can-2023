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
    public partial class frmMatch_Jouer_G7 : Form
    {

        char optionAppel = 'A';
        string DossierPhoto1 = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier NationParticip\";
        string DossierPhoto2 = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier NationParticip\";

        MySqlConnection SqlConX = new MySqlConnection();
        public frmMatch_Jouer_G7()
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
                string vClub = "";
                string vPasseport = "";
                string vNation_ID1 = "";
                string vNation_ID2 = "";

                if (!DBNull.Value.Equals(row["matchNumID_brou_d_g7"])) vJoueur_ID = (string)row["matchNumID_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchDate_brou_d_g7"])) vNom = row["matchDate_brou_d_g7"].ToString();
                if (!DBNull.Value.Equals(row["matchPhase_brou_d_g7"])) vPrenom = (string)row["matchPhase_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchLieuStade_brou_d_g7"])) vDate_Naiss = (string)row["matchLieuStade_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchArbitre_brou_d_g7"])) vLieu_Naiss = (string)row["matchArbitre_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchButeursVis_brou_d_g7"])) vPoste = (string)row["matchButeursVis_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchButeursRec_brou_d_g7"])) vClub = (string)row["matchButeursRec_brou_d_g7"];
                if (!DBNull.Value.Equals(row["matchObservation_brou_d_g7"])) vPasseport = (string)row["matchObservation_brou_d_g7"];
                if (!DBNull.Value.Equals(row["NatParticipID1_brou_d_g7"])) vNation_ID1 = row["NatParticipID1_brou_d_g7"].ToString();
                if (!DBNull.Value.Equals(row["NatParticipID2_brou_d_g7"])) vNation_ID2 = row["NatParticipID2_brou_d_g7"].ToString();

                ListViewItem itm = lviewRech.Items.Add(vJoueur_ID);
                itm.SubItems.Add(vNom);
                itm.SubItems.Add(vPrenom);
                itm.SubItems.Add(vDate_Naiss);
                itm.SubItems.Add(vLieu_Naiss);
                itm.SubItems.Add(vPoste);
                itm.SubItems.Add(vClub);
                itm.SubItems.Add(vPasseport);
                itm.SubItems.Add(vNation_ID1);
                itm.SubItems.Add(vNation_ID2);
                itm.Tag = vJoueur_ID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Match jouer";
        }
        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            using (MySqlConnection SqlConX = new MySqlConnection(ConxStr))
            {
                SqlConX.Open();
                MySqlCommand cmd = new MySqlCommand("SPX_matchjouer_brou_d_g7_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter prm;
                prm = new MySqlParameter("pmatchLieuStade_brou_d_g7", MySqlDbType.VarChar, 50);
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
        private void frmMatch_Jouer_G7_Load(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ChargerPhoto(string pRefPhoto)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ajustez selon vos besoins
            pictureBox1.BackColor = Color.White;

            if (File.Exists(DossierPhoto1 + pRefPhoto + ".jpg"))
            {
                Image img = Image.FromFile(DossierPhoto1 + pRefPhoto + ".jpg");
                pictureBox1.Image = img;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(DossierPhoto1 + "DefaultPicture.jpg");
            }
        }

        private void ChargerPhoto2(string pRefPhoto)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // Ajustez selon vos besoins
            pictureBox2.BackColor = Color.White;

            if (File.Exists(DossierPhoto2 + pRefPhoto + ".jpg"))
            {
                Image img = Image.FromFile(DossierPhoto2 + pRefPhoto + ".jpg");
                pictureBox2.Image = img;
            }
            else
            {
                pictureBox2.Image = Image.FromFile(DossierPhoto2 + "DefaultPicture.jpg");
            }
        }


        private void MiseABlanc()
        {
            txtNatPartic1.Text = "";
            txtNatPartic2.Text = "";
            txtMatchID.Text = "";
            dateTimePicker1.Text = "";
            txtPhaseMatch.Text = "";
            txtLieuMatch.Text = "";
            txtNomArbitre.Text = "";
            txtButVisiteur.Text = "";
            txtButReceveur.Text = "";
            txtObservation.Text = "";
            pictureBox1.Image = Image.FromFile(DossierPhoto1 + "DefaultPicture.jpg");
            pictureBox2.Image = Image.FromFile(DossierPhoto2 + "DefaultPicture.jpg");
            btnEnregistrer.Text = "&Enregistrer";
            label12.Text = "Nom Nation 1";
            label11.Text = "Nom Nation 2";
        }




        private void btnAjouter_Click(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtNatPartic1.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel de Match]";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Modification de Match]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'M';
                string pLogin = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetObject(pLogin); ;
                if (dreader.Read())
                {
                    ChargerUtilisateur(dreader);
                    ChargerPhoto(pLogin);
                    ChargerPhoto2(pLogin); // Chargez également l'image pour pictureBox2

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[8].Text;
                    string nationId2 = lviewRech.SelectedItems[0].SubItems[9].Text;

                    string nationNom1 = GetNomForNation(nationId1);
                    string nationNom2 = GetNomForNation(nationId2);

                    Image nationImage1 = GetImageForNation(nationId1);
                    Image nationImage2 = GetImageForNation(nationId2);

                    Frm_NationSelected(nationId1, nationNom1, nationImage1);
                    Frm_NationSelected2(nationId2, nationNom2, nationImage2);

                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Ok_Modifier";
                }
                SqlConX.Close();
            }
        }

        private void ChargerUtilisateur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["NatParticipID1_brou_d_g7"])))
            {
                txtNatPartic1.Text = pDreader["NatParticipID1_brou_d_g7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["NatParticipID2_brou_d_g7"])))
            {
                txtNatPartic2.Text = pDreader["NatParticipID2_brou_d_g7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["matchNumID_brou_d_g7"])))
            {
                txtMatchID.Text = pDreader["matchNumID_brou_d_g7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["matchDate_brou_d_g7"])))
            {
                dateTimePicker1.Text = pDreader["matchDate_brou_d_g7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["matchPhase_brou_d_g7"])))
            {
                txtPhaseMatch.Text = (string)pDreader["matchPhase_brou_d_g7"];
            }
            if (!(DBNull.Value.Equals(pDreader["matchLieuStade_brou_d_g7"])))
            {
                txtLieuMatch.Text = (string)pDreader["matchLieuStade_brou_d_g7"];
            }
            if (!(DBNull.Value.Equals(pDreader["matchArbitre_brou_d_g7"])))
            {
                txtNomArbitre.Text = (string)pDreader["matchArbitre_brou_d_g7"];
            }
            if (!(DBNull.Value.Equals(pDreader["matchButeursVis_brou_d_g7"])))
            {
                txtButVisiteur.Text = (string)pDreader["matchButeursVis_brou_d_g7"];
            }
            if (!(DBNull.Value.Equals(pDreader["matchButeursRec_brou_d_g7"])))
            {
                txtButReceveur.Text = (string)pDreader["matchButeursRec_brou_d_g7"];
            }
            if (!(DBNull.Value.Equals(pDreader["matchObservation_brou_d_g7"])))
            {
                txtObservation.Text = (string)pDreader["matchObservation_brou_d_g7"];
            }
            ChargerPhoto(txtMatchID.Text);
        }
        public IDataReader GetObject(string pLogin)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            //Commande
            MySqlCommand cmd = new MySqlCommand("SPX_matchjouer_brou_d_g7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            MySqlParameter prm;
            prm = new MySqlParameter("pmatchNumID_brou_d_g7", MySqlDbType.VarChar, 10);
            prm.Value = pLogin;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtNatPartic1.Text))
            {
                MessageBox.Show("Login d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNatPartic1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNatPartic2.Text))
            {
                MessageBox.Show("Nom d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNatPartic2.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatchID.Text))
            {
                MessageBox.Show("Rôle d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatchID.Focus();
                return false;
            }
            return true;
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




        private void btnConsulter_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Consultation d'utilisateur]";
            MiseABlanc();

            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'C';
                string pLogin = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetObject(pLogin);

                if (dreader.Read())
                {
                    ChargerUtilisateur(dreader);
                    ChargerPhoto(pLogin);
                    ChargerPhoto2(pLogin); // Chargez également l'image pour pictureBox2

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[8].Text;
                    string nationId2 = lviewRech.SelectedItems[0].SubItems[9].Text;

                    string nationNom1 = GetNomForNation(nationId1);
                    string nationNom2 = GetNomForNation(nationId2);

                    Image nationImage1 = GetImageForNation(nationId1);
                    Image nationImage2 = GetImageForNation(nationId2);

                    Frm_NationSelected(nationId1, nationNom1, nationImage1);
                    Frm_NationSelected2(nationId2, nationNom2, nationImage2);

                    SqlConX.Close();
                }
            }
        }




        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Suppression d'utilisateur]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'S';

                string pLogin = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetObject(pLogin); ;
                if (dreader.Read())
                {
                    ChargerUtilisateur(dreader);
                    ChargerPhoto(pLogin);
                    ChargerPhoto2(pLogin); // Chargez également l'image pour pictureBox2

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[8].Text;
                    string nationId2 = lviewRech.SelectedItems[0].SubItems[9].Text;

                    string nationNom1 = GetNomForNation(nationId1);
                    string nationNom2 = GetNomForNation(nationId2);

                    Image nationImage1 = GetImageForNation(nationId1);
                    Image nationImage2 = GetImageForNation(nationId2);

                    Frm_NationSelected(nationId1, nationNom1, nationImage1);
                    Frm_NationSelected2(nationId2, nationNom2, nationImage2);

                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Supprimer";
                }
                SqlConX.Close();
            }
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pNatParticipID1_brou_d_g7", txtNatPartic1.Text + "");
            pCmd.Parameters.AddWithValue("pNatParticipID2_brou_d_g7", txtNatPartic2.Text + "");
            pCmd.Parameters.AddWithValue("pmatchNumID_brou_d_g7", txtMatchID.Text + "");
            pCmd.Parameters.AddWithValue("pmatchDate_brou_d_g7", dateTimePicker1.Text + "");
            pCmd.Parameters.AddWithValue("pmatchPhase_brou_d_g7", txtPhaseMatch.Text + "");
            pCmd.Parameters.AddWithValue("pmatchLieuStade_brou_d_g7", txtLieuMatch.Text + "");
            pCmd.Parameters.AddWithValue("pmatchArbitre_brou_d_g7", txtNomArbitre.Text + "");
            pCmd.Parameters.AddWithValue("pmatchButeursVis_brou_d_g7", txtButVisiteur.Text + "");
            pCmd.Parameters.AddWithValue("pmatchButeursRec_brou_d_g7", txtButReceveur.Text + "");
            pCmd.Parameters.AddWithValue("pmatchObservation_brou_d_g7", txtObservation.Text + "");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                //définition de la chaine de connection
                string constr = Divers.MySQLDBConX();
                //connexion à la base de données
                MySqlConnection con = new MySqlConnection(constr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                switch (optionAppel)
                {
                    case 'A':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_matchjouer_brou_d_g7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la saisie à été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_matchjouer_brou_d_g7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la modification a été enregistrée", Application.ProductName);
                        break;
                    case 'S':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_matchjouer_brou_d_g7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pmatchNumID_brou_d_g7", txtMatchID.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la suppression a été effectuée ", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                SqlConX.Close();
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void txtNatPartic1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmChoixNation frm = new frmChoixNation();
            frm.NationSelected += Frm_NationSelected;
            frm.ShowDialog();
        }


        private void Frm_NationSelected(string nationId, string nationNom, Image nationImage)
        {
            txtNatPartic1.Text = nationId;
            pictureBox1.Image = nationImage;
            label11.Text = nationNom;
            ChargerPhoto(nationId); // Chargez l'image de la nation dans pictureBox2
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frmChoixNation frm = new frmChoixNation();
            frm.NationSelected += Frm_NationSelected2;
            frm.ShowDialog();
        }

        private void Frm_NationSelected2(string nationId, string nationNom, Image nationImage)
        {
            txtNatPartic2.Text = nationId;
            pictureBox2.Image = nationImage;

            label12.Text = nationNom;
            ChargerPhoto2(nationId); // Chargez l'image de la nation dans pictureBox2
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
