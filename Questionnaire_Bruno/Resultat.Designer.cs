namespace Questionnaire_Bruno
{
    partial class Resultat
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
            dataGridResultatQuestions = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridResultatQuestions).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridResultatQuestions
            // 
            dataGridResultatQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultatQuestions.Location = new Point(18, 93);
            dataGridResultatQuestions.Margin = new Padding(2);
            dataGridResultatQuestions.Name = "dataGridResultatQuestions";
            dataGridResultatQuestions.RowHeadersWidth = 62;
            dataGridResultatQuestions.RowTemplate.Height = 33;
            dataGridResultatQuestions.Size = new Size(1023, 505);
            dataGridResultatQuestions.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridResultatQuestions);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 696);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulter Questions";
            // 
            // Resultat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Resultat";
            Size = new Size(1103, 696);
            ((System.ComponentModel.ISupportInitialize)dataGridResultatQuestions).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridResultatQuestions;
        private GroupBox groupBox1;
    }
}
