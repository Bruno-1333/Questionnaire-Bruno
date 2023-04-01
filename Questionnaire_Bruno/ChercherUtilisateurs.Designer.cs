namespace Questionnaire_Bruno
{
    partial class ChercherUtilisateurs
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
            dataGridChercherUtilisateur = new DataGridView();
            groupBox2 = new GroupBox();
            btnChercher = new Button();
            txtTelephone = new TextBox();
            txtVille = new TextBox();
            txtProvince = new TextBox();
            txtCodePostal = new TextBox();
            checTelephone = new CheckBox();
            checkVille = new CheckBox();
            checkProvince = new CheckBox();
            checkCodePostal = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridChercherUtilisateur).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridChercherUtilisateur);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1072, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHERCHER DES UTILISATEURS";
            // 
            // dataGridChercherUtilisateur
            // 
            dataGridChercherUtilisateur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChercherUtilisateur.Location = new Point(22, 295);
            dataGridChercherUtilisateur.Name = "dataGridChercherUtilisateur";
            dataGridChercherUtilisateur.RowTemplate.Height = 25;
            dataGridChercherUtilisateur.Size = new Size(995, 278);
            dataGridChercherUtilisateur.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChercher);
            groupBox2.Controls.Add(txtTelephone);
            groupBox2.Controls.Add(txtVille);
            groupBox2.Controls.Add(txtProvince);
            groupBox2.Controls.Add(txtCodePostal);
            groupBox2.Controls.Add(checTelephone);
            groupBox2.Controls.Add(checkVille);
            groupBox2.Controls.Add(checkProvince);
            groupBox2.Controls.Add(checkCodePostal);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(21, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(996, 215);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir un/des critères de recherche";
            // 
            // btnChercher
            // 
            btnChercher.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChercher.Location = new Point(377, 177);
            btnChercher.Name = "btnChercher";
            btnChercher.Size = new Size(211, 32);
            btnChercher.TabIndex = 8;
            btnChercher.Text = "Chercher";
            btnChercher.UseVisualStyleBackColor = true;
            btnChercher.Click += btnChercher_Click;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(662, 130);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(235, 26);
            txtTelephone.TabIndex = 7;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(662, 45);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(235, 26);
            txtVille.TabIndex = 6;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(170, 130);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(235, 26);
            txtProvince.TabIndex = 5;
            // 
            // txtCodePostal
            // 
            txtCodePostal.Location = new Point(170, 45);
            txtCodePostal.Name = "txtCodePostal";
            txtCodePostal.Size = new Size(235, 26);
            txtCodePostal.TabIndex = 4;
            // 
            // checTelephone
            // 
            checTelephone.AutoSize = true;
            checTelephone.Location = new Point(519, 134);
            checTelephone.Name = "checTelephone";
            checTelephone.Size = new Size(111, 22);
            checTelephone.TabIndex = 3;
            checTelephone.Text = "Téléphone";
            checTelephone.UseVisualStyleBackColor = true;
            // 
            // checkVille
            // 
            checkVille.AutoSize = true;
            checkVille.Location = new Point(519, 49);
            checkVille.Name = "checkVille";
            checkVille.Size = new Size(60, 22);
            checkVille.TabIndex = 2;
            checkVille.Text = "Ville";
            checkVille.UseVisualStyleBackColor = true;
            // 
            // checkProvince
            // 
            checkProvince.AutoSize = true;
            checkProvince.Location = new Point(38, 134);
            checkProvince.Name = "checkProvince";
            checkProvince.Size = new Size(98, 22);
            checkProvince.TabIndex = 1;
            checkProvince.Text = "Province";
            checkProvince.UseVisualStyleBackColor = true;
            // 
            // checkCodePostal
            // 
            checkCodePostal.AutoSize = true;
            checkCodePostal.Location = new Point(38, 49);
            checkCodePostal.Name = "checkCodePostal";
            checkCodePostal.Size = new Size(123, 22);
            checkCodePostal.TabIndex = 0;
            checkCodePostal.Text = "Code Postal";
            checkCodePostal.UseVisualStyleBackColor = true;
            // 
            // ChercherUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ChercherUtilisateurs";
            Size = new Size(1072, 633);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridChercherUtilisateur).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridChercherUtilisateur;
        private GroupBox groupBox2;
        private Button btnChercher;
        private TextBox txtTelephone;
        private TextBox txtVille;
        private TextBox txtProvince;
        private TextBox txtCodePostal;
        private CheckBox checTelephone;
        private CheckBox checkVille;
        private CheckBox checkProvince;
        private CheckBox checkCodePostal;
    }
}
