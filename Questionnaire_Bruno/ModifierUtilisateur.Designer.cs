namespace Questionnaire_Bruno
{
    partial class ModifierUtilisateur
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
            dataGridView1 = new DataGridView();
            btnModifierUtilisateur = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1143, 281);
            dataGridView1.TabIndex = 0;
            // 
            // btnModifierUtilisateur
            // 
            btnModifierUtilisateur.Location = new Point(446, 293);
            btnModifierUtilisateur.Name = "btnModifierUtilisateur";
            btnModifierUtilisateur.Size = new Size(228, 62);
            btnModifierUtilisateur.TabIndex = 1;
            btnModifierUtilisateur.Text = "Modifier";
            btnModifierUtilisateur.UseVisualStyleBackColor = true;
            btnModifierUtilisateur.Click += btnModifierUtilisateur_Click;
            // 
            // ModifierUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnModifierUtilisateur);
            Controls.Add(dataGridView1);
            Name = "ModifierUtilisateur";
            Size = new Size(1151, 518);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnModifierUtilisateur;
    }
}
