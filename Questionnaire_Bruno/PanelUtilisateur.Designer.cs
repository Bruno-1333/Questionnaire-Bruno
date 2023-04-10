namespace Questionnaire_Bruno
{
    partial class PanelUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUtilisateur));
            btnRegle = new Button();
            btnCommencer = new Button();
            lblNonUtilisateurCourant = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnRegle
            // 
            btnRegle.BackColor = Color.Transparent;
            btnRegle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegle.Location = new Point(12, 541);
            btnRegle.Name = "btnRegle";
            btnRegle.Size = new Size(196, 46);
            btnRegle.TabIndex = 1;
            btnRegle.Text = "Règle";
            btnRegle.UseVisualStyleBackColor = false;
            btnRegle.Click += btnRegle_Click;
            // 
            // btnCommencer
            // 
            btnCommencer.BackColor = Color.Transparent;
            btnCommencer.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommencer.Location = new Point(253, 541);
            btnCommencer.Name = "btnCommencer";
            btnCommencer.Size = new Size(196, 46);
            btnCommencer.TabIndex = 2;
            btnCommencer.Text = "Commencer";
            btnCommencer.UseVisualStyleBackColor = false;
            btnCommencer.Click += btnCommencer_Click;
            // 
            // lblNonUtilisateurCourant
            // 
            lblNonUtilisateurCourant.AutoSize = true;
            lblNonUtilisateurCourant.BackColor = Color.Transparent;
            lblNonUtilisateurCourant.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNonUtilisateurCourant.ForeColor = Color.Gold;
            lblNonUtilisateurCourant.Location = new Point(954, 84);
            lblNonUtilisateurCourant.Name = "lblNonUtilisateurCourant";
            lblNonUtilisateurCourant.Size = new Size(31, 37);
            lblNonUtilisateurCourant.TabIndex = 6;
            lblNonUtilisateurCourant.Text = "*";
            lblNonUtilisateurCourant.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(12, 128);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 180);
            textBox1.TabIndex = 2;
            textBox1.Text = "A regle do juex\r\n\r\nLe jouxxxxxxxxxxx\r\nxxxxx\r\nxxxxxx Score de Passage YYYYYYYY";
            textBox1.Visible = false;
            // 
            // PanelUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1279, 611);
            Controls.Add(textBox1);
            Controls.Add(lblNonUtilisateurCourant);
            Controls.Add(btnCommencer);
            Controls.Add(btnRegle);
            Name = "PanelUtilisateur";
            Text = "PanelUtilisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegle;
        private Button btnCommencer;
        private Label lblNonUtilisateurCourant;
        private TextBox textBox1;
    }
}