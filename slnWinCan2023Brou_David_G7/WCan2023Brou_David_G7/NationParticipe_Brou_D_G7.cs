using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brou_Davidspace;
using MySql.Data.MySqlClient;

namespace WCan2023Brou_David_G7
{
    public partial class NationParticipe_Brou_D_G7 : Form
    {
        char optionAppel = 'A';
        string DossierPhoto = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier NationParticip\";
        //déclaration d'un attribut de classe de type SqlConnection pour la connection à la BD
        MySqlConnection SqlConX = new MySqlConnection();
        public NationParticipe_Brou_D_G7()
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
                string vNatParticipID = "";
                string vNatNom = "";
                string vNatSurnom = "";
                string vNatEmail = "";
                string vNatPoule = "";
                string vNbreTitre = "";
                string vClassFIFA = "";

                if (!DBNull.Value.Equals(row["NatParticipID_Brou_K_G7"])) vNatParticipID = row["NatParticipID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatNom_Brou_K_G7"])) vNatNom = (string)row["NatNom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatSurnom_Brou_K_G7"])) vNatSurnom = (string)row["NatSurnom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatEmailFede_Brou_K_G7"])) vNatEmail = (string)row["NatEmailFede_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatPoule_Brou_K_G7"])) vNatPoule = (string)row["NatPoule_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatNbreTitre_Brou_K_G7"])) vNbreTitre = row["NatNbreTitre_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatClassmtFifa_Brou_K_G7"])) vClassFIFA = row["NatClassmtFifa_Brou_K_G7"].ToString();

                ListViewItem itm = lviewRech.Items.Add(vNatParticipID);
                itm.SubItems.Add(vNatNom);
                itm.SubItems.Add(vNatSurnom);
                itm.SubItems.Add(vNatEmail);
                itm.SubItems.Add(vNatPoule);
                itm.SubItems.Add(vNbreTitre);
                itm.SubItems.Add(vClassFIFA);
                itm.Tag = vNatParticipID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Nation participante";
        }
        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_Nationparticip_brou_k_g7_SelectAll", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Ajout des paramètres
            MySqlParameter prm;
            prm = new MySqlParameter("pNatNom_Brou_K_G7", MySqlDbType.VarChar, 50);
            prm.Value = pUserNom;
            cmd.Parameters.Add(prm);
            //récupération des données
            DataTable dt;
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //Remplissage du datatable
            da.Fill(dt);
            //Fermer la connexion
            SqlConX.Close();
            return dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NationParticipe_Brou_D_G7_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtNatParticipId.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel encadreur]";
        }
        private void MiseABlanc()
        {
            txtNatParticipId.Text = "";
            txtNomNation.Text = "";
            txtNatSurnom.Text = "";
            txtEmail.Text = "";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            txtNombreTitre.Text = "";
            txtNatClassFifa.Text = "";
            picPhoto.Image = Image.FromFile(DossierPhoto + "DefaultPicture.jpg");
            btnEnregistrer.Text = "&Enregistrer";
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
                    ChargerPhoto(pEncadreurID);
                    btnEnregistrer.Enabled = false;
                    btnEnregistrer.Text = "Enregistrer";
                }
                SqlConX.Close();
            }
        }
        public IDataReader GetEncadreur(string pEncadreurID)
        {
            IDataReader? dr = null;
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_Nationparticip_brou_k_g7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("pNatParticipID_Brou_K_G7", MySqlDbType.VarChar);
            prm.Value = pEncadreurID;
            cmd.Parameters.Add(prm);

            dr = cmd.ExecuteReader();
            return dr;
        }
        private void ChargerEncadreur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["NatParticipID_Brou_K_G7"])))
            {
                txtNatParticipId.Text = pDreader["NatParticipID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["NatNom_Brou_K_G7"])))
            {
                txtNomNation.Text = (string)pDreader["NatNom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["NatSurnom_Brou_K_G7"])))
            {
                txtNatSurnom.Text = (string)pDreader["NatSurnom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["NatEmailFede_Brou_K_G7"])))
            {
                txtEmail.Text = (string)pDreader["NatEmailFede_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["NatPoule_Brou_K_G7"])))
            {
                comboBox1.Text = (string)pDreader["NatPoule_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["NatNbreTitre_Brou_K_G7"])))
            {
                txtNombreTitre.Text = pDreader["NatNbreTitre_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["NatClassmtFifa_Brou_K_G7"])))
            {
                txtNatClassFifa.Text = pDreader["NatClassmtFifa_Brou_K_G7"].ToString();
            }
            ChargerPhoto(txtNatParticipId.Text);
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
                    ChargerPhoto(pEncadreurID);
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
            if (!string.IsNullOrEmpty(txtNatParticipId.Text))
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
                        cmd = new MySqlCommand("SPX_Nationparticip_brou_k_g7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtNatParticipId.Text + ".jpg");
                        MessageBox.Show("La saisie a été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        cmd = new MySqlCommand("SPX_Nationparticip_brou_k_g7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtNatParticipId.Text + ".jpg");
                        MessageBox.Show("La modification a été enregistrée", Application.ProductName);
                        break;
                    case 'S':
                        cmd = new MySqlCommand("SPX_Nationparticip_brou_k_g7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pNatParticipID_Brou_K_G7", txtNatParticipId.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La suppression a été effectuée", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                con.Close();
            }
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtNatParticipId.Text))
            {
                MessageBox.Show("ID Nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNatParticipId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNomNation.Text))
            {
                MessageBox.Show("Nom de nation attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomNation.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNatSurnom.Text))
            {
                MessageBox.Show("Rôle d'Encardreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNatSurnom.Focus();
                return false;
            }
            return true;
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pNatParticipID_Brou_K_G7", txtNatParticipId.Text);
            pCmd.Parameters.AddWithValue("pNatNom_Brou_K_G7", txtNomNation.Text);
            pCmd.Parameters.AddWithValue("pNatSurnom_Brou_K_G7", txtNatSurnom.Text);
            pCmd.Parameters.AddWithValue("pNatEmailFede_Brou_K_G7", txtEmail.Text);
            pCmd.Parameters.AddWithValue("pNatPoule_Brou_K_G7", comboBox1.Text);
            pCmd.Parameters.AddWithValue("pNatNbreTitre_Brou_K_G7", txtNombreTitre.Text);
            pCmd.Parameters.AddWithValue("pNatClassmtFifa_Brou_K_G7", txtNatClassFifa.Text);

            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                byte[] imageBytes = File.ReadAllBytes(txtFileName.Text);
                pCmd.Parameters.AddWithValue("pNatPhotoDrapeau_Brou_K_G7", imageBytes);
            }
            else
            {
                // Si aucun fichier n'est sélectionné, vous pouvez passer une valeur par défaut
                // ou NULL à votre procédure stockée pour indiquer qu'aucune image n'est fournie.
                pCmd.Parameters.AddWithValue("pNatPhotoDrapeau_Brou_K_G7", DBNull.Value); // Ou une autre valeur par défaut pour votre cas
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

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string dossierInitial = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier NationParticip\";
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


        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
