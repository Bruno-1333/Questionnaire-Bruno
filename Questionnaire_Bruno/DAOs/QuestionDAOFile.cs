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
            question.Id = GenerateUniqueId();

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
                question.Type = bool.Parse(tabDecomposer[2]);
                question.ReponseVraiFaux = bool.Parse(tabDecomposer[3]);
                question.ChoixSelcMult = tabDecomposer[4].Split(',').ToList();
                question.ReponseSelcMult = tabDecomposer[5].Split(',').ToList();

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
        private int GenerateUniqueId()
        {
          
            List<Question> questions = ListerQuestions();

            if (questions.Count == 0)
            {
                return 1;
            }
            else
            {
              
                questions.Sort((x, y) => x.Id.CompareTo(y.Id));

               
                int currentId = 1;

               
                foreach (Question q in questions)
                {
                    if (q.Id == currentId)
                    {
                        
                        currentId++;
                    }
                    else if (q.Id > currentId)
                    {
                        
                        break;
                    }
                }

               
                return currentId;
            }
        }
    }
}
