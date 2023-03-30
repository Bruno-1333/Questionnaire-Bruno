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
            groupBox3 = new GroupBox();
            radioBtnReponseFaux = new RadioButton();
            radioBtnReponseVrai = new RadioButton();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnQuestionSelectMult = new RadioButton();
            radioBtnQuestionVraiFaux = new RadioButton();
            txtIdModiierQuestion = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(837, 951);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(178, 34);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(495, 951);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(178, 34);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdModiierQuestion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEnonce);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(118, 36);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1299, 907);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modifier Question";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioBtnReponseFaux);
            groupBox3.Controls.Add(radioBtnReponseVrai);
            groupBox3.Location = new Point(34, 628);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(316, 107);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // radioBtnReponseFaux
            // 
            radioBtnReponseFaux.AutoSize = true;
            radioBtnReponseFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnReponseFaux.Location = new Point(171, 47);
            radioBtnReponseFaux.Margin = new Padding(4, 5, 4, 5);
            radioBtnReponseFaux.Name = "radioBtnReponseFaux";
            radioBtnReponseFaux.Size = new Size(103, 37);
            radioBtnReponseFaux.TabIndex = 1;
            radioBtnReponseFaux.TabStop = true;
            radioBtnReponseFaux.Text = "Faux";
            radioBtnReponseFaux.UseVisualStyleBackColor = true;
            // 
            // radioBtnReponseVrai
            // 
            radioBtnReponseVrai.AutoSize = true;
            radioBtnReponseVrai.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnReponseVrai.Location = new Point(22, 47);
            radioBtnReponseVrai.Margin = new Padding(4, 5, 4, 5);
            radioBtnReponseVrai.Name = "radioBtnReponseVrai";
            radioBtnReponseVrai.Size = new Size(91, 37);
            radioBtnReponseVrai.TabIndex = 0;
            radioBtnReponseVrai.TabStop = true;
            radioBtnReponseVrai.Text = "Vrai";
            radioBtnReponseVrai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 589);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 33);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(150, 333);
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
            label1.Location = new Point(35, 434);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 33);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnQuestionSelectMult);
            groupBox2.Controls.Add(radioBtnQuestionVraiFaux);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(34, 160);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1191, 146);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelectMult
            // 
            radioBtnQuestionSelectMult.AutoSize = true;
            radioBtnQuestionSelectMult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionSelectMult.Location = new Point(645, 70);
            radioBtnQuestionSelectMult.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionSelectMult.Name = "radioBtnQuestionSelectMult";
            radioBtnQuestionSelectMult.Size = new Size(438, 37);
            radioBtnQuestionSelectMult.TabIndex = 1;
            radioBtnQuestionSelectMult.TabStop = true;
            radioBtnQuestionSelectMult.Text = "Questions Selections Multiples";
            radioBtnQuestionSelectMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnQuestionVraiFaux
            // 
            radioBtnQuestionVraiFaux.AutoSize = true;
            radioBtnQuestionVraiFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionVraiFaux.Location = new Point(335, 70);
            radioBtnQuestionVraiFaux.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionVraiFaux.Name = "radioBtnQuestionVraiFaux";
            radioBtnQuestionVraiFaux.Size = new Size(287, 37);
            radioBtnQuestionVraiFaux.TabIndex = 0;
            radioBtnQuestionVraiFaux.TabStop = true;
            radioBtnQuestionVraiFaux.Text = "Question Vrai/Faux";
            radioBtnQuestionVraiFaux.UseVisualStyleBackColor = true;
            // 
            // txtIdModiierQuestion
            // 
            txtIdModiierQuestion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdModiierQuestion.Location = new Point(386, 104);
            txtIdModiierQuestion.Margin = new Padding(4, 5, 4, 5);
            txtIdModiierQuestion.Name = "txtIdModiierQuestion";
            txtIdModiierQuestion.Size = new Size(270, 28);
            txtIdModiierQuestion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(312, 32);
            label3.TabIndex = 5;
            label3.Text = "Saisir l'ID de la question";
            // 
            // ModifierQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAnnuler);
            Controls.Add(btnModifier);
            Controls.Add(groupBox1);
            Name = "ModifierQuestion";
            Size = new Size(1534, 1020);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnnuler;
        private Button btnModifier;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton radioBtnReponseFaux;
        private RadioButton radioBtnReponseVrai;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnQuestionSelectMult;
        private RadioButton radioBtnQuestionVraiFaux;
        private TextBox txtIdModiierQuestion;
        private Label label3;
    }
}
