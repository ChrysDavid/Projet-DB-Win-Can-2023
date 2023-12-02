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
    public partial class frmJoueursBrou_D_G7 : Form
    {
        char optionAppel = 'A';
        string DossierPhoto = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier Joueurs\";
        MySqlConnection SqlConX = new MySqlConnection();
        public frmJoueursBrou_D_G7()
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
                string vPasseport2 = "";
                string vNation_ID = "";

                if (!DBNull.Value.Equals(row["JoueurID_Brou_K_G7"])) vJoueur_ID = row["JoueurID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouNom_Brou_K_G7"])) vNom = row["JouNom_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouPrenom_Brou_K_G7"])) vPrenom = row["JouPrenom_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouEmail_Brou_K_G7"])) vDate_Naiss = row["JouEmail_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouTel_Brou_K_G7"])) vLieu_Naiss = row["JouTel_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouDateNaiss_Brou_K_G7"])) vPoste = row["JouDateNaiss_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouLieuNaiss_Brou_K_G7"])) vClub = row["JouLieuNaiss_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouPoste_Brou_K_G7"])) vPasseport = row["JouPoste_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["JouClubActuel_Brou_K_G7"])) vPasseport2 = row["JouClubActuel_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatParticipID_Brou_K_G7"])) vNation_ID = row["NatParticipID_Brou_K_G7"].ToString();

                ListViewItem itm = lviewRech.Items.Add(vJoueur_ID);
                itm.SubItems.Add(vNom);
                itm.SubItems.Add(vPrenom);
                itm.SubItems.Add(vDate_Naiss);
                itm.SubItems.Add(vLieu_Naiss);
                itm.SubItems.Add(vPoste);
                itm.SubItems.Add(vClub);
                itm.SubItems.Add(vPasseport);
                itm.SubItems.Add(vPasseport2);
                itm.SubItems.Add(vNation_ID);
                itm.Tag = vJoueur_ID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Joueurs";
        }
        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            using (MySqlConnection SqlConX = new MySqlConnection(ConxStr))
            {
                SqlConX.Open();
                MySqlCommand cmd = new MySqlCommand("SPX_joueurcaf_Brou_K_G7_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter prm;
                prm = new MySqlParameter("pJouNom_Brou_K_G7", MySqlDbType.VarChar, 50);
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmJoueursBrou_D_G7_Load(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtJoueurID.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel utilisateur]";
        }
        private void MiseABlanc()
        {
            txtJoueurID.Text = "";
            txtNation.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtPost.Text = "";
            txtPost.SelectedIndex = -1;
            txtEmail.Text = "";
            txtContact.Text = "";
            txtClub.Text = "";
            txtLieuNaiss.Text = "";
            txtDateNaiss.Text = "";
            label7.Text = "Nom de Nation";
            picPhoto.Image = Image.FromFile(DossierPhoto + "DefaultPicture.jpg");
            btnEnregistrer.Text = "&Enregistrer";
        }

        private Image GetImageForNation(string nationId)
        {
            // Chemin du répertoire où se trouvent les images des nations
            string imagePath = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier Joueurs\";

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


        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Modification d'utilisateur]";
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

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[9].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);


                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Ok_Modifier";
                }
                SqlConX.Close();
            }
        }

        private void ChargerPhoto(string pRefPhoto)
        {
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoto.BackColor = Color.White;

            if (File.Exists(DossierPhoto + pRefPhoto + ".jpg"))
            {
                picPhoto.Image = Image.FromFile(DossierPhoto + pRefPhoto + ".jpg");
            }
            else picPhoto.Image = Image.FromFile(DossierPhoto + "DefaultPicture.jpg");
        }
        private void EnregistrerPhoto(string pCheminPhoto)
        {
            if (!string.IsNullOrEmpty(txtJoueurID.Text))
            {
                // Vérifier s'il y a déjà une image enregistrée
                if (File.Exists(pCheminPhoto))
                {
                    try
                    {
                        // Supprimer l'image existante
                        File.Delete(pCheminPhoto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression de l'image existante : " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Enregistrer la nouvelle image
                try
                {
                    picPhoto.Image.Save(pCheminPhoto, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'enregistrement de la nouvelle image : " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Nation manquant.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ChargerUtilisateur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["NatParticipID_Brou_K_G7"])))
            {
                txtNation.Text = pDreader["NatParticipID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["JoueurID_Brou_K_G7"])))
            {
                txtJoueurID.Text = pDreader["JoueurID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["JouNom_Brou_K_G7"])))
            {
                txtNom.Text = (string)pDreader["JouNom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["JouPrenom_Brou_K_G7"])))
            {
                txtPrenom.Text = (string)pDreader["JouPrenom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["JouTel_Brou_K_G7"])))
            {
                txtContact.Text = (string)pDreader["JouTel_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["JouEmail_Brou_K_G7"])))
            {
                txtEmail.Text = (string)pDreader["JouEmail_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["JouPoste_Brou_K_G7"])))
            {
                txtPost.Text = pDreader["JouPoste_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["JouDateNaiss_Brou_K_G7"])))
            {
                // Assurez-vous que la colonne JouDateNaiss_Brou_K_G7 dans la base de données est de type DATE ou DATETIME
                DateTime dateNaissance;
                if (DateTime.TryParse(pDreader["JouDateNaiss_Brou_K_G7"].ToString(), out dateNaissance))
                {
                    txtDateNaiss.Text = dateNaissance.ToString("yyyy-MM-dd");
                }
                else
                {
                    // Gérer le cas où la valeur de date n'est pas valide
                    // Peut-être afficher un message d'erreur ou attribuer une valeur par défaut
                }
            }
            if (!(DBNull.Value.Equals(pDreader["JouLieuNaiss_Brou_K_G7"])))
            {
                txtLieuNaiss.Text = (string)pDreader["JouLieuNaiss_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["JouClubActuel_Brou_K_G7"])))
            {
                txtClub.Text = (string)pDreader["JouClubActuel_Brou_K_G7"];
            }
            ChargerPhoto(txtJoueurID.Text);
        }
        public IDataReader GetObject(string pLogin)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            //Commande
            MySqlCommand cmd = new MySqlCommand("SPX_joueurcaf_Brou_K_G7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            MySqlParameter prm;
            prm = new MySqlParameter("pJoueurID_Brou_K_G7", MySqlDbType.VarChar, 10);
            prm.Value = pLogin;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        private void btnConsulter_Click_1(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Consultation d'utilisateur]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'C';
                string pLogin = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetObject(pLogin); ;
                if (dreader.Read())
                {
                    ChargerUtilisateur(dreader);
                    ChargerPhoto(pLogin);

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[9].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);


                    btnEnregistrer.Enabled = false;
                    btnEnregistrer.Text = "Enregistrer";
                }
                SqlConX.Close();
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
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

                    string nationId1 = lviewRech.SelectedItems[0].SubItems[9].Text;
                    string nationNom1 = GetNomForNation(nationId1);

                    Image nationImage1 = GetImageForNation(nationId1);
                    FrmSelecListNatEnc_NationSelected(nationId1, nationNom1, nationImage1);


                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Supprimer";
                }
                SqlConX.Close();
            }
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
                        cmd = new MySqlCommand("SPX_joueurcaf_Brou_K_G7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtJoueurID.Text + ".jpg");
                        MessageBox.Show("la saisie à été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_joueurcaf_Brou_K_G7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtJoueurID.Text + ".jpg");
                        MessageBox.Show("la modification a été enregistrée ", Application.ProductName);
                        break;
                    case 'S':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_joueurcaf_Brou_K_G7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pJoueurID_Brou_K_G7", txtJoueurID.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la suppression a été effectuée ", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                SqlConX.Close();
            }
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtNation.Text))
            {
                MessageBox.Show("Login d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNation.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtJoueurID.Text))
            {
                MessageBox.Show("Nom d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJoueurID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Rôle d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return false;
            }
            return true;
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pNatParticipID_Brou_K_G7", txtNation.Text);
            pCmd.Parameters.AddWithValue("pJoueurID_Brou_K_G7", txtJoueurID.Text);
            pCmd.Parameters.AddWithValue("pJouNom_Brou_K_G7", txtNom.Text);
            pCmd.Parameters.AddWithValue("pJouPrenom_Brou_K_G7", txtPrenom.Text + "");
            pCmd.Parameters.AddWithValue("pJouDateNaiss_Brou_K_G7", txtDateNaiss.Text);
            pCmd.Parameters.AddWithValue("pJouLieuNaiss_Brou_K_G7", txtPost.Text);
            pCmd.Parameters.AddWithValue("pJouClubActuel_Brou_K_G7", txtClub.Text);
            pCmd.Parameters.AddWithValue("pJouPoste_Brou_K_G7", txtLieuNaiss.Text);
            pCmd.Parameters.AddWithValue("pJouTel_Brou_K_G7", txtContact.Text);
            pCmd.Parameters.AddWithValue("pJouEmail_Brou_K_G7", txtEmail.Text);
            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                byte[] imageBytes = File.ReadAllBytes(txtFileName.Text);
                pCmd.Parameters.AddWithValue("pjouPhoto_Brou_K_G7", imageBytes);
            }
            else
            {
                // Si aucun fichier n'est sélectionné, vous pouvez passer une valeur par défaut
                // ou NULL à votre procédure stockée pour indiquer qu'aucune image n'est fournie.
                pCmd.Parameters.AddWithValue("pjouPhoto_Brou_K_G7", DBNull.Value); // Ou une autre valeur par défaut pour votre cas
            }
        }

        private void FrmSelecListNatEnc_NationSelected(string nationId, string nationNom, Image nationImage)
        {
            txtNation.Text = nationId;
            label7.Text = nationNom;

        }

        private void btnOPtion_Click(object sender, EventArgs e)
        {
            frmChoixNation frm = new frmChoixNation();
            frm.NationSelected += FrmSelecListNatEnc_NationSelected;
            frm.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string dossierInitial = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier Joueurs\";
            openFileDialog1.InitialDirectory = dossierInitial;
            openFileDialog1.Filter = "Fichiers image (*.jpg)|*.jpg|Tous les fichiers (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;

                // Charger l'image à partir du fichier
                using (FileStream stream = new FileStream(txtFileName.Text, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        // Créer une instance de l'image à partir du flux
                        Image originalImage = Image.FromStream(stream);

                        // Redimensionner l'image à une taille raisonnable (par exemple, 300x300 pixels)
                        int maxWidth = 300;
                        int maxHeight = 300;
                        Image resizedImage = ResizeImage(originalImage, maxWidth, maxHeight);

                        // Afficher l'image redimensionnée dans le PictureBox
                        picPhoto.Image = resizedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            openFileDialog1.Dispose();
        }

        // Méthode pour redimensionner l'image
        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNation_Click(object sender, EventArgs e)
        {
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
        }
    }
}