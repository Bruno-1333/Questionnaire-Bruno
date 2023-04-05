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
            bool type = (radioButtonUser.Checked == true) ? false : true; // recuperer le type d'utilisateur
            int adrNum = int.Parse(textBoxAdrNum.Text);
            string adrRue = textBoxAdrRue.Text;
            string adrVille = textBoxAdrVille.Text;
            string adrProvince = textBoxAdrProvince.Text;
            string adrCP = textBoxCP.Text;
            string login = textBoxLogin.Text;
            string motPasse = textBoxMP.Text;
            string confirmerMotPasse = textBoxConfirmeMotPasse.Text;

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
               buttonAnnuler_Click(sender, e);

            }

        }
        

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textNom.Text = string.Empty; // vider les champs
            textPrenon.Text = string.Empty;
            textTelephone.Text = string.Empty;
            radioButtonUser.Checked = false;
            textBoxAdrNum.Text = string.Empty;
            textBoxAdrRue.Text = string.Empty;
            textBoxAdrVille.Text = string.Empty;
            textBoxAdrProvince.Text = string.Empty;
            textBoxCP.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxMP.Text = string.Empty;
            textBoxConfirmeMotPasse.Text = string.Empty;



        }
    }
}
