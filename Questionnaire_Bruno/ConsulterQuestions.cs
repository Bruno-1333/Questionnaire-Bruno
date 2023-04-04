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
    public partial class ConsulterQuestions : UserControl
    {
        public ConsulterQuestions()
        {
            InitializeComponent();
        }
        private List<Question> IntersectionList(List<Question> list1, List<Question> list2)
        {
            List<Question> list3 = new List<Question>();
            foreach (Question question in list1)
            {
                if (list2.Contains(question))
                {
                    list3.Add(question);
                }
            }
            return list3;
        }

        private void ModifierQuestion_Load(object sender, EventArgs e)
        {
            List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ListerQuestions();
            List<Question> listFiltreQuestion = new List<Question>();
            foreach (Question question in questions)
            {
                if (checkVraiFaux.Checked && question.Type)
                {
                    listFiltreQuestion.Add(question);
                }
                else if (checkSelecMult.Checked && question.Type)
                {
                    listFiltreQuestion.Add(question);
                }
                else if (!checkVraiFaux.Checked && !checkSelecMult.Checked)
                {
                    listFiltreQuestion.Add(question);
                }
            }
            dataGridConsulterQuestions.DataSource = null;
            dataGridConsulterQuestions.DataSource = listFiltreQuestion;
        }

    }
}
