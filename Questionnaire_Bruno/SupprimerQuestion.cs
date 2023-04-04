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
    public partial class SupprimerQuestion : UserControl
    {
        public SupprimerQuestion()
        {
            InitializeComponent();
        }

        private void btnSupprimerQuestion_Click(object sender, EventArgs e)
        {
            Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(int.Parse(txtIdSupprimerQuestion.Text));
            if (question != null)
            { 
                QuestionDAOFactory.CreerQuestionDAO("FILE").SupprimerQuestion(question);
                MessageBox.Show("Supre avec succes");
                txtIdSupprimerQuestion.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Id nes pas valid");
            }
           
            
            




            //if (int.TryParse(txtIdSupprimerQuestion.Text, out int id))
            //{
            //    // Verifica se o ID é válido
            //    Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);
            //    if (question == null) // ==
            //    {
            //        MessageBox.Show("Question non trouvée");
            //    }
            //    else
            //    {
            //        QuestionDAOFactory.CreerQuestionDAO("FILE").SupprimerQuestion(question);
            //        MessageBox.Show("Suppression réussie");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Entrez un ID valide");
            //}

            //if (int.TryParse(txtIdSupprimerQuestion.Text, out int id))
            //{
            //    {
            //        MessageBox.Show("Entrer un ID de question valide");
            //    }

            //    Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);
            //    if (question != null)
            //    {
            //        MessageBox.Show("Question nes pas trouve");
            //    }
            //    else
            //    {
            //        QuestionDAOFactory.CreerQuestionDAO("FILE").SupprimerQuestion(question);
            //        MessageBox.Show("Supremè avec succès");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Entrer un ID valide");
            //}



        }







    }
}

