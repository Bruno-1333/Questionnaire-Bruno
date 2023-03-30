namespace Questionnaire_Bruno
{
    partial class ConsulterQuestions
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
            btnConsulter = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioBtnQuestionSelectMult = new RadioButton();
            radioBtnQuestionFraiFaux = new RadioButton();
            dataGridConsulterQuestions = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsulterQuestions).BeginInit();
            SuspendLayout();
            // 
            // btnConsulter
            // 
            btnConsulter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulter.Location = new Point(577, 236);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(178, 34);
            btnConsulter.TabIndex = 7;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridConsulterQuestions);
            groupBox1.Controls.Add(btnConsulter);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1371, 962);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulter Questions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnQuestionSelectMult);
            groupBox2.Controls.Add(radioBtnQuestionFraiFaux);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 72);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1295, 146);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelectMult
            // 
            radioBtnQuestionSelectMult.AutoSize = true;
            radioBtnQuestionSelectMult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionSelectMult.Location = new Point(646, 72);
            radioBtnQuestionSelectMult.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionSelectMult.Name = "radioBtnQuestionSelectMult";
            radioBtnQuestionSelectMult.Size = new Size(438, 37);
            radioBtnQuestionSelectMult.TabIndex = 1;
            radioBtnQuestionSelectMult.TabStop = true;
            radioBtnQuestionSelectMult.Text = "Questions Selections Multiples";
            radioBtnQuestionSelectMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnQuestionFraiFaux
            // 
            radioBtnQuestionFraiFaux.AutoSize = true;
            radioBtnQuestionFraiFaux.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionFraiFaux.Location = new Point(336, 72);
            radioBtnQuestionFraiFaux.Margin = new Padding(4, 5, 4, 5);
            radioBtnQuestionFraiFaux.Name = "radioBtnQuestionFraiFaux";
            radioBtnQuestionFraiFaux.Size = new Size(287, 37);
            radioBtnQuestionFraiFaux.TabIndex = 0;
            radioBtnQuestionFraiFaux.TabStop = true;
            radioBtnQuestionFraiFaux.Text = "Question Vrai/Faux";
            radioBtnQuestionFraiFaux.UseVisualStyleBackColor = true;
            // 
            // dataGridConsulterQuestions
            // 
            dataGridConsulterQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsulterQuestions.Location = new Point(26, 294);
            dataGridConsulterQuestions.Name = "dataGridConsulterQuestions";
            dataGridConsulterQuestions.RowHeadersWidth = 62;
            dataGridConsulterQuestions.RowTemplate.Height = 33;
            dataGridConsulterQuestions.Size = new Size(1295, 411);
            dataGridConsulterQuestions.TabIndex = 9;
            // 
            // ConsulterQuestions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ConsulterQuestions";
            Size = new Size(1371, 962);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsulterQuestions).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnConsulter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioBtnQuestionSelectMult;
        private RadioButton radioBtnQuestionFraiFaux;
        private DataGridView dataGridConsulterQuestions;
    }
}
