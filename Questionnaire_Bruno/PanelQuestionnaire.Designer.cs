namespace Questionnaire_Bruno
{
    partial class PanelQuestionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelQuestionnaire));
            btnConfirmer = new Button();
            lblCount = new Label();
            lblEnonce = new Label();
            pnlReponses = new Panel();
            SuspendLayout();
            // 
            // btnConfirmer
            // 
            btnConfirmer.BackColor = Color.Transparent;
            btnConfirmer.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmer.Location = new Point(285, 539);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(196, 46);
            btnConfirmer.TabIndex = 2;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = false;
            btnConfirmer.Click += btnConfirmer_Click_1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(956, 356);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(12, 15);
            lblCount.TabIndex = 3;
            lblCount.Text = "*";
            // 
            // lblEnonce
            // 
            lblEnonce.AutoSize = true;
            lblEnonce.Location = new Point(902, 72);
            lblEnonce.Name = "lblEnonce";
            lblEnonce.Size = new Size(12, 15);
            lblEnonce.TabIndex = 4;
            lblEnonce.Text = "*";
            // 
            // pnlReponses
            // 
            pnlReponses.Location = new Point(12, 35);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new Size(637, 407);
            pnlReponses.TabIndex = 5;
            // 
            // PanelQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1279, 610);
            Controls.Add(pnlReponses);
            Controls.Add(lblEnonce);
            Controls.Add(lblCount);
            Controls.Add(btnConfirmer);
            Name = "PanelQuestionnaire";
            Text = "PanelQuestionnaire";
            Load += PanelQuestionnaire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmer;
        private Label lblCount;
        private Label lblEnonce;
        private Panel pnlReponses;
    }
}