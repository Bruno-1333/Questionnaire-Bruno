namespace Questionnaire_Bruno
{
    partial class SectionAdministrateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionUserToolStripMenuItem = new ToolStripMenuItem();
            MenuAdmAjouterUtilisateur = new ToolStripMenuItem();
            MenuAdmSupprimerUtilisateur = new ToolStripMenuItem();
            MenuAdmModifierUtilisateur = new ToolStripMenuItem();
            MenuAdmAfficherUtilisateur = new ToolStripMenuItem();
            gestionQuestionToolStripMenuItem = new ToolStripMenuItem();
            MenuAdmAjouterQuestion = new ToolStripMenuItem();
            MenuAdmSupprimerQuestion = new ToolStripMenuItem();
            MenuAdmModifierQuestion = new ToolStripMenuItem();
            MenuAdmConsulterQuestion = new ToolStripMenuItem();
            resultatToolStripMenuItem = new ToolStripMenuItem();
            MenuAdmAfficherResultat = new ToolStripMenuItem();
            PannelPrincipale = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionUserToolStripMenuItem, gestionQuestionToolStripMenuItem, resultatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1060, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionUserToolStripMenuItem
            // 
            gestionUserToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuAdmAjouterUtilisateur, MenuAdmSupprimerUtilisateur, MenuAdmModifierUtilisateur, MenuAdmAfficherUtilisateur });
            gestionUserToolStripMenuItem.Name = "gestionUserToolStripMenuItem";
            gestionUserToolStripMenuItem.Size = new Size(115, 20);
            gestionUserToolStripMenuItem.Text = "Gestion Utilisateur";
            // 
            // MenuAdmAjouterUtilisateur
            // 
            MenuAdmAjouterUtilisateur.Name = "MenuAdmAjouterUtilisateur";
            MenuAdmAjouterUtilisateur.Size = new Size(185, 22);
            MenuAdmAjouterUtilisateur.Text = "Ajouter Utilisateur";
            MenuAdmAjouterUtilisateur.Click += MenuAdmAjouterUtilisateur_Click;
            // 
            // MenuAdmSupprimerUtilisateur
            // 
            MenuAdmSupprimerUtilisateur.Name = "MenuAdmSupprimerUtilisateur";
            MenuAdmSupprimerUtilisateur.Size = new Size(185, 22);
            MenuAdmSupprimerUtilisateur.Text = "Supprimer Utilisateur";
            MenuAdmSupprimerUtilisateur.Click += MenuAdmSupprimerUtilisateur_Click;
            // 
            // MenuAdmModifierUtilisateur
            // 
            MenuAdmModifierUtilisateur.Name = "MenuAdmModifierUtilisateur";
            MenuAdmModifierUtilisateur.Size = new Size(185, 22);
            MenuAdmModifierUtilisateur.Text = "Modifier Utilisateur";
            MenuAdmModifierUtilisateur.Click += MenuAdmModifierUtilisateur_Click;
            // 
            // MenuAdmAfficherUtilisateur
            // 
            MenuAdmAfficherUtilisateur.Name = "MenuAdmAfficherUtilisateur";
            MenuAdmAfficherUtilisateur.Size = new Size(185, 22);
            MenuAdmAfficherUtilisateur.Text = "Chercher Utilisateurs";
            MenuAdmAfficherUtilisateur.Click += MenuAdmAfficherUtilisateur_Click;
            // 
            // gestionQuestionToolStripMenuItem
            // 
            gestionQuestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuAdmAjouterQuestion, MenuAdmSupprimerQuestion, MenuAdmModifierQuestion, MenuAdmConsulterQuestion });
            gestionQuestionToolStripMenuItem.Name = "gestionQuestionToolStripMenuItem";
            gestionQuestionToolStripMenuItem.Size = new Size(110, 20);
            gestionQuestionToolStripMenuItem.Text = "Gestion Question";
            // 
            // MenuAdmAjouterQuestion
            // 
            MenuAdmAjouterQuestion.Name = "MenuAdmAjouterQuestion";
            MenuAdmAjouterQuestion.Size = new Size(181, 22);
            MenuAdmAjouterQuestion.Text = "Ajouter Question";
            MenuAdmAjouterQuestion.Click += MenuAdmAjouterQuestion_Click;
            // 
            // MenuAdmSupprimerQuestion
            // 
            MenuAdmSupprimerQuestion.Name = "MenuAdmSupprimerQuestion";
            MenuAdmSupprimerQuestion.Size = new Size(181, 22);
            MenuAdmSupprimerQuestion.Text = "Supprimer Question";
            MenuAdmSupprimerQuestion.Click += MenuAdmSupprimerQuestion_Click;
            // 
            // MenuAdmModifierQuestion
            // 
            MenuAdmModifierQuestion.Name = "MenuAdmModifierQuestion";
            MenuAdmModifierQuestion.Size = new Size(181, 22);
            MenuAdmModifierQuestion.Text = "Modifier Question";
            MenuAdmModifierQuestion.Click += MenuAdmModifierQuestion_Click;
            // 
            // MenuAdmConsulterQuestion
            // 
            MenuAdmConsulterQuestion.Name = "MenuAdmConsulterQuestion";
            MenuAdmConsulterQuestion.Size = new Size(181, 22);
            MenuAdmConsulterQuestion.Text = "Consulter Questions";
            MenuAdmConsulterQuestion.Click += MenuAdmConsulterQuestion_Click;
            // 
            // resultatToolStripMenuItem
            // 
            resultatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuAdmAfficherResultat });
            resultatToolStripMenuItem.Name = "resultatToolStripMenuItem";
            resultatToolStripMenuItem.Size = new Size(61, 20);
            resultatToolStripMenuItem.Text = "Resultat";
            // 
            // MenuAdmAfficherResultat
            // 
            MenuAdmAfficherResultat.Name = "MenuAdmAfficherResultat";
            MenuAdmAfficherResultat.Size = new Size(180, 22);
            MenuAdmAfficherResultat.Text = "Afficher";
            MenuAdmAfficherResultat.Click += MenuAdmAfficherResultat_Click;
            // 
            // PannelPrincipale
            // 
            PannelPrincipale.AutoScroll = true;
            PannelPrincipale.Dock = DockStyle.Fill;
            PannelPrincipale.Location = new Point(0, 24);
            PannelPrincipale.Name = "PannelPrincipale";
            PannelPrincipale.Size = new Size(1060, 614);
            PannelPrincipale.TabIndex = 1;
            // 
            // SectionAdministrateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 638);
            Controls.Add(PannelPrincipale);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SectionAdministrateur";
            Text = "SectionAdministrateur";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionUserToolStripMenuItem;
        private ToolStripMenuItem MenuAdmAjouterUtilisateur;
        private ToolStripMenuItem MenuAdmSupprimerUtilisateur;
        private ToolStripMenuItem MenuAdmModifierUtilisateur;
        private ToolStripMenuItem MenuAdmAfficherUtilisateur;
        private ToolStripMenuItem gestionQuestionToolStripMenuItem;
        private ToolStripMenuItem MenuAdmAjouterQuestion;
        private ToolStripMenuItem MenuAdmModifierQuestion;
        private ToolStripMenuItem MenuAdmSupprimerQuestion;
        private ToolStripMenuItem MenuAdmConsulterQuestion;
        private ToolStripMenuItem resultatToolStripMenuItem;
        private ToolStripMenuItem MenuAdmAfficherResultat;
        private Panel PannelPrincipale;
    }
}