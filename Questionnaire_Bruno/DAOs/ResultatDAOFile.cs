using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal class ResultatDAOFile : IResultatDAO
    {
        private string path = @"..\..\..\FILES\resultat.txt";

        public void Ajouter(Questionnaire question)
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            tab.Add(question.ToString());
            File.WriteAllLines(path, tab);
        }

        public List<Questionnaire>? ChercherTout()
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            List<Questionnaire> listerQuestionnaire = new List<Questionnaire>();

            foreach (string line in tab)
            {
                string[] components = line.Split(";-)");
                Questionnaire questionnaire = new Questionnaire();

                questionnaire.Id = int.Parse(components[0]);
                questionnaire.Passage = int.Parse(components[1]);
                questionnaire.ScoreReussi = int.Parse(components[2]);
                questionnaire.LoginUtilisateur = components[3];

                listerQuestionnaire.Add(questionnaire);
            }

            return listerQuestionnaire;
        }
    }
}
