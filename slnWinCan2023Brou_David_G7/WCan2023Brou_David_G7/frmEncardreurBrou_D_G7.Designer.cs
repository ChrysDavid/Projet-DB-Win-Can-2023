namespace WCan2023Brou_David_G7
{
    partial class frmEncardreurBrou_D_G7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncardreurBrou_D_G7));
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            cossulterToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            cbUserRole = new ComboBox();
            label7 = new Label();
            txtFileName = new TextBox();
            btnImage = new Button();
            picPhoto = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelephone = new TextBox();
            label10 = new Label();
            btnEnregistrer = new Button();
            txtEncadreurID = new TextBox();
            txtNom = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            code = new ColumnHeader();
            Nom = new ColumnHeader();
            Poste = new ColumnHeader();
            Contact = new ColumnHeader();
            Email = new ColumnHeader();
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            btnFermer = new Button();
            btnSupprimer = new Button();
            btnConsulter = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            lblNbre = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox2 = new GroupBox();
            txtRecherche = new TextBox();
            label8 = new Label();
            txtNatParticipID = new Label();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.ContextMenuStrip = contextMenuStrip1;
            groupBox1.Controls.Add(txtNatParticipID);
            groupBox1.Controls.Add(cbUserRole);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFileName);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(picPhoto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelephone);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnEnregistrer);
            groupBox1.Controls.Add(txtEncadreurID);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1213, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem, cossulterToolStripMenuItem, supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 100);
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(147, 24);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(147, 24);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // cossulterToolStripMenuItem
            // 
            cossulterToolStripMenuItem.Name = "cossulterToolStripMenuItem";
            cossulterToolStripMenuItem.Size = new Size(147, 24);
            cossulterToolStripMenuItem.Text = "Cossulter";
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(147, 24);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // cbUserRole
            // 
            cbUserRole.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Items.AddRange(new object[] { "Gardien de but", "Arrière latéral", "Défenseur central", "Milieu défensif", "Milieu offensif", "Attaquant" });
            cbUserRole.Location = new Point(385, 242);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(401, 28);
            cbUserRole.TabIndex = 61;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(591, 102);
            label7.Name = "label7";
            label7.Size = new Size(399, 34);
            label7.TabIndex = 60;
            label7.Text = "Nation";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            txtFileName.CharacterCasing = CharacterCasing.Upper;
            txtFileName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFileName.ForeColor = Color.Blue;
            txtFileName.Location = new Point(385, 430);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(401, 13);
            txtFileName.TabIndex = 59;
            txtFileName.Visible = false;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // btnImage
            // 
            btnImage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnImage.Location = new Point(792, 414);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(198, 29);
            btnImage.TabIndex = 58;
            btnImage.Text = "Choisir une image ...";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // picPhoto
            // 
            picPhoto.BackColor = Color.SlateGray;
            picPhoto.ErrorImage = null;
            picPhoto.Image = (Image)resources.GetObject("picPhoto.Image");
            picPhoto.Location = new Point(792, 142);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(198, 266);
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 53;
            picPhoto.TabStop = false;
            picPhoto.Click += picPhoto_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(1187, 65);
            label4.TabIndex = 26;
            label4.Text = "ENCARDREUR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(535, 107);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 24;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 108);
            label1.Name = "label1";
            label1.Size = new Size(230, 29);
            label1.TabIndex = 22;
            label1.Text = "ID Nation Encadreur";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(385, 326);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 38);
            txtEmail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(149, 336);
            label6.Name = "label6";
            label6.Size = new Size(72, 29);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelephone.Location = new Point(385, 276);
            txtTelephone.Multiline = true;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(401, 38);
            txtTelephone.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(149, 286);
            label10.Name = "label10";
            label10.Size = new Size(125, 29);
            label10.TabIndex = 18;
            label10.Text = "Telephone";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.Wheat;
            btnEnregistrer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(608, 372);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(166, 36);
            btnEnregistrer.TabIndex = 16;
            btnEnregistrer.Text = "&Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += button2_Click;
            // 
            // txtEncadreurID
            // 
            txtEncadreurID.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEncadreurID.Location = new Point(385, 142);
            txtEncadreurID.Multiline = true;
            txtEncadreurID.Name = "txtEncadreurID";
            txtEncadreurID.Size = new Size(401, 38);
            txtEncadreurID.TabIndex = 10;
            txtEncadreurID.TextChanged += textBox6_TextChanged;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNom.Location = new Point(385, 186);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(401, 38);
            txtNom.TabIndex = 9;
            txtNom.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(149, 242);
            label5.Name = "label5";
            label5.Size = new Size(185, 29);
            label5.TabIndex = 4;
            label5.Text = "Encadreur poste";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 194);
            label3.Name = "label3";
            label3.Size = new Size(66, 29);
            label3.TabIndex = 2;
            label3.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(149, 152);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 1;
            label2.Text = "Encadreuer ID";
            // 
            // code
            // 
            code.Text = "Code Encadreur";
            code.Width = 160;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 150;
            // 
            // Poste
            // 
            Poste.Text = "Encadreur Poste";
            Poste.Width = 180;
            // 
            // Contact
            // 
            Contact.Text = "Contact";
            Contact.Width = 160;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 220;
            // 
            // lviewRech
            // 
            lviewRech.BackColor = SystemColors.GradientInactiveCaption;
            lviewRech.Columns.AddRange(new ColumnHeader[] { code, Nom, Poste, Contact, Email, columnHeader1 });
            lviewRech.ContextMenuStrip = contextMenuStrip1;
            lviewRech.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(10, 66);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(1199, 336);
            lviewRech.TabIndex = 1;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            lviewRech.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Nation";
            columnHeader1.Width = 160;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Wheat;
            btnFermer.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.Location = new Point(1086, 408);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 35);
            btnFermer.TabIndex = 19;
            btnFermer.Text = "&Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += button2_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Wheat;
            btnSupprimer.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(853, 408);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(120, 35);
            btnSupprimer.TabIndex = 18;
            btnSupprimer.Text = "&Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.BackColor = Color.Wheat;
            btnConsulter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulter.Location = new Point(727, 408);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(120, 35);
            btnConsulter.TabIndex = 21;
            btnConsulter.Text = "&Consulter";
            btnConsulter.UseVisualStyleBackColor = false;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.Wheat;
            btnModifier.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(601, 408);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(120, 35);
            btnModifier.TabIndex = 20;
            btnModifier.Text = "&Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Wheat;
            btnAjouter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.Location = new Point(475, 408);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(120, 35);
            btnAjouter.TabIndex = 22;
            btnAjouter.Text = "&Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += button6_Click;
            // 
            // lblNbre
            // 
            lblNbre.AutoSize = true;
            lblNbre.BackColor = Color.White;
            lblNbre.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblNbre.ForeColor = Color.FromArgb(0, 0, 192);
            lblNbre.Location = new Point(10, 405);
            lblNbre.Name = "lblNbre";
            lblNbre.Size = new Size(40, 22);
            lblNbre.TabIndex = 23;
            lblNbre.Text = "###";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(txtRecherche);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lviewRech);
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(lblNbre);
            groupBox2.Controls.Add(btnFermer);
            groupBox2.Controls.Add(btnAjouter);
            groupBox2.Controls.Add(btnModifier);
            groupBox2.Controls.Add(btnConsulter);
            groupBox2.Location = new Point(13, 469);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1212, 449);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(943, 26);
            txtRecherche.Multiline = true;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(263, 34);
            txtRecherche.TabIndex = 25;
            txtRecherche.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(778, 25);
            label8.Name = "label8";
            label8.Size = new Size(159, 28);
            label8.TabIndex = 24;
            label8.Text = "Nom encadreur";
            // 
            // txtNatParticipID
            // 
            txtNatParticipID.BackColor = Color.White;
            txtNatParticipID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNatParticipID.Location = new Point(385, 102);
            txtNatParticipID.Name = "txtNatParticipID";
            txtNatParticipID.Size = new Size(144, 35);
            txtNatParticipID.TabIndex = 62;
            txtNatParticipID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEncardreurBrou_D_G7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 924);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmEncardreurBrou_D_G7";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEncardreurBrou_D_G7";
            Load += frmEncardreurBrou_D_G7_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label5;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem cossulterToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private TextBox txtEncadreurID;
        private TextBox txtNom;
        private Button btnEnregistrer;
        private ColumnHeader code;
        private ColumnHeader Nom;
        private ColumnHeader Poste;
        private ColumnHeader Contact;
        private ColumnHeader Email;
        private ListView lviewRech;
        private Button btnFermer;
        private Button btnSupprimer;
        private Button btnConsulter;
        private Button btnModifier;
        private Button btnAjouter;
        private Label lblNbre;
        private TextBox txtTelephone;
        private Label label10;
        private TextBox txtEmail;
        private Label label6;
        private Label label1;
        private ColumnHeader columnHeader1;
        private Button button1;
        private Label label4;
        private Button btnImage;
        private PictureBox picPhoto;
        private OpenFileDialog openFileDialog1;
        private TextBox txtFileName;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtRecherche;
        private Label label8;
        private ComboBox cbUserRole;
        private Label txtNatParticipID;
    }
}