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
    public partial class AjouterQuestion : UserControl
    {
        public AjouterQuestion()
        {
            InitializeComponent();
        }

        private void radioBtnQuestionVraiFaux_CheckedChanged(object sender, EventArgs e)
        {
            pnlBonneReponse.Controls.Clear();
            pnlBonneReponse.Controls.Add(new ReponseVraiFaux());
        }

        private void radioBtnQuestionSelecMult_CheckedChanged(object sender, EventArgs e)
        {
            pnlBonneReponse.Controls.Clear();
            pnlBonneReponse.Controls.Add(new ReponseSelecMult());
        }

        private void BtnAnnulerQuestions_Click(object sender, EventArgs e)
        {
            txtEnonce.Text = string.Empty;
            radioBtnQuestionSelecMult.Checked = false;
            radioBtnQuestionVraiFaux.Checked = false;
            pnlBonneReponse.Controls.Clear();
        }

        private void BtnAjouterQuestions_Click(object sender, EventArgs e)
        {
            string enonce = txtEnonce.Text;
            if (string.IsNullOrEmpty(enonce))
            {
                MessageBox.Show("Vous devez entrer un énoncé pour la question");
                return;
            }
            if (radioBtnQuestionVraiFaux.Checked)
            {
                ReponseVraiFaux reponseVF = pnlBonneReponse.Controls[0] as ReponseVraiFaux;
                bool? bonneReponse = null;
                if (reponseVF.VraiChecked)
                {
                    bonneReponse = true;
                }
                else if (reponseVF.FauxChecked)
                {
                    bonneReponse = false;
                }

                if (bonneReponse.HasValue)
                {

                    Question question = new Question();
                    question.Enonce = enonce;
                    question.Type = true;
                    question.ReponseVraiFaux = bonneReponse.Value;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.AjouterQuestion(question);

                }
                else
                {
                    MessageBox.Show("Vous devez choisir la bonne réponse");
                }
            }

            else if (radioBtnQuestionSelecMult.Checked)
            {
                ReponseSelecMult reponseSM = pnlBonneReponse.Controls[0] as ReponseSelecMult;
                List<string> reponses = new List<string>();
                List<string> propositions = new List<string>();
                if (!string.IsNullOrEmpty(reponseSM.ReponseSelecMult1)) 
                {
                    propositions.Add(reponseSM.ReponseSelecMult1);
                    if (reponseSM.checkReponseSelecMult1) 
                    {
                        reponses.Add(reponseSM.ReponseSelecMult1);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.ReponseSelecMult2))
                {
                    propositions.Add(reponseSM.ReponseSelecMult2);
                    if (reponseSM.checkReponseSelecMult2)
                    {
                        reponses.Add(reponseSM.ReponseSelecMult2);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.ReponseSelecMult3))
                {
                    propositions.Add(reponseSM.ReponseSelecMult3);
                    if (reponseSM.checkReponseSelecMult3)
                    {
                        reponses.Add(reponseSM.ReponseSelecMult3);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.ReponseSelecMult4))
                {
                    propositions.Add(reponseSM.ReponseSelecMult4);
                    if (reponseSM.checkReponseSelecMult4)
                    {
                        reponses.Add(reponseSM.ReponseSelecMult4);
                    }
                }
                if (propositions.Count > 0 && reponses.Count > 0)
                {
                    Question question = new Question();
                    question.Enonce = enonce;
                    question.Type = false;
                    question.ChoixSelcMult = propositions;
                    question.ReponseSelcMult = reponses;

                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.AjouterQuestion(question);
                    MessageBox.Show("Question ajouté avec succès");
                    this.BtnAnnulerQuestions_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vous devez entrer au moins une proposition et une bonne réponse");
                }
            }
            else
            {
                MessageBox.Show("Vous devez choisir le type de question");
            }

        }
    }
}
