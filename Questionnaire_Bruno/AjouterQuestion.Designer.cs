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
            groupBox1 = new GroupBox();
            pnlBonneReponse = new Panel();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnQuestionSelecMult = new RadioButton();
            radioBtnQuestionVraiFaux = new RadioButton();
            BtnAjouterQuestions = new Button();
            BtnAnnulerQuestions = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlBonneReponse);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEnonce);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 27);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1433, 948);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter Question";
            // 
            // pnlBonneReponse
            // 
            pnlBonneReponse.Location = new Point(34, 580);
            pnlBonneReponse.Margin = new Padding(4, 5, 4, 5);
            pnlBonneReponse.Name = "pnlBonneReponse";
            pnlBonneReponse.Size = new Size(1350, 358);
            pnlBonneReponse.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 512);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 33);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(151, 273);
            txtEnonce.Margin = new Padding(4, 5, 4, 5);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(1074, 232);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 373);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 33);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnQuestionSelecMult);
            groupBox2.Controls.Add(radioBtnQuestionVraiFaux);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(34, 107);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1191, 157);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelecMult
            // 
            radioBtnQuestionSelecMult.AutoSize = true;
            radioBtnQuestionSelecMult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionSelecMult.Location = new Point(644, 68);
            radioBtnQuestionSelecMult.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionSelecMult.Name = "radioBtnQuestionSelecMult";
            radioBtnQuestionSelecMult.Size = new Size(438, 37);
            radioBtnQuestionSelecMult.TabIndex = 1;
            radioBtnQuestionSelecMult.TabStop = true;
            radioBtnQuestionSelecMult.Text = "Questions Selections Multiples";
            radioBtnQuestionSelecMult.UseVisualStyleBackColor = true;
            radioBtnQuestionSelecMult.CheckedChanged += radioBtnQuestionSelecMult_CheckedChanged;
            // 
            // radioBtnQuestionVraiFaux
            // 
            radioBtnQuestionVraiFaux.AutoSize = true;
            radioBtnQuestionVraiFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionVraiFaux.Location = new Point(334, 68);
            radioBtnQuestionVraiFaux.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionVraiFaux.Name = "radioBtnQuestionVraiFaux";
            radioBtnQuestionVraiFaux.Size = new Size(287, 37);
            radioBtnQuestionVraiFaux.TabIndex = 0;
            radioBtnQuestionVraiFaux.TabStop = true;
            radioBtnQuestionVraiFaux.Text = "Question Vrai/Faux";
            radioBtnQuestionVraiFaux.UseVisualStyleBackColor = true;
            radioBtnQuestionVraiFaux.CheckedChanged += radioBtnQuestionVraiFaux_CheckedChanged;
            // 
            // BtnAjouterQuestions
            // 
            BtnAjouterQuestions.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAjouterQuestions.Location = new Point(391, 1015);
            BtnAjouterQuestions.Name = "BtnAjouterQuestions";
            BtnAjouterQuestions.Size = new Size(179, 43);
            BtnAjouterQuestions.TabIndex = 1;
            BtnAjouterQuestions.Text = "Ajouter";
            BtnAjouterQuestions.UseVisualStyleBackColor = true;
            BtnAjouterQuestions.Click += BtnAjouterQuestions_Click;
            // 
            // BtnAnnulerQuestions
            // 
            BtnAnnulerQuestions.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnnulerQuestions.Location = new Point(744, 1015);
            BtnAnnulerQuestions.Name = "BtnAnnulerQuestions";
            BtnAnnulerQuestions.Size = new Size(179, 43);
            BtnAnnulerQuestions.TabIndex = 2;
            BtnAnnulerQuestions.Text = "Annuler";
            BtnAnnulerQuestions.UseVisualStyleBackColor = true;
            BtnAnnulerQuestions.Click += BtnAnnulerQuestions_Click;
            // 
            // AjouterQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnAnnulerQuestions);
            Controls.Add(BtnAjouterQuestions);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AjouterQuestion";
            Size = new Size(1541, 1173);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
