namespace Questionnaire_Bruno
{
    partial class ReponseVraiFaux
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReponseVraiFaux));
            groupBox3 = new GroupBox();
            radioBtnReponseFaux = new RadioButton();
            radioBtnReponseVrai = new RadioButton();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Location = new Point(-9, -8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(588, 390);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // radioBtnReponseFaux
            // 
            radioBtnReponseFaux.AutoSize = true;
            radioBtnReponseFaux.BackColor = Color.Transparent;
            radioBtnReponseFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnReponseFaux.ForeColor = Color.Red;
            radioBtnReponseFaux.Location = new Point(373, 344);
            radioBtnReponseFaux.Name = "radioBtnReponseFaux";
            radioBtnReponseFaux.Size = new Size(69, 26);
            radioBtnReponseFaux.TabIndex = 1;
            radioBtnReponseFaux.TabStop = true;
            radioBtnReponseFaux.Text = "Faux";
            radioBtnReponseFaux.UseVisualStyleBackColor = false;
            // 
            // radioBtnReponseVrai
            // 
            radioBtnReponseVrai.AutoSize = true;
            radioBtnReponseVrai.BackColor = Color.Transparent;
            radioBtnReponseVrai.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnReponseVrai.ForeColor = Color.Red;
            radioBtnReponseVrai.Location = new Point(171, 344);
            radioBtnReponseVrai.Name = "radioBtnReponseVrai";
            radioBtnReponseVrai.Size = new Size(60, 26);
            radioBtnReponseVrai.TabIndex = 0;
            radioBtnReponseVrai.TabStop = true;
            radioBtnReponseVrai.Text = "Vrai";
            radioBtnReponseVrai.UseVisualStyleBackColor = false;
            // 
            // ReponseVraiFaux
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(radioBtnReponseFaux);
            Controls.Add(radioBtnReponseVrai);
            Controls.Add(groupBox3);
            DoubleBuffered = true;
            Name = "ReponseVraiFaux";
            Size = new Size(567, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private RadioButton radioBtnReponseFaux;
        private RadioButton radioBtnReponseVrai;
    }
}
