namespace Questionnaire_Bruno
{
    partial class ModifierQuestion
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
            btnAnnuler = new Button();
            btnModifier = new Button();
            groupBox1 = new GroupBox();
            txtIdModiierQuestion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnQuestionSelectMult = new RadioButton();
            radioBtnQuestionVraiFaux = new RadioButton();
            btnChercher = new Button();
            pnlReponses = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnnuler.Location = new Point(586, 571);
            btnAnnuler.Margin = new Padding(2, 2, 2, 2);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(125, 26);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(346, 571);
            btnModifier.Margin = new Padding(2, 2, 2, 2);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(125, 26);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChercher);
            groupBox1.Controls.Add(txtIdModiierQuestion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEnonce);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pnlReponses);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(83, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 544);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modifier Question";
            // 
            // txtIdModiierQuestion
            // 
            txtIdModiierQuestion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdModiierQuestion.Location = new Point(270, 62);
            txtIdModiierQuestion.Name = "txtIdModiierQuestion";
            txtIdModiierQuestion.Size = new Size(190, 21);
            txtIdModiierQuestion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(213, 22);
            label3.TabIndex = 5;
            label3.Text = "Saisir l'ID de la question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 353);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(105, 200);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(753, 141);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 260);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnQuestionSelectMult);
            groupBox2.Controls.Add(radioBtnQuestionVraiFaux);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelectMult
            // 
            radioBtnQuestionSelectMult.AutoSize = true;
            radioBtnQuestionSelectMult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionSelectMult.Location = new Point(452, 42);
            radioBtnQuestionSelectMult.Name = "radioBtnQuestionSelectMult";
            radioBtnQuestionSelectMult.Size = new Size(287, 26);
            radioBtnQuestionSelectMult.TabIndex = 1;
            radioBtnQuestionSelectMult.TabStop = true;
            radioBtnQuestionSelectMult.Text = "Questions Selections Multiples";
            radioBtnQuestionSelectMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnQuestionVraiFaux
            // 
            radioBtnQuestionVraiFaux.AutoSize = true;
            radioBtnQuestionVraiFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionVraiFaux.Location = new Point(234, 42);
            radioBtnQuestionVraiFaux.Name = "radioBtnQuestionVraiFaux";
            radioBtnQuestionVraiFaux.Size = new Size(187, 26);
            radioBtnQuestionVraiFaux.TabIndex = 0;
            radioBtnQuestionVraiFaux.TabStop = true;
            radioBtnQuestionVraiFaux.Text = "Question Vrai/Faux";
            radioBtnQuestionVraiFaux.UseVisualStyleBackColor = true;
            radioBtnQuestionVraiFaux.CheckedChanged += radioBtnQuestionVraiFaux_CheckedChanged;
            // 
            // btnChercher
            // 
            btnChercher.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChercher.Location = new Point(503, 62);
            btnChercher.Margin = new Padding(2);
            btnChercher.Name = "btnChercher";
            btnChercher.Size = new Size(125, 26);
            btnChercher.TabIndex = 7;
            btnChercher.Text = "Modifier";
            btnChercher.UseVisualStyleBackColor = true;
            // 
            // pnlReponses
            // 
            pnlReponses.Location = new Point(30, 385);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new Size(860, 153);
            pnlReponses.TabIndex = 8;
            // 
            // ModifierQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAnnuler);
            Controls.Add(btnModifier);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ModifierQuestion";
            Size = new Size(1074, 612);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnnuler;
        private Button btnModifier;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnQuestionSelectMult;
        private RadioButton radioBtnQuestionVraiFaux;
        private TextBox txtIdModiierQuestion;
        private Label label3;
        private Button btnChercher;
        private Panel pnlReponses;
    }
}
