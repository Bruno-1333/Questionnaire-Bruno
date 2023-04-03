﻿using Questionnaire_Bruno.DAOs;
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
                ReponseVF reponseVF = pnlBonneReponse.Controls[0] as ReponseVF;
                bool? bonneReponse = null;
                if (reponseVF.IsVraiChecked)
                {
                    bonneReponse = true;
                }
                else if (reponseVF.IsFauxChecked)
                {
                    bonneReponse = false;
                }

                if (bonneReponse.HasValue)
                {

                    Question question = new Question(txtEnonce.Text, true, bonneReponse.Value);
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
                ReponseSM reponseSM = pnlBonneReponse.Controls[0] as ReponseSM;
                List<string> reponses = new List<string>();
                List<string> propositions = new List<string>();
                if (!string.IsNullOrEmpty(reponseSM.Reponse1))
                {
                    propositions.Add(reponseSM.Reponse1);
                    if (reponseSM.Reponse1Checked)
                    {
                        reponses.Add(reponseSM.Reponse1);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse2))
                {
                    propositions.Add(reponseSM.Reponse2);
                    if (reponseSM.Reponse2Checked)
                    {
                        reponses.Add(reponseSM.Reponse2);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse3))
                {
                    propositions.Add(reponseSM.Reponse3);
                    if (reponseSM.Reponse3Checked)
                    {
                        reponses.Add(reponseSM.Reponse3);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse4))
                {
                    propositions.Add(reponseSM.Reponse4);
                    if (reponseSM.Reponse4Checked)
                    {
                        reponses.Add(reponseSM.Reponse4);
                    }
                }
                if (propositions.Count > 0 && reponses.Count > 0)
                {
                    Question question = new Question(txtEnonce.Text, false, propositions, reponses);
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.Ajouter(question);
                    MessageBox.Show("Question ajouté avec succès");
                    this.btnAnnulerQuestions_Click(sender, e);
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
