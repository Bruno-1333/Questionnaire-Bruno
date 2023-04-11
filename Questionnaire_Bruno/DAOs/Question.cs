using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public class Question 
    {
        static int ctp = 0;
        public int Id { get; internal set; }
        public string Enonce { get; set; }
        public bool Type { get; set; } 
        public bool ReponseVraiFaux { get; set; }
        public List<string> ChoixSelcMult { get; set; } = new List<string>();
        public List<string> ReponseSelcMult { get; set; } = new List<string>();
        public string ChoixDisplay { get; set; }                                     
        public string ReponseDisplay { get; set; }  


        public Question( string enonce, bool type,bool reponseVraiFaux , List<string> choixSelecMult, List<string> choixVraiFeaux):this()
        {
            Enonce = enonce;
            Type = type;
            ReponseVraiFaux = reponseVraiFaux;
            ChoixSelcMult = choixSelecMult;
            ReponseSelcMult = choixVraiFeaux;


        }
        public Question()
        {
            //Id = ++ctp;
        } 

        public override string ToString()
        {
            return Id + ";-)" + Enonce + ";-)" + Type + ";-)" + ReponseVraiFaux + ";-)" + string.Join(", ", ChoixSelcMult) + ";-)" + string.Join(", ", ReponseSelcMult);
        }

        public override bool Equals(object? obj)
        {
            return obj is Question question && Enonce == question.Enonce;
        }

    }
}





