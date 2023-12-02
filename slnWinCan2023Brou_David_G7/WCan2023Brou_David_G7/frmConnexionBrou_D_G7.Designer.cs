namespace WCan2023Brou_David_G7
{
    partial class frmConnexionBrou_D_G7
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
            label3 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtpassword = new TextBox();
            txtlogin = new TextBox();
            btnAnnuler = new Button();
            btnok = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-9, -1);
            label3.Name = "label3";
            label3.Size = new Size(876, 119);
            label3.TabIndex = 14;
            label3.Text = "Connexion";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtlogin);
            groupBox1.Controls.Add(btnAnnuler);
            groupBox1.Controls.Add(btnok);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(851, 229);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 37);
            label2.TabIndex = 19;
            label2.Text = "Mots de passe";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(331, 107);
            txtpassword.Margin = new Padding(4, 3, 4, 3);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(504, 38);
            txtpassword.TabIndex = 18;
            txtpassword.Text = "1234";
            // 
            // txtlogin
            // 
            txtlogin.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtlogin.Location = new Point(331, 39);
            txtlogin.Margin = new Padding(4, 3, 4, 3);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(504, 38);
            txtlogin.TabIndex = 17;
            txtlogin.Text = "Brou David";
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(255, 128, 128);
            btnAnnuler.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnnuler.Location = new Point(665, 166);
            btnAnnuler.Margin = new Padding(4, 3, 4, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(173, 44);
            btnAnnuler.TabIndex = 16;
            btnAnnuler.Text = "&Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnok
            // 
            btnok.BackColor = Color.Wheat;
            btnok.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnok.Location = new Point(485, 166);
            btnok.Margin = new Padding(4, 3, 4, 3);
            btnok.Name = "btnok";
            btnok.Size = new Size(173, 44);
            btnok.TabIndex = 15;
            btnok.Text = "&OK";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 14;
            label1.Text = "Nom de connexion";
            // 
            // frmConnexionBrou_D_G7
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 374);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmConnexionBrou_D_G7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConnexionBrou_D_G7";
            Load += frmConnexionBrou_D_G7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtpassword;
        private TextBox txtlogin;
        private Button btnAnnuler;
        private Button btnok;
        private Label label1;
    }
}