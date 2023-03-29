namespace Questionnaire_Bruno
{
    partial class AjouterUtilisateur
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
            buttonAnnuler = new Button();
            buttonEnregistrer = new Button();
            msgError = new Label();
            Identifiant = new Label();
            radioButtonUtilisateur = new RadioButton();
            radioButtonAdm = new RadioButton();
            Catégone = new Label();
            Informations = new Label();
            textConfirmerMotPasse = new TextBox();
            ConfirmerMotPasse = new Label();
            textMotPasse = new TextBox();
            MotPasse = new Label();
            textLogin = new TextBox();
            Login = new Label();
            textCodePostal = new TextBox();
            CodePostal = new Label();
            textProvince = new TextBox();
            Province = new Label();
            textVille = new TextBox();
            Ville = new Label();
            textRue = new TextBox();
            Rue = new Label();
            textNumero = new TextBox();
            Numero = new Label();
            Adresse = new Label();
            textTelephone = new TextBox();
            Telephone = new Label();
            textPrenon = new TextBox();
            Prenom = new Label();
            textNom = new TextBox();
            Nom = new Label();
            panel2 = new Panel();
            CreationUtilisateur = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            vScrollBar1 = new VScrollBar();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(378, 602);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(126, 32);
            buttonAnnuler.TabIndex = 30;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnregistrer.Location = new Point(189, 602);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(126, 32);
            buttonEnregistrer.TabIndex = 29;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = true;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // msgError
            // 
            msgError.AutoSize = true;
            msgError.Location = new Point(470, 28);
            msgError.Name = "msgError";
            msgError.Size = new Size(129, 30);
            msgError.TabIndex = 0;
            msgError.Text = "Le deux mot passe doit\r\netre identique";
            msgError.Visible = false;
            // 
            // Identifiant
            // 
            Identifiant.AutoSize = true;
            Identifiant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Identifiant.Location = new Point(166, 549);
            Identifiant.Name = "Identifiant";
            Identifiant.Size = new Size(73, 15);
            Identifiant.TabIndex = 65;
            Identifiant.Text = "Identifiant";
            // 
            // radioButtonUtilisateur
            // 
            radioButtonUtilisateur.AutoSize = true;
            radioButtonUtilisateur.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUtilisateur.Location = new Point(499, 285);
            radioButtonUtilisateur.Name = "radioButtonUtilisateur";
            radioButtonUtilisateur.Size = new Size(94, 27);
            radioButtonUtilisateur.TabIndex = 64;
            radioButtonUtilisateur.TabStop = true;
            radioButtonUtilisateur.Text = "Utilisateur";
            radioButtonUtilisateur.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdm
            // 
            radioButtonAdm.AutoSize = true;
            radioButtonAdm.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAdm.Location = new Point(278, 285);
            radioButtonAdm.Name = "radioButtonAdm";
            radioButtonAdm.Size = new Size(126, 27);
            radioButtonAdm.TabIndex = 63;
            radioButtonAdm.TabStop = true;
            radioButtonAdm.Text = "Administrateur";
            radioButtonAdm.UseVisualStyleBackColor = true;
            // 
            // Catégone
            // 
            Catégone.AutoSize = true;
            Catégone.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Catégone.Location = new Point(165, 258);
            Catégone.Name = "Catégone";
            Catégone.Size = new Size(70, 15);
            Catégone.TabIndex = 62;
            Catégone.Text = "Categone";
            // 
            // Informations
            // 
            Informations.AutoSize = true;
            Informations.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Informations.Location = new Point(165, 138);
            Informations.Name = "Informations";
            Informations.Size = new Size(89, 15);
            Informations.TabIndex = 61;
            Informations.Text = "Informations";
            // 
            // textConfirmerMotPasse
            // 
            textConfirmerMotPasse.Location = new Point(365, 628);
            textConfirmerMotPasse.Name = "textConfirmerMotPasse";
            textConfirmerMotPasse.Size = new Size(243, 23);
            textConfirmerMotPasse.TabIndex = 60;
            // 
            // ConfirmerMotPasse
            // 
            ConfirmerMotPasse.AutoSize = true;
            ConfirmerMotPasse.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmerMotPasse.Location = new Point(173, 628);
            ConfirmerMotPasse.Name = "ConfirmerMotPasse";
            ConfirmerMotPasse.Size = new Size(176, 23);
            ConfirmerMotPasse.TabIndex = 59;
            ConfirmerMotPasse.Text = "Confirmer Mot de Passe";
            // 
            // textMotPasse
            // 
            textMotPasse.Location = new Point(365, 599);
            textMotPasse.Name = "textMotPasse";
            textMotPasse.Size = new Size(243, 23);
            textMotPasse.TabIndex = 58;
            // 
            // MotPasse
            // 
            MotPasse.AutoSize = true;
            MotPasse.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MotPasse.Location = new Point(173, 599);
            MotPasse.Name = "MotPasse";
            MotPasse.Size = new Size(105, 23);
            MotPasse.TabIndex = 57;
            MotPasse.Text = "Mot de Passe";
            // 
            // textLogin
            // 
            textLogin.Location = new Point(365, 570);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(243, 23);
            textLogin.TabIndex = 56;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(175, 570);
            Login.Name = "Login";
            Login.Size = new Size(49, 23);
            Login.TabIndex = 55;
            Login.Text = "Login";
            // 
            // textCodePostal
            // 
            textCodePostal.Location = new Point(278, 500);
            textCodePostal.Name = "textCodePostal";
            textCodePostal.Size = new Size(538, 23);
            textCodePostal.TabIndex = 54;
            // 
            // CodePostal
            // 
            CodePostal.AutoSize = true;
            CodePostal.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodePostal.Location = new Point(173, 500);
            CodePostal.Name = "CodePostal";
            CodePostal.Size = new Size(94, 23);
            CodePostal.TabIndex = 53;
            CodePostal.Text = "Code Postal";
            // 
            // textProvince
            // 
            textProvince.Location = new Point(278, 471);
            textProvince.Name = "textProvince";
            textProvince.Size = new Size(538, 23);
            textProvince.TabIndex = 52;
            // 
            // Province
            // 
            Province.AutoSize = true;
            Province.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Province.Location = new Point(173, 471);
            Province.Name = "Province";
            Province.Size = new Size(70, 23);
            Province.TabIndex = 51;
            Province.Text = "Province";
            // 
            // textVille
            // 
            textVille.Location = new Point(278, 442);
            textVille.Name = "textVille";
            textVille.Size = new Size(538, 23);
            textVille.TabIndex = 50;
            // 
            // Ville
            // 
            Ville.AutoSize = true;
            Ville.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Ville.Location = new Point(175, 442);
            Ville.Name = "Ville";
            Ville.Size = new Size(39, 23);
            Ville.TabIndex = 49;
            Ville.Text = "Ville";
            // 
            // textRue
            // 
            textRue.Location = new Point(278, 413);
            textRue.Name = "textRue";
            textRue.Size = new Size(538, 23);
            textRue.TabIndex = 48;
            // 
            // Rue
            // 
            Rue.AutoSize = true;
            Rue.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rue.Location = new Point(175, 413);
            Rue.Name = "Rue";
            Rue.Size = new Size(39, 23);
            Rue.TabIndex = 47;
            Rue.Text = "Rue";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(278, 384);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(538, 23);
            textNumero.TabIndex = 46;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Numero.Location = new Point(173, 387);
            Numero.Name = "Numero";
            Numero.Size = new Size(66, 23);
            Numero.TabIndex = 45;
            Numero.Text = "Numéro";
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Adresse.Location = new Point(165, 363);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(60, 15);
            Adresse.TabIndex = 44;
            Adresse.Text = "Adresse";
            // 
            // textTelephone
            // 
            textTelephone.Location = new Point(278, 212);
            textTelephone.Name = "textTelephone";
            textTelephone.Size = new Size(538, 23);
            textTelephone.TabIndex = 43;
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Telephone.Location = new Point(173, 212);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(85, 23);
            Telephone.TabIndex = 42;
            Telephone.Text = "Téléphone";
            // 
            // textPrenon
            // 
            textPrenon.Location = new Point(278, 183);
            textPrenon.Name = "textPrenon";
            textPrenon.Size = new Size(538, 23);
            textPrenon.TabIndex = 41;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Prenom.Location = new Point(173, 183);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(65, 23);
            Prenom.TabIndex = 40;
            Prenom.Text = "Prénom";
            // 
            // textNom
            // 
            textNom.Location = new Point(278, 154);
            textNom.Name = "textNom";
            textNom.Size = new Size(538, 23);
            textNom.TabIndex = 39;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Nom.Location = new Point(173, 154);
            Nom.Name = "Nom";
            Nom.Size = new Size(43, 23);
            Nom.TabIndex = 38;
            Nom.Text = "Nom";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(CreationUtilisateur);
            panel2.Location = new Point(162, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 42);
            panel2.TabIndex = 66;
            // 
            // CreationUtilisateur
            // 
            CreationUtilisateur.AutoSize = true;
            CreationUtilisateur.BackColor = SystemColors.ControlLight;
            CreationUtilisateur.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreationUtilisateur.Location = new Point(165, 3);
            CreationUtilisateur.Name = "CreationUtilisateur";
            CreationUtilisateur.Size = new Size(292, 29);
            CreationUtilisateur.TabIndex = 22;
            CreationUtilisateur.Text = "CRÉATION D'UN UTILISATEUR";
            // 
            // panel3
            // 
            panel3.Location = new Point(162, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(663, 109);
            panel3.TabIndex = 67;
            // 
            // panel4
            // 
            panel4.Location = new Point(162, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(663, 100);
            panel4.TabIndex = 68;
            // 
            // panel5
            // 
            panel5.Location = new Point(162, 360);
            panel5.Name = "panel5";
            panel5.Size = new Size(663, 175);
            panel5.TabIndex = 69;
            // 
            // panel6
            // 
            panel6.Controls.Add(msgError);
            panel6.Location = new Point(163, 545);
            panel6.Name = "panel6";
            panel6.Size = new Size(662, 119);
            panel6.TabIndex = 70;
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.Controls.Add(buttonAnnuler);
            panel7.Controls.Add(buttonEnregistrer);
            panel7.Location = new Point(138, 81);
            panel7.Name = "panel7";
            panel7.Size = new Size(705, 640);
            panel7.TabIndex = 71;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(846, 81);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(22, 640);
            vScrollBar1.TabIndex = 72;
            // 
            // AjouterUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vScrollBar1);
            Controls.Add(Identifiant);
            Controls.Add(radioButtonUtilisateur);
            Controls.Add(radioButtonAdm);
            Controls.Add(Catégone);
            Controls.Add(Informations);
            Controls.Add(textConfirmerMotPasse);
            Controls.Add(ConfirmerMotPasse);
            Controls.Add(textMotPasse);
            Controls.Add(MotPasse);
            Controls.Add(textLogin);
            Controls.Add(Login);
            Controls.Add(textCodePostal);
            Controls.Add(CodePostal);
            Controls.Add(textProvince);
            Controls.Add(Province);
            Controls.Add(textVille);
            Controls.Add(Ville);
            Controls.Add(textRue);
            Controls.Add(Rue);
            Controls.Add(textNumero);
            Controls.Add(Numero);
            Controls.Add(Adresse);
            Controls.Add(textTelephone);
            Controls.Add(Telephone);
            Controls.Add(textPrenon);
            Controls.Add(Prenom);
            Controls.Add(textNom);
            Controls.Add(Nom);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Name = "AjouterUtilisateur";
            Size = new Size(951, 748);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnnuler;
        private Button buttonEnregistrer;
        private Label msgError;
        private Label Identifiant;
        private RadioButton radioButtonUtilisateur;
        private RadioButton radioButtonAdm;
        private Label Catégone;
        private Label Informations;
        private TextBox textConfirmerMotPasse;
        private Label ConfirmerMotPasse;
        private TextBox textMotPasse;
        private Label MotPasse;
        private TextBox textLogin;
        private Label Login;
        private TextBox textCodePostal;
        private Label CodePostal;
        private TextBox textProvince;
        private Label Province;
        private TextBox textVille;
        private Label Ville;
        private TextBox textRue;
        private Label Rue;
        private TextBox textNumero;
        private Label Numero;
        private Label Adresse;
        private TextBox textTelephone;
        private Label Telephone;
        private TextBox textPrenon;
        private Label Prenom;
        private TextBox textNom;
        private Label Nom;
        private Panel panel2;
        private Label CreationUtilisateur;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private VScrollBar vScrollBar1;
    }
}
