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
            dataGridConsulterQuestions = new DataGridView();
            groupBox2 = new GroupBox();
            checkVraiFaux = new CheckBox();
            checkSelecMult = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsulterQuestions).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsulter
            // 
            btnConsulter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulter.Location = new Point(404, 136);
            btnConsulter.Margin = new Padding(2);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(125, 30);
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
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 577);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulter Questions";
            // 
            // dataGridConsulterQuestions
            // 
            dataGridConsulterQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsulterQuestions.Location = new Point(18, 176);
            dataGridConsulterQuestions.Margin = new Padding(2);
            dataGridConsulterQuestions.Name = "dataGridConsulterQuestions";
            dataGridConsulterQuestions.RowHeadersWidth = 62;
            dataGridConsulterQuestions.RowTemplate.Height = 33;
            dataGridConsulterQuestions.Size = new Size(906, 247);
            dataGridConsulterQuestions.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkSelecMult);
            groupBox2.Controls.Add(checkVraiFaux);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(906, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // checkVraiFaux
            // 
            checkVraiFaux.AutoSize = true;
            checkVraiFaux.Location = new Point(197, 43);
            checkVraiFaux.Name = "checkVraiFaux";
            checkVraiFaux.Size = new Size(177, 22);
            checkVraiFaux.TabIndex = 0;
            checkVraiFaux.Text = "Question Vrai/Faux";
            checkVraiFaux.UseVisualStyleBackColor = true;
            // 
            // checkSelecMult
            // 
            checkSelecMult.AutoSize = true;
            checkSelecMult.Location = new Point(496, 43);
            checkSelecMult.Name = "checkSelecMult";
            checkSelecMult.Size = new Size(243, 22);
            checkSelecMult.TabIndex = 1;
            checkSelecMult.Text = "Question Selection Multiple";
            checkSelecMult.UseVisualStyleBackColor = true;
            // 
            // ConsulterQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "ConsulterQuestions";
            Size = new Size(960, 577);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridConsulterQuestions).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnConsulter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridConsulterQuestions;
        private CheckBox checkSelecMult;
        private CheckBox checkVraiFaux;
    }
}
