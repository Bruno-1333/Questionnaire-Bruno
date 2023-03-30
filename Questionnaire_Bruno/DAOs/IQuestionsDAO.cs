using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal interface IQuestionsDAO
    {
        void AjouterQuestion(Question question);
        void ModifierQuestion(Question question);
        void SupprimerQuestion(Question question);
        List<Question> ListerQuestions();
        Question ChercherParId(int id);


    }
}
