using Questionnaire_Bruno.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_Bruno
{
    public partial class AjouterUtilisateur : UserControl
    {
        public AjouterUtilisateur()
        {
            InitializeComponent();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text; // recuperer les valeurs des champs
            string premon = textPrenon.Text;
            string telephone = textTelephone.Text;
            bool type = (radioButtonAdm.Checked == true) ? false : true; // recuperer le type d'utilisateur
            int adrNum = int.Parse(textNumero.Text);
            string adrRue = textRue.Text;
            string adrVille = textVille.Text;
            string adrProvince = textProvince.Text;
            string adrCP = textCodePostal.Text;
            string login = textLogin.Text;
            string motPasse = textMotPasse.Text;
            string confirmerMotPasse = textConfirmerMotPasse.Text;

            if (motPasse != confirmerMotPasse) // validation do mot de passe
            {
                msgError.Visible = true; // afficher le message d'erreur
            }
            else
            {
                msgError.Visible = false; // cacher le message d'erreur

                // creation d'un objet user
                User user = new User(nom, premon, telephone, type, adrNum, adrRue, adrVille, adrProvince, adrCP, login, motPasse);

                var userDAO = UserDAOFactory.CreerUserDAO("FILE"); // creation d'un objet userDAO
                userDAO.Ajouuter(user); // ajouter l'utilisateur dans la BD
                this.Hide(); // cacher la fenetre

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textNom.Text = string.Empty; // vider les champs
            textPrenon.Text = string.Empty;
            textTelephone.Text = string.Empty;
            radioButtonAdm.Checked = false;
            textNumero.Text = string.Empty;
            textRue.Text = string.Empty;
            textVille.Text = string.Empty;
            textProvince.Text = string.Empty;
            textCodePostal.Text = string.Empty;
            textLogin.Text = string.Empty;
            textMotPasse.Text = string.Empty;
            textConfirmerMotPasse.Text = string.Empty;

        }
    }
}
