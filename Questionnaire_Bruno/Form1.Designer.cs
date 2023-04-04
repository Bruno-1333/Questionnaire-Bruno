namespace Questionnaire_Bruno
{
    partial class Form1
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
            radioButtonAdm = new RadioButton();
            radioButtonUser = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Connecter = new Button();
            Annuler = new Button();
            textMotPasse = new TextBox();
            textLogin = new TextBox();
            NouvelUtilisateur = new LinkLabel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonAdm
            // 
            radioButtonAdm.AutoSize = true;
            radioButtonAdm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAdm.Location = new Point(564, 253);
            radioButtonAdm.Margin = new Padding(4, 5, 4, 5);
            radioButtonAdm.Name = "radioButtonAdm";
            radioButtonAdm.Size = new Size(103, 44);
            radioButtonAdm.TabIndex = 0;
            radioButtonAdm.TabStop = true;
            radioButtonAdm.Text = "Adm";
            radioButtonAdm.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUser.Location = new Point(413, 253);
            radioButtonUser.Margin = new Padding(4, 5, 4, 5);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(99, 44);
            radioButtonUser.TabIndex = 1;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "User";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 40);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 40);
            label2.TabIndex = 4;
            label2.Text = "Mote Passae";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(231, 253);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 40);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // Connecter
            // 
            Connecter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Connecter.Location = new Point(637, 387);
            Connecter.Margin = new Padding(4, 5, 4, 5);
            Connecter.Name = "Connecter";
            Connecter.Size = new Size(191, 55);
            Connecter.TabIndex = 6;
            Connecter.Text = "Connecter";
            Connecter.UseVisualStyleBackColor = true;
            Connecter.Click += Connecter_Click;
            // 
            // Annuler
            // 
            Annuler.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Annuler.Location = new Point(413, 387);
            Annuler.Margin = new Padding(4, 5, 4, 5);
            Annuler.Name = "Annuler";
            Annuler.Size = new Size(191, 55);
            Annuler.TabIndex = 7;
            Annuler.Text = "Annuler";
            Annuler.UseVisualStyleBackColor = true;
            Annuler.Click += Annuler_Click;
            // 
            // textMotPasse
            // 
            textMotPasse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textMotPasse.Location = new Point(413, 143);
            textMotPasse.Margin = new Padding(4, 5, 4, 5);
            textMotPasse.Name = "textMotPasse";
            textMotPasse.PasswordChar = '*';
            textMotPasse.Size = new Size(414, 45);
            textMotPasse.TabIndex = 8;
            // 
            // textLogin
            // 
            textLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textLogin.Location = new Point(413, 58);
            textLogin.Margin = new Padding(4, 5, 4, 5);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(414, 45);
            textLogin.TabIndex = 9;
            // 
            // NouvelUtilisateur
            // 
            NouvelUtilisateur.AutoSize = true;
            NouvelUtilisateur.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NouvelUtilisateur.Location = new Point(596, 522);
            NouvelUtilisateur.Margin = new Padding(4, 0, 4, 0);
            NouvelUtilisateur.Name = "NouvelUtilisateur";
            NouvelUtilisateur.Size = new Size(245, 40);
            NouvelUtilisateur.TabIndex = 3;
            NouvelUtilisateur.TabStop = true;
            NouvelUtilisateur.Text = "Nouvel Utilisateur";
            NouvelUtilisateur.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 797);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Location = new Point(223, 252);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 70);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(221, 38);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 205);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1301, 797);
            Controls.Add(textLogin);
            Controls.Add(textMotPasse);
            Controls.Add(Annuler);
            Controls.Add(Connecter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NouvelUtilisateur);
            Controls.Add(label1);
            Controls.Add(radioButtonUser);
            Controls.Add(radioButtonAdm);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonAdm;
        private RadioButton radioButtonUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Connecter;
        private Button Annuler;
        private TextBox textMotPasse;
        private TextBox textLogin;
        private LinkLabel NouvelUtilisateur;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}