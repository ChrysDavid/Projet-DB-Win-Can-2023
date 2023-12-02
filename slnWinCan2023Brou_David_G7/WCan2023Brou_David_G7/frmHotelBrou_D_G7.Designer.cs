namespace WCan2023Brou_David_G7
{
    partial class frmHotelBrou_D_G7
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
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label10 = new Label();
            txtTarrifday = new TextBox();
            label1 = new Label();
            btnEnregistrer = new Button();
            label7 = new Label();
            txtContact = new TextBox();
            label6 = new Label();
            txtHotelID = new TextBox();
            txtNom = new TextBox();
            txtNbreEtoile = new TextBox();
            txtAdress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lblNbre = new Label();
            txtRecherche = new TextBox();
            label8 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnConsulter = new Button();
            btnSupprimer = new Button();
            btnFermer = new Button();
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtTarrifday);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEnregistrer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHotelID);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(txtNbreEtoile);
            groupBox1.Controls.Add(txtAdress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1346, 499);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(512, 230);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 38);
            txtEmail.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(342, 231);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 22;
            label10.Text = "Email";
            // 
            // txtTarrifday
            // 
            txtTarrifday.Location = new Point(512, 407);
            txtTarrifday.Multiline = true;
            txtTarrifday.Name = "txtTarrifday";
            txtTarrifday.Size = new Size(401, 38);
            txtTarrifday.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 408);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 20;
            label1.Text = "Tarrif journalier";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.Wheat;
            btnEnregistrer.Location = new Point(793, 451);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(120, 35);
            btnEnregistrer.TabIndex = 16;
            btnEnregistrer.Text = "&Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Font = new Font("Algerian", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(1334, 95);
            label7.TabIndex = 14;
            label7.Text = "Hotel";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(512, 318);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(401, 38);
            txtContact.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(342, 319);
            label6.Name = "label6";
            label6.Size = new Size(126, 28);
            label6.TabIndex = 11;
            label6.Text = "Contact Tel.";
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(512, 140);
            txtHotelID.Multiline = true;
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(401, 38);
            txtHotelID.TabIndex = 10;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(512, 184);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(401, 38);
            txtNom.TabIndex = 9;
            // 
            // txtNbreEtoile
            // 
            txtNbreEtoile.Location = new Point(512, 363);
            txtNbreEtoile.Multiline = true;
            txtNbreEtoile.Name = "txtNbreEtoile";
            txtNbreEtoile.Size = new Size(401, 38);
            txtNbreEtoile.TabIndex = 8;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(512, 274);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(401, 38);
            txtAdress.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(342, 275);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 4;
            label5.Text = "Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(342, 364);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 3;
            label4.Text = "Nombre d'étoile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(342, 183);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(342, 141);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 1;
            label2.Text = "Hotel code";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lblNbre);
            groupBox2.Controls.Add(txtRecherche);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnAjouter);
            groupBox2.Controls.Add(btnModifier);
            groupBox2.Controls.Add(btnConsulter);
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(btnFermer);
            groupBox2.Controls.Add(lviewRech);
            groupBox2.Location = new Point(12, 518);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 400);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lblNbre
            // 
            lblNbre.AutoSize = true;
            lblNbre.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNbre.Location = new Point(6, 344);
            lblNbre.Name = "lblNbre";
            lblNbre.Size = new Size(51, 28);
            lblNbre.TabIndex = 16;
            lblNbre.Text = "###";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(939, 26);
            txtRecherche.Multiline = true;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(401, 38);
            txtRecherche.TabIndex = 15;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(798, 26);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 14;
            label8.Text = "Nom hotel";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(128, 255, 255);
            btnAjouter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.Location = new Point(553, 356);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(139, 40);
            btnAjouter.TabIndex = 13;
            btnAjouter.Text = "&Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click_1;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(255, 255, 128);
            btnModifier.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.Location = new Point(697, 356);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(139, 40);
            btnModifier.TabIndex = 12;
            btnModifier.Text = "&Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.BackColor = Color.FromArgb(255, 128, 0);
            btnConsulter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsulter.Location = new Point(842, 356);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(139, 40);
            btnConsulter.TabIndex = 11;
            btnConsulter.Text = "&Consulter";
            btnConsulter.UseVisualStyleBackColor = false;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(255, 128, 128);
            btnSupprimer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(987, 356);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(139, 40);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "&Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.White;
            btnFermer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.Location = new Point(1201, 354);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(139, 40);
            btnFermer.TabIndex = 9;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click_1;
            // 
            // lviewRech
            // 
            lviewRech.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader4, columnHeader5, columnHeader7 });
            lviewRech.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(6, 69);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(1334, 272);
            lviewRech.TabIndex = 0;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Hotel";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom Hotel";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            columnHeader3.Width = 210;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 5;
            columnHeader6.Text = "Nbre d'Etoile";
            columnHeader6.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Adress";
            columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Contact";
            columnHeader5.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tarrif Day";
            columnHeader7.Width = 120;
            // 
            // frmHotelBrou_D_G7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 930);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHotelBrou_D_G7";
            Text = "frmHotelBrou_D_G7";
            Load += frmHotelBrou_D_G7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnEnregistrer;
        private Label label7;
        private TextBox txtContact;
        private Label label6;
        private TextBox txtHotelID;
        private TextBox txtNom;
        private TextBox txtNbreEtoile;
        private TextBox txtAdress;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTarrifday;
        private Label label1;
        private GroupBox groupBox2;
        private ListView lviewRech;
        private TextBox txtRecherche;
        private Label label8;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnConsulter;
        private Button btnSupprimer;
        private Button btnFermer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label lblNbre;
        private TextBox txtEmail;
        private Label label10;
    }
}