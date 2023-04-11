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
            pictureGagne = new PictureBox();
            picturePasGagne = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureGagne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePasGagne).BeginInit();
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
            lblEnonce.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnonce.Location = new Point(1008, 110);
            lblEnonce.Name = "lblEnonce";
            lblEnonce.Size = new Size(37, 15);
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
            // pictureGagne
            // 
            pictureGagne.BackgroundImage = (Image)resources.GetObject("pictureGagne.BackgroundImage");
            pictureGagne.BackgroundImageLayout = ImageLayout.Stretch;
            pictureGagne.Location = new Point(777, 141);
            pictureGagne.Name = "pictureGagne";
            pictureGagne.Size = new Size(466, 315);
            pictureGagne.TabIndex = 0;
            pictureGagne.TabStop = false;
            pictureGagne.Visible = false;
            // 
            // picturePasGagne
            // 
            picturePasGagne.BackgroundImage = (Image)resources.GetObject("picturePasGagne.BackgroundImage");
            picturePasGagne.BackgroundImageLayout = ImageLayout.Stretch;
            picturePasGagne.Location = new Point(777, 141);
            picturePasGagne.Name = "picturePasGagne";
            picturePasGagne.Size = new Size(466, 315);
            picturePasGagne.TabIndex = 6;
            picturePasGagne.TabStop = false;
            picturePasGagne.Visible = false;
            // 
            // PanelQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1279, 610);
            Controls.Add(picturePasGagne);
            Controls.Add(pictureGagne);
            Controls.Add(lblEnonce);
            Controls.Add(pnlReponseQuestion);
            Controls.Add(btnConfirmer);
            DoubleBuffered = true;
            Name = "PanelQuestionnaire";
            Text = "PanelQuestionnaire";
            Load += PanelQuestionnaire_Load;
            ((System.ComponentModel.ISupportInitialize)pictureGagne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePasGagne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmer;
        private Label lblEnonce;
        private Panel pnlReponseQuestion;
        private PictureBox pictureGagne;
        private PictureBox picturePasGagne;
    }
}