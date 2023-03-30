using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal class QuestionDAOFactory
    {
        public static IQuestionsDAO CreerQuestionDAO(string type)
        {
            if (type == "FILE")
                return new QuestionDAOFile();
            else
                return new QuestionDAOBD();
        }
    }
}
