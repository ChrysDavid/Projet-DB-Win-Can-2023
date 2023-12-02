namespace WCan2023Brou_David_G7
{
    partial class frmUtilisateurBrou_D_G7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilisateurBrou_D_G7));
            groupBox2 = new GroupBox();
            txtRecherche = new TextBox();
            label5 = new Label();
            lblNbre = new Label();
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnSupprimer = new Button();
            btnAjouter = new Button();
            btnFermer = new Button();
            btnConsulter = new Button();
            btnModifier = new Button();
            groupBox1 = new GroupBox();
            cbUserRole = new ComboBox();
            txtLogin = new TextBox();
            picPhoto = new PictureBox();
            btnEnregistrer = new Button();
            txtEmail = new TextBox();
            txtNom = new TextBox();
            txtMotdepasse = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(txtRecherche);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblNbre);
            groupBox2.Controls.Add(lviewRech);
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(btnAjouter);
            groupBox2.Controls.Add(btnFermer);
            groupBox2.Controls.Add(btnConsulter);
            groupBox2.Controls.Add(btnModifier);
            groupBox2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(11, 335);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(840, 401);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liste d'utisateurs";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(556, 33);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(267, 34);
            txtRecherche.TabIndex = 51;
            txtRecherche.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 36);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 50;
            label5.Text = "Nom";
            // 
            // lblNbre
            // 
            lblNbre.AutoSize = true;
            lblNbre.BackColor = SystemColors.ButtonHighlight;
            lblNbre.ForeColor = Color.Blue;
            lblNbre.Location = new Point(7, 345);
            lblNbre.Margin = new Padding(2, 0, 2, 0);
            lblNbre.Name = "lblNbre";
            lblNbre.Size = new Size(51, 28);
            lblNbre.TabIndex = 49;
            lblNbre.Text = "###";
            // 
            // lviewRech
            // 
            lviewRech.BackColor = Color.FromArgb(255, 192, 255);
            lviewRech.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5 });
            lviewRech.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lviewRech.ForeColor = Color.Navy;
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(7, 73);
            lviewRech.Margin = new Padding(2, 3, 2, 3);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(815, 266);
            lviewRech.TabIndex = 43;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Login";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom et Prenoms ";
            columnHeader2.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Poste ou Rôle";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            columnHeader5.Width = 260;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(255, 128, 128);
            btnSupprimer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSupprimer.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnSupprimer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.ForeColor = Color.Black;
            btnSupprimer.Location = new Point(556, 346);
            btnSupprimer.Margin = new Padding(2, 3, 2, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(107, 39);
            btnSupprimer.TabIndex = 48;
            btnSupprimer.TabStop = false;
            btnSupprimer.Text = "&Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = SystemColors.Control;
            btnAjouter.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAjouter.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnAjouter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.ForeColor = Color.Black;
            btnAjouter.Location = new Point(220, 346);
            btnAjouter.Margin = new Padding(2, 3, 2, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(107, 39);
            btnAjouter.TabIndex = 47;
            btnAjouter.TabStop = false;
            btnAjouter.Text = "&Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = SystemColors.Control;
            btnFermer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnFermer.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnFermer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Location = new Point(716, 345);
            btnFermer.Margin = new Padding(2, 3, 2, 3);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(107, 40);
            btnFermer.TabIndex = 47;
            btnFermer.TabStop = false;
            btnFermer.Text = "&Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.BackColor = Color.FromArgb(255, 255, 192);
            btnConsulter.FlatAppearance.BorderColor = Color.SteelBlue;
            btnConsulter.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnConsulter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnConsulter.FlatStyle = FlatStyle.Flat;
            btnConsulter.Location = new Point(444, 346);
            btnConsulter.Margin = new Padding(2, 3, 2, 3);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(107, 39);
            btnConsulter.TabIndex = 45;
            btnConsulter.TabStop = false;
            btnConsulter.Text = "&Consulter";
            btnConsulter.UseVisualStyleBackColor = false;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(255, 128, 0);
            btnModifier.FlatAppearance.BorderColor = Color.SteelBlue;
            btnModifier.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnModifier.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.ForeColor = Color.Black;
            btnModifier.Location = new Point(332, 346);
            btnModifier.Margin = new Padding(2, 3, 2, 3);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(107, 39);
            btnModifier.TabIndex = 44;
            btnModifier.TabStop = false;
            btnModifier.Text = "&Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(cbUserRole);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Controls.Add(picPhoto);
            groupBox1.Controls.Add(btnEnregistrer);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(txtMotdepasse);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(11, 9);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(840, 320);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détail d'utilisateur";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbUserRole
            // 
            cbUserRole.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUserRole.ForeColor = Color.Blue;
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Items.AddRange(new object[] { "OPERATEUR", "MANAGER", "ADMIN" });
            cbUserRole.Location = new Point(273, 178);
            cbUserRole.Margin = new Padding(2, 3, 2, 3);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(325, 35);
            cbUserRole.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.CharacterCasing = CharacterCasing.Upper;
            txtLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.Blue;
            txtLogin.Location = new Point(273, 54);
            txtLogin.Margin = new Padding(2, 3, 2, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(325, 34);
            txtLogin.TabIndex = 0;
            // 
            // picPhoto
            // 
            picPhoto.BackColor = Color.SlateGray;
            picPhoto.BackgroundImage = (Image)resources.GetObject("picPhoto.BackgroundImage");
            picPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            picPhoto.ErrorImage = (Image)resources.GetObject("picPhoto.ErrorImage");
            picPhoto.Location = new Point(620, 54);
            picPhoto.Margin = new Padding(2, 3, 2, 3);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(203, 246);
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 52;
            picPhoto.TabStop = false;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(128, 255, 128);
            btnEnregistrer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.Purple;
            btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(428, 259);
            btnEnregistrer.Margin = new Padding(2, 3, 2, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(170, 41);
            btnEnregistrer.TabIndex = 5;
            btnEnregistrer.Text = "&Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtEmail.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Blue;
            txtEmail.Location = new Point(273, 219);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 34);
            txtEmail.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNom.ForeColor = Color.Blue;
            txtNom.Location = new Point(273, 138);
            txtNom.Margin = new Padding(2, 3, 2, 3);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(325, 34);
            txtNom.TabIndex = 2;
            // 
            // txtMotdepasse
            // 
            txtMotdepasse.CharacterCasing = CharacterCasing.Upper;
            txtMotdepasse.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotdepasse.ForeColor = Color.Blue;
            txtMotdepasse.Location = new Point(273, 98);
            txtMotdepasse.Margin = new Padding(2, 3, 2, 3);
            txtMotdepasse.Name = "txtMotdepasse";
            txtMotdepasse.Size = new Size(325, 34);
            txtMotdepasse.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(47, 178);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 56;
            label1.Text = "Rôle d'utilisateur";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(47, 54);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 29);
            label4.TabIndex = 54;
            label4.Text = "Login de connexion";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(47, 221);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(222, 29);
            label7.TabIndex = 46;
            label7.Text = "E-mail de l'utilisateur";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(47, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 29);
            label2.TabIndex = 40;
            label2.Text = "Mot de passe";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(47, 137);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(222, 29);
            label3.TabIndex = 41;
            label3.Text = "Nom et prénoms ";
            // 
            // frmUtilisateurBrou_D_G7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(861, 746);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmUtilisateurBrou_D_G7";
            Load += frmUtilisateurBrou_D_G7_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label lblNbre;
        private ListView lviewRech;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        public Button btnSupprimer;
        private Button btnAjouter;
        private Button btnFermer;
        public Button btnConsulter;
        private Button btnModifier;
        private GroupBox groupBox1;
        private ComboBox cbUserRole;
        private TextBox txtLogin;
        private PictureBox picPhoto;
        private Button btnEnregistrer;
        private TextBox txtEmail;
        private TextBox txtNom;
        private TextBox txtMotdepasse;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox txtRecherche;
        private Label label5;
    }
}