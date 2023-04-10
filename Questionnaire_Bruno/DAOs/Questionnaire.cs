using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal class Questionnaire
    {
        private static int ctp = 0;
        public int Id { get; internal set; }
        public int ScoreReussi { get; set; } = 0;
        public int ScorePassage { get; set; } = 5;
        public string LoginUtilisateur { get; set; }
        public List<Question> Questions { get; set; }

        public Questionnaire()
        {
            Id = ++ctp;
            Questions = new List<Question>();
        }

        public Questionnaire(int nbrQuestions, int scorePassage, User loginUtilisateur) : this()
        {
            CreerQuestionnaire(nbrQuestions, scorePassage, loginUtilisateur);
        }

        public void AjouterQuestion(Question question)
        {
            Questions.Add(question);
        }

        public string CheckScore()
        {
            return ScoreReussi >= ScorePassage ? "Réussi" : "Échoué";
        }

        public override string ToString()
        {
            return Id + ";-)" + ScorePassage + ";-)" + ScoreReussi + ";-)" + LoginUtilisateur + CheckScore();
        }

        public void CreerQuestionnaire(int nbrQuestions, int scorePassage, User loginUtilisateur)
        {
            List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ListerQuestions();
            Random random = new Random();
            List<Question> mixQuestions = questions.OrderBy(x => random.Next()).ToList();
            
            this.Questions = mixQuestions.Take(nbrQuestions).ToList();
            this.LoginUtilisateur = loginUtilisateur.Login;
            if(scorePassage > this.Questions.Count) scorePassage = this.Questions.Count;
            this.ScorePassage = scorePassage;

          
        }
       
    }
}
