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
            lblEnonce = new Label();
            pnlReponseQuestion = new Panel();
            label1 = new Label();
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
            // lblEnonce
            // 
            lblEnonce.AutoSize = true;
            lblEnonce.BackColor = Color.Transparent;
            lblEnonce.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnonce.Location = new Point(1009, 79);
            lblEnonce.Name = "lblEnonce";
            lblEnonce.Size = new Size(102, 42);
            lblEnonce.TabIndex = 4;
            lblEnonce.Text = "******";
            // 
            // pnlReponseQuestion
            // 
            pnlReponseQuestion.BackColor = Color.Transparent;
            pnlReponseQuestion.Location = new Point(-1, 0);
            pnlReponseQuestion.Name = "pnlReponseQuestion";
            pnlReponseQuestion.Size = new Size(693, 479);
            pnlReponseQuestion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(935, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 52);
            label1.TabIndex = 7;
            label1.Text = "QUESTION";
            // 
            // PanelQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1279, 610);
            Controls.Add(label1);
            Controls.Add(lblEnonce);
            Controls.Add(pnlReponseQuestion);
            Controls.Add(btnConfirmer);
            DoubleBuffered = true;
            Name = "PanelQuestionnaire";
            Text = "PanelQuestionnaire";
            Load += PanelQuestionnaire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmer;
        private Label lblEnonce;
        private Panel pnlReponseQuestion;
        private Label label1;
    }
}