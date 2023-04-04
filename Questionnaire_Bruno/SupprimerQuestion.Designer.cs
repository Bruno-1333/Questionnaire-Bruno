namespace Questionnaire_Bruno
{
    partial class SupprimerQuestion
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
            groupBox2 = new GroupBox();
            btnSupprimerQuestion = new Button();
            txtIdSupprimerQuestion = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(774, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SUPPRIMER UN QUESTION";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSupprimerQuestion);
            groupBox2.Controls.Add(txtIdSupprimerQuestion);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(27, 78);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(660, 257);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnSupprimerQuestion
            // 
            btnSupprimerQuestion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimerQuestion.Location = new Point(239, 145);
            btnSupprimerQuestion.Margin = new Padding(4, 5, 4, 5);
            btnSupprimerQuestion.Name = "btnSupprimerQuestion";
            btnSupprimerQuestion.Size = new Size(167, 68);
            btnSupprimerQuestion.TabIndex = 2;
            btnSupprimerQuestion.Text = "Supprimer";
            btnSupprimerQuestion.UseVisualStyleBackColor = true;
            btnSupprimerQuestion.Click += btnSupprimerQuestion_Click;
            // 
            // txtIdSupprimerQuestion
            // 
            txtIdSupprimerQuestion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdSupprimerQuestion.Location = new Point(307, 72);
            txtIdSupprimerQuestion.Margin = new Padding(4, 5, 4, 5);
            txtIdSupprimerQuestion.Name = "txtIdSupprimerQuestion";
            txtIdSupprimerQuestion.Size = new Size(270, 28);
            txtIdSupprimerQuestion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 27);
            label1.TabIndex = 0;
            label1.Text = "Saisir l'ID de la question";
            // 
            // SupprimerQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SupprimerQuestion";
            Size = new Size(774, 438);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSupprimerQuestion;
        private TextBox txtIdSupprimerQuestion;
        private Label label1;
    }
}
