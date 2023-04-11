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
        public Questionnaire QuestionnaireCourrent { get; set; }
        public PanelQuestionnaire(Questionnaire questionnaire)
        {
            InitializeComponent();
            QuestionnaireCourrent = questionnaire;
        }

        private void PanelQuestionnaire_Load(object sender, EventArgs e)
        {
            QuestionsSuivant();

        }
        private void QuestionsSuivant()
        {
            if (QuestionnaireCourrent.Questions.Count > questionIndexActual)
            {
                Question currentQuestion = QuestionnaireCourrent.Questions[questionIndexActual];
                lblEnonce.Text = currentQuestion.Enonce;

            }
            else
            {
                MessageBox.Show("Fini");
            }
            if (QuestionnaireCourrent.Questions[questionIndexActual].Type)
            {
                pnlReponseQuestion.Controls.Clear();
                pnlReponseQuestion.Controls.Add(new ReponseVraiFaux());
            }
            else
            {
                pnlReponseQuestion.Controls.Clear();
                pnlReponseQuestion.Controls.Add(new ReponseSelecMult());


                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlReponseQuestion.Controls[0];

                reponseSelecMult.ReponseSelecMult1 = QuestionnaireCourrent.Questions[questionIndexActual].ChoixSelcMult[0];
                reponseSelecMult.ReponseSelecMult2 = QuestionnaireCourrent.Questions[questionIndexActual].ChoixSelcMult[1];
                reponseSelecMult.ReponseSelecMult3 = QuestionnaireCourrent.Questions[questionIndexActual].ChoixSelcMult[2];
                reponseSelecMult.ReponseSelecMult4 = QuestionnaireCourrent.Questions[questionIndexActual].ChoixSelcMult[3];


            }
        }

        private bool CheckReponse()
        {
            Question currentQuestion = QuestionnaireCourrent.Questions[questionIndexActual];
            if (currentQuestion.Type)
            {
                ReponseVraiFaux reponseVraiFaux = (ReponseVraiFaux)pnlReponseQuestion.Controls[0];
                bool reponseUtilisateur = reponseVraiFaux.VraiChecked;
                return reponseUtilisateur == currentQuestion.ReponseVraiFaux;

            }
            else
            {
                ReponseSelecMult reponseSelecMult = (ReponseSelecMult)pnlReponseQuestion.Controls[0];
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
                QuestionnaireCourrent.ScoreReussi++;

            }
            questionIndexActual++;
            if (questionIndexActual < QuestionnaireCourrent.Questions.Count)
            {
                QuestionsSuivant();
            }
            else
            {
                string notePassage = "PAS BONNE";
                picturePasGagne.Visible = true;
                if (QuestionnaireCourrent.ScoreReussi >= QuestionnaireCourrent.Passage) notePassage = "BRAVO";
                pictureGagne.Visible = true;
                MessageBox.Show($"Terminé le questionnaire, votre score: {QuestionnaireCourrent.ScoreReussi}/{QuestionnaireCourrent.Questions.Count}\n{notePassage}");

                questionIndexActual = 0;

                QuestionsSuivant();

                var resultatDAO = ResultatDAOFactory.CreerResultatDAO("FILE");
                resultatDAO.Ajouter(QuestionnaireCourrent);

                this.Close();
            }

        }


    }
}


