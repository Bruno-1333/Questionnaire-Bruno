using Questionnaire_Bruno.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_Bruno
{
    public partial class PanelUtilisateur : Form
    {
        private User utilisateurConnecte;

        public PanelUtilisateur(User utilisateur)
        {
            InitializeComponent();
            utilisateurConnecte = utilisateur;
            NonUtilisateurCourant();


        }

        private void NonUtilisateurCourant()
        {
            lblNonUtilisateurCourant.Text = utilisateurConnecte.Nom;
        }



        private void btnCommencer_Click(object sender, EventArgs e)
        {



            try
            {
                int nbrQuestions = int.Parse(txtNbrQuestions.Text);
                int scoreDePassage = int.Parse(txtScore.Text);
                Questionnaire questionnaire = new Questionnaire(nbrQuestions, scoreDePassage, utilisateurConnecte);
                new PanelQuestionnaire(questionnaire).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Entre un nombre valide");
            }
        }

    }
}
