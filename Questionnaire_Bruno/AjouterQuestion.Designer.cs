namespace Questionnaire_Bruno
{
    partial class AjouterQuestion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBonneReponse = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnonce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnQuestionSelecMult = new System.Windows.Forms.RadioButton();
            this.radioBtnQuestionVraiFaux = new System.Windows.Forms.RadioButton();
            this.BtnAjouterQuestions = new System.Windows.Forms.Button();
            this.BtnAnnulerQuestions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlBonneReponse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEnonce);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Question";
            // 
            // pnlBonneReponse
            // 
            this.pnlBonneReponse.Location = new System.Drawing.Point(24, 348);
            this.pnlBonneReponse.Name = "pnlBonneReponse";
            this.pnlBonneReponse.Size = new System.Drawing.Size(945, 215);
            this.pnlBonneReponse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            this.txtEnonce.Location = new System.Drawing.Point(106, 164);
            this.txtEnonce.Multiline = true;
            this.txtEnonce.Name = "txtEnonce";
            this.txtEnonce.Size = new System.Drawing.Size(753, 141);
            this.txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnQuestionSelecMult);
            this.groupBox2.Controls.Add(this.radioBtnQuestionVraiFaux);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(24, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 94);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelecMult
            // 
            this.radioBtnQuestionSelecMult.AutoSize = true;
            this.radioBtnQuestionSelecMult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnQuestionSelecMult.Location = new System.Drawing.Point(451, 41);
            this.radioBtnQuestionSelecMult.Name = "radioBtnQuestionSelecMult";
            this.radioBtnQuestionSelecMult.Size = new System.Drawing.Size(287, 26);
            this.radioBtnQuestionSelecMult.TabIndex = 1;
            this.radioBtnQuestionSelecMult.TabStop = true;
            this.radioBtnQuestionSelecMult.Text = "Questions Selections Multiples";
            this.radioBtnQuestionSelecMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnQuestionVraiFaux
            // 
            this.radioBtnQuestionVraiFaux.AutoSize = true;
            this.radioBtnQuestionVraiFaux.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnQuestionVraiFaux.Location = new System.Drawing.Point(234, 41);
            this.radioBtnQuestionVraiFaux.Name = "radioBtnQuestionVraiFaux";
            this.radioBtnQuestionVraiFaux.Size = new System.Drawing.Size(187, 26);
            this.radioBtnQuestionVraiFaux.TabIndex = 0;
            this.radioBtnQuestionVraiFaux.TabStop = true;
            this.radioBtnQuestionVraiFaux.Text = "Question Vrai/Faux";
            this.radioBtnQuestionVraiFaux.UseVisualStyleBackColor = true;
            // 
            // BtnAjouterQuestions
            // 
            this.BtnAjouterQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAjouterQuestions.Location = new System.Drawing.Point(274, 609);
            this.BtnAjouterQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAjouterQuestions.Name = "BtnAjouterQuestions";
            this.BtnAjouterQuestions.Size = new System.Drawing.Size(125, 26);
            this.BtnAjouterQuestions.TabIndex = 1;
            this.BtnAjouterQuestions.Text = "Ajouter";
            this.BtnAjouterQuestions.UseVisualStyleBackColor = true;
            // 
            // BtnAnnulerQuestions
            // 
            this.BtnAnnulerQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnnulerQuestions.Location = new System.Drawing.Point(521, 609);
            this.BtnAnnulerQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnnulerQuestions.Name = "BtnAnnulerQuestions";
            this.BtnAnnulerQuestions.Size = new System.Drawing.Size(125, 26);
            this.BtnAnnulerQuestions.TabIndex = 2;
            this.BtnAnnulerQuestions.Text = "Annuler";
            this.BtnAnnulerQuestions.UseVisualStyleBackColor = true;
            // 
            // AjouterQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAnnulerQuestions);
            this.Controls.Add(this.BtnAjouterQuestions);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterQuestion";
            this.Size = new System.Drawing.Size(1079, 704);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnQuestionSelecMult;
        private RadioButton radioBtnQuestionVraiFaux;
        private Button BtnAjouterQuestions;
        private Button BtnAnnulerQuestions;
        private Panel pnlBonneReponse;
    }
}
