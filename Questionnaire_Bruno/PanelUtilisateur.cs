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

        private int questionIndexActual = 0;

        private Questionnaire QuestionnaireActual { get; set; }


        public PanelUtilisateur(User utilisateur) //,Questionnaire q)
        {
            InitializeComponent();
            utilisateurConnecte = utilisateur;
            NonUtilisateurCourant();
            //QuestionnaireActual = q;

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
            textBox1.Visible = false;
            pnlMaster.Show();

            //Questionnaire questionnaire = new Questionnaire(nbrQuestions, scorePassage,loginUtilisateur);

        }

        private void UpdateLabels()
        {
            if (QuestionnaireActual.Questions.Count > questionIndexActual)
            {
                Question currentQuestion = QuestionnaireActual.Questions[questionIndexActual];
                lblCount.Text = $"Question {questionIndexActual + 1} de 10";
                lblEnonce.Text = currentQuestion.Enonce;
            }
            else
            {
                MessageBox.Show("Fini");
            }
            if (QuestionnaireActual.Questions[questionIndexActual].Type)
            {
                pnlMaster.Controls.Clear();
                pnlMaster.Controls.Add(new ReponseVraiFaux());
            }
            else
            {
                pnlMaster.Controls.Clear();
                pnlMaster.Controls.Add(new ReponseSelecMult());

                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlMaster.Controls[0];
                reponseSelecMult.ReponseSelecMult1 = QuestionnaireActual.Questions[questionIndexActual].ChoixSelcMult[0];
                reponseSelecMult.ReponseSelecMult2 = QuestionnaireActual.Questions[questionIndexActual].ChoixSelcMult[1];
                reponseSelecMult.ReponseSelecMult3 = QuestionnaireActual.Questions[questionIndexActual].ChoixSelcMult[2];
                reponseSelecMult.ReponseSelecMult4 = QuestionnaireActual.Questions[questionIndexActual].ChoixSelcMult[3];

            }

        }

        private bool CheckReponse()
        {
            Question currentQuestion = QuestionnaireActual.Questions[questionIndexActual];
            if (currentQuestion.Type)
            {
                ReponseVraiFaux reponseVraiFaux = (ReponseVraiFaux)pnlMaster.Controls[0];
                bool reponseUtilisateur = reponseVraiFaux.VraiChecked;
                return reponseUtilisateur == currentQuestion.ReponseVraiFaux;

            }
            else
            {
                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlMaster.Controls[0];
                List<string> reponseUtilisateur = new List<string>
                {
                    reponseSelecMult.checkReponseSelecMult1 ? reponseSelecMult.ReponseSelecMult1 : null,
                    reponseSelecMult.checkReponseSelecMult2 ? reponseSelecMult.ReponseSelecMult2 : null,
                    reponseSelecMult.checkReponseSelecMult3 ? reponseSelecMult.ReponseSelecMult3 : null,
                    reponseSelecMult.checkReponseSelecMult4 ? reponseSelecMult.ReponseSelecMult4 : null,

                };
                reponseUtilisateur.RemoveAll(item => item == null);

                return reponseUtilisateur.SequenceEqual(currentQuestion.ReponseSelcMult);
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (CheckReponse())
            {
                QuestionnaireActual.ScoreReussi++;

            }
            questionIndexActual++;
            if (questionIndexActual < QuestionnaireActual.Questions.Count)
            {
                UpdateLabels();
            }
            else
            {
                string notePassage = "Bravo ok";
                if (QuestionnaireActual.ScoreReussi >= QuestionnaireActual.ScorePassage) notePassage = "Obtenu la note de passege";
                MessageBox.Show($"Terminé le questionnaire, votre score: {QuestionnaireActual.ScoreReussi}/{QuestionnaireActual.Questions.Count}\n{notePassage}");

                questionIndexActual = 0;

                //var resultatDAO = ResultatDAOFactory.CreerResultatDAO("FILE");
                //resultatDAO.Ajouter(QuestionnaireActual);

                this.Close();
            }


        }
    }
}
