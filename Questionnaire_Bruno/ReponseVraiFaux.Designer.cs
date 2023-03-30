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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnReponseFaux = new System.Windows.Forms.RadioButton();
            this.radioBtnReponseVrai = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnReponseFaux);
            this.groupBox3.Controls.Add(this.radioBtnReponseVrai);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // radioBtnReponseFaux
            // 
            this.radioBtnReponseFaux.AutoSize = true;
            this.radioBtnReponseFaux.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnReponseFaux.Location = new System.Drawing.Point(119, 27);
            this.radioBtnReponseFaux.Name = "radioBtnReponseFaux";
            this.radioBtnReponseFaux.Size = new System.Drawing.Size(69, 26);
            this.radioBtnReponseFaux.TabIndex = 1;
            this.radioBtnReponseFaux.TabStop = true;
            this.radioBtnReponseFaux.Text = "Faux";
            this.radioBtnReponseFaux.UseVisualStyleBackColor = true;
            // 
            // radioBtnReponseVrai
            // 
            this.radioBtnReponseVrai.AutoSize = true;
            this.radioBtnReponseVrai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnReponseVrai.Location = new System.Drawing.Point(15, 27);
            this.radioBtnReponseVrai.Name = "radioBtnReponseVrai";
            this.radioBtnReponseVrai.Size = new System.Drawing.Size(60, 26);
            this.radioBtnReponseVrai.TabIndex = 0;
            this.radioBtnReponseVrai.TabStop = true;
            this.radioBtnReponseVrai.Text = "Vrai";
            this.radioBtnReponseVrai.UseVisualStyleBackColor = true;
            // 
            // ReponseVraiFaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "ReponseVraiFaux";
            this.Size = new System.Drawing.Size(240, 80);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private RadioButton radioBtnReponseFaux;
        private RadioButton radioBtnReponseVrai;
    }
}
