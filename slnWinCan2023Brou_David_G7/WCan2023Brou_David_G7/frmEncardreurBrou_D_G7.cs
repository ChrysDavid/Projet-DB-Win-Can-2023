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
using System.IO;

namespace WCan2023Brou_David_G7
{
    public partial class frmEncardreurBrou_D_G7 : Form
    {
        char optionAppel = 'A';
        string DossierPhoto = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier encadreur\";
        MySqlConnection SqlConX = new MySqlConnection();
        public frmEncardreurBrou_D_G7()
        {
            InitializeComponent();
            rafraichirList();
        }
        private void rafraichirList()
        {
            lviewRech.Items.Clear();
            DataTable dt = SelectAll(txtRecherche.Text); // Vous devez implémenter la méthode SelectAll selon votre logique.

            foreach (DataRow row in dt.Rows)
            {
                string vEncadreurID = "";
                string vEncNomPrenom = "";
                string vEncRolePoste = "";
                string vEncContactTel = "";
                string vEncEmail = "";
                string vNatParticipID = "";

                if (!DBNull.Value.Equals(row["EncadreurID_Brou_K_G7"])) vEncadreurID = row["EncadreurID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["EncNomPrenom_Brou_K_G7"])) vEncNomPrenom = (string)row["EncNomPrenom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["EncRolePoste_Brou_K_G7"])) vEncRolePoste = (string)row["EncRolePoste_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["EncContactTel_Brou_K_G7"])) vEncContactTel = (string)row["EncContactTel_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["EncEmail_Brou_K_G7"])) vEncEmail = (string)row["EncEmail_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatParticipID_Brou_K_G7"])) vNatParticipID = row["NatParticipID_Brou_K_G7"].ToString();

                ListViewItem itm = lviewRech.Items.Add(vEncadreurID);
                itm.SubItems.Add(vEncNomPrenom);
                itm.SubItems.Add(vEncRolePoste);
                itm.SubItems.Add(vEncContactTel);
                itm.SubItems.Add(vEncEmail);
                itm.SubItems.Add(vNatParticipID);
                itm.Tag = vEncadreurID;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " Encadreur";
        }


        public DataTable SelectAll(string pEncNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_Encadreur_brou_k_g7_SelectAll", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Ajout des paramètres
            MySqlParameter prm;
            prm = new MySqlParameter("pEncNomPrenom_Brou_K_G7", MySqlDbType.VarChar, 50);
            prm.Value = pEncNom;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEncardreurBrou_D_G7_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtEncadreurID.Text))
            {
                MessageBox.Show("ID Encadreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEncadreurID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Nom d'Encadreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbUserRole.Text))
            {
                MessageBox.Show("Rôle d'Encardreur attendu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUserRole.Focus();
                return false;
            }
            return true;
        }

        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pEncadreurID_Brou_K_G7", txtEncadreurID.Text);
            pCmd.Parameters.AddWithValue("pEncNomPrenom_Brou_K_G7", txtNom.Text);
            pCmd.Parameters.AddWithValue("pEncEmail_Brou_K_G7", txtEmail.Text);
            pCmd.Parameters.AddWithValue("pEncContactTel_Brou_K_G7", txtTelephone.Text);
            pCmd.Parameters.AddWithValue("pEncRolePoste_Brou_K_G7", cbUserRole.Text);
            pCmd.Parameters.AddWithValue("pNatParticipID_Brou_K_G7", txtNatParticipID.Text);
            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                byte[] imageBytes = File.ReadAllBytes(txtFileName.Text);
                pCmd.Parameters.AddWithValue("pencPhoto_Brou_K_G7", imageBytes);
            }
            else
            {
                // Si aucun fichier n'est sélectionné, vous pouvez passer une valeur par défaut
                // ou NULL à votre procédure stockée pour indiquer qu'aucune image n'est fournie.
                pCmd.Parameters.AddWithValue("pencPhoto_Brou_K_G7", DBNull.Value); // Ou une autre valeur par défaut pour votre cas
            }
        }

        private void MiseABlanc()
        {
            txtEncadreurID.Text = "";
            txtNom.Text = "";
            cbUserRole.Text = "";
            cbUserRole.SelectedIndex = -1;
            txtTelephone.Text = "";
            txtEmail.Text = "";
            txtNatParticipID.Text = "";
            picPhoto.Image = Image.FromFile(DossierPhoto + "DefaultPicture.jpg");
            btnEnregistrer.Text = "&Enregistrer";
            label7.Text = "Nom Nation";
            label7.Text = "Nom Nation";
        }

        private void button2_Click(object sender, EventArgs e)
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
                        cmd = new MySqlCommand("SPX_Encadreur_brou_k_g7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtEncadreurID.Text + ".jpg");
                        MessageBox.Show("La saisie a été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        cmd = new MySqlCommand("SPX_Encadreur_brou_k_g7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        EnregistrerPhoto(DossierPhoto + txtEncadreurID.Text + ".jpg");
                        MessageBox.Show("La modification a été enregistrée", Application.ProductName);
                        break;
                    case 'S':
                        cmd = new MySqlCommand("SPX_Encadreur_brou_k_g7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pEncadreurID_Brou_K_G7", txtEncadreurID.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("La suppression a été effectuée", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtNatParticipID.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel encadreur]";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEncardreurBrou_D_G7_Load_1(object sender, EventArgs e)
        {

        }

        public IDataReader GetEncadreur(string pEncadreurID)
        {
            IDataReader? dr = null;
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            MySqlCommand cmd = new MySqlCommand("SPX_Encadreur_brou_k_g7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("pEncadreurID_Brou_K_G7", MySqlDbType.VarChar);
            prm.Value = pEncadreurID;
            cmd.Parameters.Add(prm);

            dr = cmd.ExecuteReader();
            return dr;
        }

        private Image GetImageForNation(string nationId)
        {
            // Chemin du répertoire où se trouvent les images des nations
            string imagePath = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier encadreur\";

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
                    ChargerPhoto(pEncadreurID);
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

        private void ChargerEncadreur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["EncadreurID_Brou_K_G7"])))
            {
                txtEncadreurID.Text = pDreader["EncadreurID_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["EncNomPrenom_Brou_K_G7"])))
            {
                txtNom.Text = (string)pDreader["EncNomPrenom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["EncRolePoste_Brou_K_G7"])))
            {
                cbUserRole.Text = (string)pDreader["EncRolePoste_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["EncContactTel_Brou_K_G7"])))
            {
                txtTelephone.Text = pDreader["EncContactTel_Brou_K_G7"].ToString();
            }
            if (!(DBNull.Value.Equals(pDreader["EncEmail_Brou_K_G7"])))
            {
                txtEmail.Text = (string)pDreader["EncEmail_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["NatParticipID_Brou_K_G7"])))
            {
                txtNatParticipID.Text = pDreader["NatParticipID_Brou_K_G7"].ToString();
            }
            ChargerPhoto(txtEncadreurID.Text);
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

        private void EnregistrerPhoto(string pCheminPhoto)
        {
            if (!string.IsNullOrEmpty(txtEncadreurID.Text))
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
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "-[Suppression d'encadreur]";
            MiseABlanc();
            if (lviewRech.SelectedItems.Count > 0)
            {
                optionAppel = 'S';

                string pEncadreurID = (string)lviewRech.SelectedItems[0].Tag;
                IDataReader dreader = GetEncadreur(pEncadreurID);
                if (dreader.Read())
                {
                    ChargerEncadreur(dreader);

                    ChargerPhoto(pEncadreurID);
                   


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

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string dossierInitial = @"C:\Users\Chris David BROU\OneDrive\Images\Saved Pictures\Dossier encadreur";
            openFileDialog1.InitialDirectory = dossierInitial;
            openFileDialog1.Filter = "Fichiers image (*.jpg)|*.jpg|Tous les fichiers (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // Test result.
            {
                txtFileName.Text = openFileDialog1.FileName;
                picPhoto.Image = Image.FromFile(txtFileName.Text);
                if (!string.IsNullOrEmpty(txtEncadreurID.Text))
                {
                    picPhoto.Image.Save(dossierInitial + txtEncadreurID.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                //FileStream oImg = new FileStream(@"" + txtFileName.Text, FileMode.Open, FileAccess.Read);
                //BinaryReader oBinaryReader = new BinaryReader(oImg);
                //Byte[] oImgByteArray = oBinaryReader.ReadBytes((int)oImg.Length);
                //Divers.laPhoto = oImgByteArray;
                //CurrentObj.PhotoUpdate(txtNumId.Text, oImgByteArray);
                //oBinaryReader.Close();
                //oImg.Close();
            }
            openFileDialog1.Dispose();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }
        private void FrmSelecListNatEnc_NationSelected(string nationId, string nationNom, Image nationImage)
        {
            txtNatParticipID.Text = nationId;
            label7.Text = nationNom;
            ChargerPhoto(nationId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChoixNation frm = new frmChoixNation();
            frm.NationSelected += FrmSelecListNatEnc_NationSelected;
            frm.ShowDialog();
        }
    }
}
