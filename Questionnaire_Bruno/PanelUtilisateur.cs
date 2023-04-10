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

        private void btnRegle_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;

            }

        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            var nbrQuestions = 10;
            var scorePassage = 6;
            textBox1.Visible = false;
            Questionnaire q = new Questionnaire(nbrQuestions,scorePassage,utilisateurConnecte );
            new PanelQuestionnaire(q).Show();
            
           
        }

    }
}
