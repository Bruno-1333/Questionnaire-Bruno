using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal class QuestionDAOFile : IQuestionsDAO
    {
        private string path = @"..\..\FILEs\Questions.txt";

        public void AjouterQuestion(Question question)
        {
            if(ChercherParId(question.Id)== null)
            {
                string contenu = question.ToString() + "\n";
                File.AppendAllText(path, contenu);
            }
        }

        public Question ChercherParId(int id)
        {
            List<Question> listQuestions = ListerQuestions();

            return listQuestions.Find(question => question.Id == id);
        }

        public List<Question> ListerQuestions()
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            List<Question> listQuestions = new List<Question>();

            foreach (string line in tab)
            {
                //secomposer la ligne selon le separateur
                string[] tabDecomposer = line.Split(';');

                //Créer Question
                Question question = new Question();
                question.Id = int.Parse(tabDecomposer[0]);
                question.Enonce = tabDecomposer[1];
                question.Poids = int.Parse(tabDecomposer[2]);
                question.Type = bool.Parse(tabDecomposer[3]);
                for (int i = 4; i < tabDecomposer.Length; i++)
                {
                    question.Reponses.Add(bool.Parse(tabDecomposer[i]));
                }

                listQuestions.Add(question);
            }

            return listQuestions;
        }

        public void ModifierQuestion(Question question)
        {
            SupprimerQuestion(question);
            AjouterQuestion(question);
        }

        public void SupprimerQuestion(Question question)
        {
            //Créer la liste des questions
            List<Question> listQuestions = ListerQuestions();

            //Suprimer la question
            listQuestions.Remove(question);

            //Vider le fichier
            File.WriteAllText(path, "");

            //Remplir le fichier
            foreach (Question q in listQuestions)
            {
                AjouterQuestion(question);
            }
        }
    }
}
