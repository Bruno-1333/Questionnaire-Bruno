namespace Questionnaire_Bruno
{
    partial class SupprimerUtilisateur
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
            dataGridSupprimerUtilisateur = new DataGridView();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSupprimerUtilisateur).BeginInit();
            SuspendLayout();
            // 
            // dataGridSupprimerUtilisateur
            // 
            dataGridSupprimerUtilisateur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupprimerUtilisateur.Location = new Point(4, 40);
            dataGridSupprimerUtilisateur.Margin = new Padding(4, 5, 4, 5);
            dataGridSupprimerUtilisateur.Name = "dataGridSupprimerUtilisateur";
            dataGridSupprimerUtilisateur.RowHeadersWidth = 62;
            dataGridSupprimerUtilisateur.RowTemplate.Height = 25;
            dataGridSupprimerUtilisateur.Size = new Size(1596, 490);
            dataGridSupprimerUtilisateur.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(594, 572);
            btnSupprimer.Margin = new Padding(4, 5, 4, 5);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(380, 102);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // SupprimerUtilisateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridSupprimerUtilisateur);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SupprimerUtilisateur";
            Size = new Size(1621, 760);
            Load += SupprimerUtilisateur_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSupprimerUtilisateur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSupprimerUtilisateur;
        private Button btnSupprimer;
    }
}
