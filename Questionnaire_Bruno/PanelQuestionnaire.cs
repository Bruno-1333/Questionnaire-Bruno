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
    public partial class PanelQuestionnaire : Form
    {
        private int questionIndexActual = 0;
        private Questionnaire QuestionnaireActual { get; set; }
        public PanelQuestionnaire(Questionnaire q)
        {
            InitializeComponent();
            QuestionnaireActual = q;
        }

        private void PanelQuestionnaire_Load(object sender, EventArgs e)
        {
            ChoixQuestions();

        }
        private void ChoixQuestions()
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
                pnlReponses.Controls.Clear();
                pnlReponses.Controls.Add(new ReponseVraiFaux());
            }
            else
            {
                pnlReponses.Controls.Clear();
                pnlReponses.Controls.Add(new ReponseSelecMult());

                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlReponses.Controls[0];
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
                ReponseVraiFaux reponseVraiFaux = (ReponseVraiFaux)pnlReponses.Controls[0];
                bool reponseUtilisateur = reponseVraiFaux.VraiChecked;
                return reponseUtilisateur == currentQuestion.ReponseVraiFaux;

            }
            else
            {
                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlReponses.Controls[0];
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

      

        private void btnConfirmer_Click_1(object sender, EventArgs e)
        {
            if (CheckReponse())
            {
                QuestionnaireActual.ScoreReussi++;

            }
            questionIndexActual++;
            if (questionIndexActual < QuestionnaireActual.Questions.Count)
            {
                ChoixQuestions();
            }
            else
            {
                string notePassage = "Bravo ok";
                if (QuestionnaireActual.ScoreReussi >= QuestionnaireActual.ScorePassage) notePassage = "Obtenu la note de passege";
                MessageBox.Show($"Terminé le questionnaire, votre score: {QuestionnaireActual.ScoreReussi}/{QuestionnaireActual.Questions.Count}\n{notePassage}");

                questionIndexActual = 0;

                var resultatDAO = ResultatDAOFactory.CreerResultatDAO("FILE");
                resultatDAO.Ajouter(QuestionnaireActual);

                this.Close();
            }

        }
    }
}
