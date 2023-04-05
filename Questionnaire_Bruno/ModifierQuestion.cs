using Questionnaire_Bruno.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
            try
            {
                int id = int.Parse(txtIdModiierQuestion.Text);

                Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);

                if (question == null)
                {
                    MessageBox.Show("Aucune question trouvée avec ce ID");
                }
                else
                {
                    txtEnonce.Text = question.Enonce;
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
                        if (reponseSelecMult.ReponseSelecMult3.Contains(reponseSelecMult.ReponseSelecMult3))
                        {
                            reponseSelecMult.checkReponseSelecMult3 = true;
                        }
                        if (reponseSelecMult.ReponseSelecMult4.Contains(reponseSelecMult.ReponseSelecMult4))
                        {
                            reponseSelecMult.checkReponseSelecMult4 = true;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
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

        private void btnModifierQuestion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdModiierQuestion.Text, out int id))
            {
                MessageBox.Show("Entrer un ID de question valide");
                return;
            }

            string enonce = txtEnonce.Text;
            if (string.IsNullOrEmpty(enonce))
            {
                MessageBox.Show("Entrer un énoncé pour la question");
            }

            if (radioBtnQuestionVraiFaux.Checked)
            {
                ReponseVraiFaux reponseVF = pnlReponses.Controls[0] as ReponseVraiFaux;
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
                    Question question = new Question(txtEnonce.Text, true, bonneReponse.Value, null, null);
                    //question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.ModifierQuestion(question);
                }
                else
                {
                    MessageBox.Show("Choisir la bonne réponse");
                }
            }
            else if (radioBtnQuestionSelectMult.Checked)
            {
                ReponseSelecMult reponseSelMult = pnlReponses.Controls[0] as ReponseSelecMult;
                List<string> reponses = new List<string>();
                List<string> propositions = new List<string>();

                propositions.Add(reponseSelMult.ReponseSelecMult1);
                if (reponseSelMult.checkReponseSelecMult1)
                {
                    reponses.Add(reponseSelMult.ReponseSelecMult1);
                }
                propositions.Add(reponseSelMult.ReponseSelecMult2);
                if (reponseSelMult.checkReponseSelecMult2)
                {
                    reponses.Add(reponseSelMult.ReponseSelecMult2);
                }
                propositions.Add(reponseSelMult.ReponseSelecMult3);
                if (reponseSelMult.checkReponseSelecMult2)
                {
                    reponses.Add(reponseSelMult.ReponseSelecMult3);
                }
                propositions.Add(reponseSelMult.ReponseSelecMult4);
                if (reponseSelMult.checkReponseSelecMult2)
                {
                    reponses.Add(reponseSelMult.ReponseSelecMult4);
                }
                if (propositions.Count > 0 && reponses.Count > 0)
                {
                    Question question = new Question(txtEnonce.Text, false, false, propositions, reponses);
                    question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.ModifierQuestion(question);
                    MessageBox.Show("Question modifié");
                    this.btnAnnuler_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Entrer avec une proposition et une bonne réponse");
                }
            }
            else
            {
                MessageBox.Show("Chosir le type de question");
            }
        }

    }
}



