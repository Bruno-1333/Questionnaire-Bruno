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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Questionnaire_Bruno
{
    public partial class ModifierQuestion : UserControl
    {
        public ModifierQuestion()
        {
            InitializeComponent();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdModiierQuestion.Text, out int id))
            {
                MessageBox.Show("Veuillez entrer un ID de question valide");
            }


            Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);
            txtEnonce.Text = question.Enonce;
            if (question == null)
            {
                MessageBox.Show("Aucune question trouvée avec ce ID");
            }
            else
            {
                if (question.Type == true)
                {
                    radioBtnQuestionVraiFaux.Checked = true;
                    pnlReponses.Controls.Clear();
                    ReponseVraiFaux reponseVraiFaux = new ReponseVraiFaux();
                    pnlReponses.Controls.Add(reponseVraiFaux);
                    if (question.ReponseVraiFaux)
                    {
                        reponseVraiFaux.VraiChecked = true;
                    }
                    else
                    {
                        reponseVraiFaux.VraiChecked = true;
                    }

                }
                else
                {
                    radioBtnQuestionSelectMult.Checked = true;
                    pnlReponses.Controls.Clear();
                    ReponseSelecMult reponseSelecMult = new ReponseSelecMult();
                    pnlReponses.Controls.Add(reponseSelecMult);

                    reponseSelecMult.ReponseSelecMult1 = question.ChoixSelcMult[0];
                    reponseSelecMult.ReponseSelecMult2 = question.ChoixSelcMult[1];
                    reponseSelecMult.ReponseSelecMult3 = question.ChoixSelcMult[2];
                    reponseSelecMult.ReponseSelecMult4 = question.ChoixSelcMult[3];

                    if (question.ReponseSelcMult.Contains(reponseSelecMult.ReponseSelecMult1))
                    {
                        reponseSelecMult.checkReponseSelecMult1 = true;
                    }
                    if (reponseSelecMult.ReponseSelecMult2.Contains(reponseSelecMult.ReponseSelecMult2))
                    {
                        reponseSelecMult.checkReponseSelecMult2 = true;
                    }
                    if (reponseSelecMult.ReponseSelecMult2.Contains(reponseSelecMult.ReponseSelecMult3))
                    {
                        reponseSelecMult.checkReponseSelecMult3 = true;
                    }
                    if (reponseSelecMult.ReponseSelecMult2.Contains(reponseSelecMult.ReponseSelecMult2))
                    {
                        reponseSelecMult.checkReponseSelecMult4 = true;
                    }

                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlReponses.Controls.Clear();
            txtEnonce.Text = string.Empty;
            txtIdModiierQuestion.Text = string.Empty;
            radioBtnQuestionSelectMult.Checked = false;
            radioBtnQuestionVraiFaux.Checked = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdModiierQuestion.Text, out int id))
            {
                MessageBox.Show("Veuillez entrer un ID de question valide");
                return;
            }

            string enonce = txtEnonce.Text;
            if (string.IsNullOrEmpty(enonce))
            {
                MessageBox.Show("Vous devez entrer un énoncé pour la question");
            }

            if (radioBtnQuestionVraiFaux.Checked)
            {
                ReponseVraiFaux reponseVraiFaux = pnlReponses.Controls[0] as ReponseVraiFaux;
                bool? bonneReponse = null;
                if (reponseVraiFaux.VraiChecked)
                {
                    bonneReponse = true;
                }
                else if (reponseVraiFaux.FauxChecked)
                {
                    bonneReponse = false;
                }

                if (bonneReponse.HasValue)
                {
                    Question question = new Question();
                    question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.ModifierQuestion(question);
                }
                else
                {
                    MessageBox.Show("Vous devez choisir la bonne réponse");
                }
            }
            else if (radioBtnQuestionSelectMult.Checked)
            {
                ReponseSelecMult reponseSM = pnlReponses.Controls[0] as ReponseSelecMult;
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
                    question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.ModifierQuestion(question);
                    MessageBox.Show("Question modifié avec succès");
                    this.btnAnnuler_Click(sender, e);
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


