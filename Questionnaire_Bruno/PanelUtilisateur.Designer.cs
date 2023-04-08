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
            pnlMaster = new Panel();
            btnRegle = new Button();
            btnCommencer = new Button();
            btnConfirmer = new Button();
            SuspendLayout();
            // 
            // pnlMaster
            // 
            pnlMaster.BackColor = Color.Transparent;
            pnlMaster.Location = new Point(0, 0);
            pnlMaster.Name = "pnlMaster";
            pnlMaster.Size = new Size(756, 512);
            pnlMaster.TabIndex = 0;
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
            // 
            // btnConfirmer
            // 
            btnConfirmer.BackColor = Color.Transparent;
            btnConfirmer.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmer.Location = new Point(483, 541);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(196, 46);
            btnConfirmer.TabIndex = 3;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = false;
            // 
            // PanelUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 611);
            Controls.Add(btnConfirmer);
            Controls.Add(btnCommencer);
            Controls.Add(btnRegle);
            Controls.Add(pnlMaster);
            Name = "PanelUtilisateur";
            Text = "PanelUtilisateur";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMaster;
        private Button btnRegle;
        private Button btnCommencer;
        private Button btnConfirmer;
    }
}