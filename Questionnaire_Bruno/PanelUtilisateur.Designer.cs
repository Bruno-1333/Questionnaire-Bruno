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
            btnCommencer = new Button();
            lblNonUtilisateurCourant = new Label();
            label1 = new Label();
            txtNbrQuestions = new TextBox();
            txtScore = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCommencer
            // 
            btnCommencer.BackColor = Color.Transparent;
            btnCommencer.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommencer.Location = new Point(301, 543);
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
            lblNonUtilisateurCourant.Location = new Point(1026, 92);
            lblNonUtilisateurCourant.Name = "lblNonUtilisateurCourant";
            lblNonUtilisateurCourant.Size = new Size(31, 37);
            lblNonUtilisateurCourant.TabIndex = 6;
            lblNonUtilisateurCourant.Text = "*";
            lblNonUtilisateurCourant.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 204);
            label1.Name = "label1";
            label1.Size = new Size(346, 27);
            label1.TabIndex = 7;
            label1.Text = "Choisir le numero des question";
            // 
            // txtNbrQuestions
            // 
            txtNbrQuestions.Location = new Point(375, 210);
            txtNbrQuestions.Name = "txtNbrQuestions";
            txtNbrQuestions.Size = new Size(100, 23);
            txtNbrQuestions.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(348, 300);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 294);
            label2.Name = "label2";
            label2.Size = new Size(309, 27);
            label2.TabIndex = 9;
            label2.Text = "Choisir le score de passage";
            // 
            // PanelUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1279, 612);
            Controls.Add(txtScore);
            Controls.Add(label2);
            Controls.Add(txtNbrQuestions);
            Controls.Add(label1);
            Controls.Add(lblNonUtilisateurCourant);
            Controls.Add(btnCommencer);
            DoubleBuffered = true;
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
        private Label label1;
        private TextBox txtNbrQuestions;
        private TextBox txtScore;
        private Label label2;
    }
}