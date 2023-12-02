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
    public partial class frmUtilisateurBrou_D_G7 : Form
    {
        char optionAppel = 'A';
        MySqlConnection SqlConX = new MySqlConnection();

        public frmUtilisateurBrou_D_G7()
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
                string vLogin = "";
                string vNomPrenom = "";
                string vEmail = "";
                string vRole = "";

                if (!DBNull.Value.Equals(row["obsLogin_Brou_K_G7"])) vLogin = (string)row["obsLogin_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["obsNomPrenom_Brou_K_G7"])) vNomPrenom = (string)row["obsNomPrenom_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["obsRole_Brou_K_G7"])) vRole = (string)row["obsRole_Brou_K_G7"];
                if (!DBNull.Value.Equals(row["obsEmail_Brou_K_G7"])) vEmail = (string)row["obsEmail_Brou_K_G7"];

                ListViewItem itm = lviewRech.Items.Add(vLogin);
                itm.SubItems.Add(vNomPrenom);
                itm.SubItems.Add(vRole);
                itm.SubItems.Add(vEmail);
                itm.Tag = vLogin;
            }
            lblNbre.Text = lviewRech.Items.Count.ToString() + " utilisateurs";
        }
        public DataTable SelectAll(string pUserNom)
        {
            string ConxStr = Divers.MySQLDBConX();
            using (MySqlConnection SqlConX = new MySqlConnection(ConxStr))
            {
                SqlConX.Open();
                MySqlCommand cmd = new MySqlCommand("SPX_Observateur_Brou_K_G7_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter prm;
                prm = new MySqlParameter("pobsNomPrenom_Brou_K_G7", MySqlDbType.VarChar, 50);
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
            // Your code for the group box entering
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUtilisateurBrou_D_G7_Load(object sender, EventArgs e)
        {
            // Your code for form load
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rafraichirList();
        }
        private Boolean OkSaisie()
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Login d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Nom d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbUserRole.Text))
            {
                MessageBox.Show("Rôle d'utilisateur attendu !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUserRole.Focus();
                return false;
            }
            return true;
        }
        private void MiseABlanc()
        {
            txtLogin.Text = "";
            txtMotdepasse.Text = "";
            txtNom.Text = "";
            cbUserRole.Text = "";
            cbUserRole.SelectedIndex = -1;
            txtEmail.Text = "";
        }
        private void AjoutParam(MySqlCommand pCmd)
        {
            pCmd.CommandType = CommandType.StoredProcedure;
            pCmd.Parameters.AddWithValue("pobsLogin_Brou_K_G7", txtLogin.Text);
            pCmd.Parameters.AddWithValue("pobsNomPrenom_Brou_K_G7", txtNom.Text);
            pCmd.Parameters.AddWithValue("pobsMotPass_Brou_K_G7", txtMotdepasse.Text);
            pCmd.Parameters.AddWithValue("pobsRole_Brou_K_G7", cbUserRole.Text + "");
            pCmd.Parameters.AddWithValue("pobsEmail_Brou_K_G7", txtEmail.Text);
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
                        cmd = new MySqlCommand("SPX_Observateur_Brou_K_G7_Insert", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la saisie à été ajoutée", Application.ProductName);
                        break;
                    case 'M':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_Observateur_Brou_K_G7_Update", con);
                        AjoutParam(cmd);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la modification a été enregistrée ", Application.ProductName);
                        break;
                    case 'S':
                        //Création de la commande sql
                        cmd = new MySqlCommand("SPX_Observateur_Brou_K_G7_Delete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("pobsLogin_Brou_K_G7", txtLogin.Text);
                        cmd.ExecuteScalar();
                        MessageBox.Show("la suppression a été effectuée ", Application.ProductName);
                        break;
                }
                MiseABlanc();
                rafraichirList();
                SqlConX.Close();
            }
        }
        private void ChargerUtilisateur(IDataReader pDreader)
        {
            if (!(DBNull.Value.Equals(pDreader["obsLogin_Brou_K_G7"])))
            {
                txtLogin.Text = (string)pDreader["obsLogin_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["obsMotPass_Brou_K_G7"])))
            {
                txtMotdepasse.Text = (string)pDreader["obsMotPass_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["obsNomPrenom_Brou_K_G7"])))
            {
                txtNom.Text = (string)pDreader["obsNomPrenom_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["obsRole_Brou_K_G7"])))
            {
                cbUserRole.Text = (string)pDreader["obsRole_Brou_K_G7"];
            }
            if (!(DBNull.Value.Equals(pDreader["obsEmail_Brou_K_G7"])))
            {
                txtEmail.Text = (string)pDreader["obsEmail_Brou_K_G7"];
            }
        }
        public IDataReader GetObject(string pLogin)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            string ConxStr = Divers.MySQLDBConX();
            MySqlConnection SqlConX = new MySqlConnection(ConxStr);
            SqlConX.Open();
            //Commande
            MySqlCommand cmd = new MySqlCommand("SPX_Observateur_Brou_K_G7_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            MySqlParameter prm;
            prm = new MySqlParameter("pobsLogin_Brou_K_G7", MySqlDbType.VarChar, 10);
            prm.Value = pLogin;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            optionAppel = 'A';
            MiseABlanc();
            txtLogin.Focus();
            btnEnregistrer.Text = "&Enregistrer";
            this.Text = Application.ProductName + "-[Insertion nouvel utilisateur]";
        }

        private void btnModifier_Click(object sender, EventArgs e)
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
                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Ok_Modifier";
                }
                SqlConX.Close();
            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
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
                    btnEnregistrer.Enabled = false;
                    btnEnregistrer.Text = "Enregistrer";
                }
                SqlConX.Close();
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
                    btnEnregistrer.Enabled = true;
                    btnEnregistrer.Text = "Supprimer";
                }
                SqlConX.Close();
            }
        }
    }
}
