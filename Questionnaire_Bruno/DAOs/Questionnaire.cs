using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public class Questionnaire
    {
        private static int ctp = 0;
        public int Id { get; internal set; }
        public int ScoreReussi { get; set; } = 0;
        public int Passage { get; set; } = 5;
        public string LoginUtilisateur { get; set; }
        public List<Question> Questions { get; set; }

        public Questionnaire()
        {
            Id = ++ctp;
            Questions = new List<Question>();
        }

        public Questionnaire(int nbrQuestions, int passage, User loginUtilisateur) : this()
        {
            CreerQuestionnaire(nbrQuestions, passage, loginUtilisateur);
        }

        public void AjouterQuestion(Question question)
        {
            Questions.Add(question);
        }

        public string CheckScore()
        {
            return ScoreReussi >= Passage ? "Réussi" : "Échoué";
        }

        public override string ToString()
        {
            return Id + ";-)" + Passage + ";-)" + ScoreReussi + ";-)" + LoginUtilisateur + CheckScore();
        }

        public void CreerQuestionnaire(int nbrQuestions, int scorePassage, User loginUtilisateur)
        {
            List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ListerQuestions();
            
            
            this.Questions = questions.Take(nbrQuestions).ToList();
            this.LoginUtilisateur = loginUtilisateur.Login;
            if(scorePassage > this.Questions.Count) scorePassage = this.Questions.Count;
            this.Passage = scorePassage;

          
        }
       
    }
}
