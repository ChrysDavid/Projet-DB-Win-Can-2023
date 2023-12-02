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
    public partial class frmChoixNation : Form
    {

        public event Action<string, string, Image> NationSelected;

        public frmChoixNation()
        {
            InitializeComponent();
            rafraichirList();
            lviewRech.MouseDoubleClick += lviewRech_MouseDoubleClick;
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
                Image vNatPhoto = null; // Image de la nation

                if (!DBNull.Value.Equals(row["NatParticipID_Brou_K_G7"])) vNatParticipID = row["NatParticipID_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatNom_Brou_K_G7"])) vNatNom = (string)row["NatNom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatSurnom_Brou_K_G7"])) vNatSurnom = (string)row["NatSurnom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatEmailFede_Brou_K_G7"])) vNatEmail = (string)row["NatEmailFede_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatPoule_Brou_K_G7"])) vNatPoule = (string)row["NatPoule_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["NatNbreTitre_Brou_K_G7"])) vNbreTitre = row["NatNbreTitre_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatClassmtFifa_Brou_K_G7"])) vClassFIFA = row["NatClassmtFifa_Brou_K_G7"].ToString();
                if (!DBNull.Value.Equals(row["NatPhotoDrapeau_Brou_K_G7"]))
                {
                    byte[] imgData = (byte[])row["NatPhotoDrapeau_Brou_K_G7"];
                    vNatPhoto = byteArrayToImage(imgData);
                }


                ListViewItem itm = lviewRech.Items.Add(vNatParticipID);
                itm.SubItems.Add(vNatNom);
                itm.SubItems.Add(vNatSurnom);
                itm.SubItems.Add(vNatEmail);
                itm.SubItems.Add(vNatPoule);
                itm.SubItems.Add(vNbreTitre);
                itm.SubItems.Add(vClassFIFA);
                if (vNatPhoto != null)
                {
                    // Redimensionner l'image pour l'afficher dans la ListView
                    imageList1.Images.Add(vNatParticipID, ResizeImage(vNatPhoto, 64, 64));
                    itm.ImageKey = vNatParticipID;
                }
                
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
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    // Assurez-vous que l'image est valide et non corrompue avant de la retourner
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            catch (Exception ex)
            {
                // Gérez l'exception (par exemple, loggez-la ou affichez un message d'erreur)
                Console.WriteLine("Erreur lors de la conversion de bytes en image : " + ex.Message);
                return null; // Ou renvoyez une image par défaut
            }
        }

        private void lviewRech_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément sur lequel l'utilisateur a double-cliqué
            ListViewItem selectedItem = lviewRech.HitTest(e.Location).Item;

            if (selectedItem != null)
            {
                string nationId = selectedItem.Text;
                string nationNom = selectedItem.SubItems[1].Text;
                // selectedNationName = nationNom;
                Image nationImage = imageList1.Images[nationId]; // Récupérer l'image à partir de la ImageList

                NationSelected?.Invoke(nationId, nationNom, nationImage);
                // Fermer le formulaire après avoir déclenché l'événement
                this.Close();
            }
        }

        private void frmChoixNation_Load(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmMatch_Jouer_G7 frm = new frmMatch_Jouer_G7();
            frm.ShowDialog();
        }

        private void Modifier_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmMatch_Jouer_G7 frm = new frmMatch_Jouer_G7();
            frm.ShowDialog();
        }
        public string GetNationNameFromId(string nationId)
        {
            foreach (ListViewItem item in lviewRech.Items)
            {
                if (item.SubItems[0].Text == nationId) // Vérifiez si l'ID correspond
                {
                    return item.SubItems[1].Text; // Renvoie le nom de la nation (supposons que le nom se trouve dans la deuxième colonne)
                }
            }
            return ""; // Retourne une chaîne vide si aucune correspondance n'est trouvée
        }

    }
}
