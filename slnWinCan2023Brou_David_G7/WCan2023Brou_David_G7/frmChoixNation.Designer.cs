namespace WCan2023Brou_David_G7
{
    partial class frmChoixNation
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
            groupBox1 = new GroupBox();
            lblNbre = new Label();
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnFermer = new Button();
            txtRecherche = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ajouter = new ToolStrip();
            Modifier = new ToolStrip();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(lblNbre);
            groupBox1.Controls.Add(lviewRech);
            groupBox1.Controls.Add(btnFermer);
            groupBox1.Controls.Add(txtRecherche);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1417, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblNbre
            // 
            lblNbre.AutoSize = true;
            lblNbre.BackColor = Color.FromArgb(224, 224, 224);
            lblNbre.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNbre.Location = new Point(6, 399);
            lblNbre.Name = "lblNbre";
            lblNbre.Size = new Size(54, 28);
            lblNbre.TabIndex = 6;
            lblNbre.Text = "###";
            // 
            // lviewRech
            // 
            lviewRech.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lviewRech.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(6, 67);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(1405, 326);
            lviewRech.TabIndex = 5;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nation participe";
            columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom";
            columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surnom";
            columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Poule";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nbre de titre";
            columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Classe FIFA";
            columnHeader7.Width = 240;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Red;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(1254, 414);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(157, 41);
            btnFermer.TabIndex = 3;
            btnFermer.Text = "&Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnAnnuler_Click;
            // 
            // txtRecherche
            // 
            txtRecherche.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecherche.Location = new Point(1136, 26);
            txtRecherche.Multiline = true;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(275, 34);
            txtRecherche.TabIndex = 2;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(978, 25);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Non de Nation";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1417, 125);
            label1.TabIndex = 1;
            label1.Text = "Choisissez une Nation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ajouter
            // 
            ajouter.ImageScalingSize = new Size(20, 20);
            ajouter.Location = new Point(0, 0);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(1441, 25);
            ajouter.TabIndex = 2;
            ajouter.Text = "toolStrip1";
            ajouter.ItemClicked += ajouter_ItemClicked;
            // 
            // Modifier
            // 
            Modifier.ImageScalingSize = new Size(20, 20);
            Modifier.Location = new Point(0, 25);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(1441, 25);
            Modifier.TabIndex = 3;
            Modifier.Text = "toolStrip1";
            Modifier.ItemClicked += Modifier_ItemClicked;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frmChoixNation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1441, 624);
            Controls.Add(Modifier);
            Controls.Add(ajouter);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmChoixNation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChoixNation";
            Load += frmChoixNation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtRecherche;
        private Button btnFermer;
        private ListView lviewRech;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label lblNbre;
        private ToolStrip ajouter;
        private ToolStrip Modifier;
        private ImageList imageList1;
    }
}