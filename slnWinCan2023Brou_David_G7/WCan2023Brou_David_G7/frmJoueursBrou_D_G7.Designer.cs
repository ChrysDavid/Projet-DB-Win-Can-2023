namespace WCan2023Brou_David_G7
{
    partial class frmJoueursBrou_D_G7
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJoueursBrou_D_G7));
            groupBox1 = new GroupBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            label14 = new Label();
            label13 = new Label();
            txtLieuNaiss = new TextBox();
            txtDateNaiss = new DateTimePicker();
            txtPost = new ComboBox();
            label8 = new Label();
            txtFileName = new TextBox();
            btnImage = new Button();
            picPhoto = new PictureBox();
            txtNation = new Label();
            txtClub = new TextBox();
            label11 = new Label();
            label10 = new Label();
            btnEnregistrer = new Button();
            label7 = new Label();
            btnOPtion = new Button();
            label6 = new Label();
            txtJoueurID = new TextBox();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            txtRecherche = new TextBox();
            label12 = new Label();
            lblNbre = new Label();
            btnAjouter = new Button();
            btnConsulter = new Button();
            btnModifier = new Button();
            btnFermer = new Button();
            btnSupprimer = new Button();
            openFileDialog1 = new OpenFileDialog();
            columnHeader9 = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtLieuNaiss);
            groupBox1.Controls.Add(txtDateNaiss);
            groupBox1.Controls.Add(txtPost);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtFileName);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(picPhoto);
            groupBox1.Controls.Add(txtNation);
            groupBox1.Controls.Add(txtClub);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnEnregistrer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnOPtion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtJoueurID);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(txtPrenom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1329, 543);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(427, 267);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(401, 31);
            txtContact.TabIndex = 70;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(427, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 31);
            txtEmail.TabIndex = 69;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(230, 263);
            label14.Name = "label14";
            label14.Size = new Size(85, 28);
            label14.TabIndex = 68;
            label14.Text = "Contact";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(230, 231);
            label13.Name = "label13";
            label13.Size = new Size(64, 28);
            label13.TabIndex = 67;
            label13.Text = "Email";
            // 
            // txtLieuNaiss
            // 
            txtLieuNaiss.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLieuNaiss.Location = new Point(427, 332);
            txtLieuNaiss.Multiline = true;
            txtLieuNaiss.Name = "txtLieuNaiss";
            txtLieuNaiss.Size = new Size(401, 28);
            txtLieuNaiss.TabIndex = 66;
            // 
            // txtDateNaiss
            // 
            txtDateNaiss.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateNaiss.Location = new Point(427, 299);
            txtDateNaiss.Name = "txtDateNaiss";
            txtDateNaiss.Size = new Size(401, 31);
            txtDateNaiss.TabIndex = 65;
            // 
            // txtPost
            // 
            txtPost.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPost.FormattingEnabled = true;
            txtPost.Items.AddRange(new object[] { "Attaquants", "Milieux de terrain", "Défenseurs", "Gardien de but" });
            txtPost.Location = new Point(427, 366);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(401, 32);
            txtPost.TabIndex = 64;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Lucida Sans Typewriter", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(1317, 56);
            label8.TabIndex = 63;
            label8.Text = "Joueurs ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            txtFileName.CharacterCasing = CharacterCasing.Upper;
            txtFileName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFileName.ForeColor = Color.Blue;
            txtFileName.Location = new Point(922, 523);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(401, 13);
            txtFileName.TabIndex = 62;
            txtFileName.Visible = false;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // btnImage
            // 
            btnImage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImage.Location = new Point(848, 483);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(274, 53);
            btnImage.TabIndex = 61;
            btnImage.Text = "Choisir une image ...";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // picPhoto
            // 
            picPhoto.BackColor = Color.SlateGray;
            picPhoto.ErrorImage = null;
            picPhoto.Image = (Image)resources.GetObject("picPhoto.Image");
            picPhoto.Location = new Point(848, 130);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(274, 347);
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 60;
            picPhoto.TabStop = false;
            picPhoto.Click += picPhoto_Click;
            // 
            // txtNation
            // 
            txtNation.BackColor = Color.White;
            txtNation.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNation.Location = new Point(427, 86);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(172, 31);
            txtNation.TabIndex = 24;
            txtNation.TextAlign = ContentAlignment.MiddleCenter;
            txtNation.Click += txtNation_Click;
            // 
            // txtClub
            // 
            txtClub.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtClub.Location = new Point(427, 404);
            txtClub.Multiline = true;
            txtClub.Name = "txtClub";
            txtClub.Size = new Size(401, 28);
            txtClub.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(230, 404);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 20;
            label11.Text = "Club joueur";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(230, 370);
            label10.Name = "label10";
            label10.Size = new Size(130, 28);
            label10.TabIndex = 18;
            label10.Text = "Poste joueur";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.Wheat;
            btnEnregistrer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(648, 438);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(180, 53);
            btnEnregistrer.TabIndex = 16;
            btnEnregistrer.Text = "&Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(648, 83);
            label7.Name = "label7";
            label7.Size = new Size(474, 34);
            label7.TabIndex = 14;
            label7.Text = "Nom Nation";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // btnOPtion
            // 
            btnOPtion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOPtion.Location = new Point(605, 86);
            btnOPtion.Name = "btnOPtion";
            btnOPtion.Size = new Size(37, 31);
            btnOPtion.TabIndex = 13;
            btnOPtion.Text = "...";
            btnOPtion.UseVisualStyleBackColor = true;
            btnOPtion.Click += btnOPtion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(230, 332);
            label6.Name = "label6";
            label6.Size = new Size(177, 28);
            label6.TabIndex = 11;
            label6.Text = "Lieu de naissance";
            // 
            // txtJoueurID
            // 
            txtJoueurID.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtJoueurID.Location = new Point(427, 129);
            txtJoueurID.Multiline = true;
            txtJoueurID.Name = "txtJoueurID";
            txtJoueurID.Size = new Size(401, 27);
            txtJoueurID.TabIndex = 10;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNom.Location = new Point(427, 162);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(401, 28);
            txtNom.TabIndex = 9;
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrenom.Location = new Point(427, 196);
            txtPrenom.Multiline = true;
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(401, 28);
            txtPrenom.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(230, 299);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 4;
            label5.Text = "Date de naissance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(230, 197);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 3;
            label4.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(230, 163);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 2;
            label3.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 131);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Joueur ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 94);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 0;
            label1.Text = "Nation";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lviewRech);
            groupBox2.Controls.Add(txtRecherche);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(lblNbre);
            groupBox2.Controls.Add(btnAjouter);
            groupBox2.Controls.Add(btnConsulter);
            groupBox2.Controls.Add(btnModifier);
            groupBox2.Controls.Add(btnFermer);
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Location = new Point(12, 561);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1329, 369);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // lviewRech
            // 
            lviewRech.BackColor = Color.White;
            lviewRech.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lviewRech.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(11, 63);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(1312, 254);
            lviewRech.TabIndex = 40;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id joueur ";
            columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prenom";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Contact";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Date naiss";
            columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Lieu Naiss";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Poste";
            columnHeader8.Width = 150;
            // 
            // txtRecherche
            // 
            txtRecherche.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRecherche.Location = new Point(1021, 26);
            txtRecherche.Multiline = true;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(302, 31);
            txtRecherche.TabIndex = 39;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(838, 26);
            label12.Name = "label12";
            label12.Size = new Size(177, 31);
            label12.TabIndex = 24;
            label12.Text = "Nom du joueur";
            // 
            // lblNbre
            // 
            lblNbre.AutoSize = true;
            lblNbre.BackColor = Color.White;
            lblNbre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNbre.ForeColor = Color.FromArgb(0, 0, 192);
            lblNbre.Location = new Point(11, 320);
            lblNbre.Name = "lblNbre";
            lblNbre.Size = new Size(40, 23);
            lblNbre.TabIndex = 38;
            lblNbre.Text = "###";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Wheat;
            btnAjouter.Location = new Point(624, 327);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(120, 35);
            btnAjouter.TabIndex = 37;
            btnAjouter.Text = "&Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click_1;
            // 
            // btnConsulter
            // 
            btnConsulter.BackColor = Color.Wheat;
            btnConsulter.Location = new Point(876, 327);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(120, 35);
            btnConsulter.TabIndex = 36;
            btnConsulter.Text = "&Consulter";
            btnConsulter.UseVisualStyleBackColor = false;
            btnConsulter.Click += btnConsulter_Click_1;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.Wheat;
            btnModifier.Location = new Point(750, 327);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(120, 35);
            btnModifier.TabIndex = 35;
            btnModifier.Text = "&Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Wheat;
            btnFermer.Location = new Point(1203, 326);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 35);
            btnFermer.TabIndex = 34;
            btnFermer.Text = "&Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Wheat;
            btnSupprimer.Location = new Point(1002, 327);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(120, 35);
            btnSupprimer.TabIndex = 33;
            btnSupprimer.Text = "&Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Club Joueur";
            columnHeader9.Width = 100;
            // 
            // frmJoueursBrou_D_G7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 937);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmJoueursBrou_D_G7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmJoueursBrou_D_G7";
            Load += frmJoueursBrou_D_G7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label10;
        private Button btnEnregistrer;
        private Label label7;
        private Button btnOPtion;
        private Label label6;
        private TextBox txtJoueurID;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtClub;
        private Label label11;
        private GroupBox groupBox2;
        private TextBox txtRecherche;
        private Label label12;
        private Label lblNbre;
        private Button btnAjouter;
        private Button btnConsulter;
        private Button btnModifier;
        private Button btnFermer;
        private Button btnSupprimer;
        private Label txtNation;
        private TextBox txtFileName;
        private Button btnImage;
        private PictureBox picPhoto;
        private Label label8;
        private ComboBox txtPost;
        private DateTimePicker txtDateNaiss;
        private TextBox txtLieuNaiss;
        private Label label14;
        private Label label13;
        private TextBox txtContact;
        private TextBox txtEmail;
        private OpenFileDialog openFileDialog1;
        private ListView lviewRech;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}