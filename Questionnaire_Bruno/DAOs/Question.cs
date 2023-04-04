using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal class Question 
    {
        static int ctp = 0;
        public int Id { get; internal set; }
        public string Enonce { get; set; }
        public bool Type { get; set; } 
        public bool ReponseVraiFaux { get; set; }
        public List<string> ChoixSelcMult { get; set; }
        public List<string> ReponseSelcMult { get; set; }
        public string ChoixDisplay => Type ? "" : string.Join(", ", ChoixSelcMult); //Pl
        public string ReponseDisplay => Type ? (ReponseVraiFaux ? "Vrai" : "Faux") : string.Join(", ", ReponseSelcMult); //PL


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
            return Id + ";-)" + Enonce + ";-)" + Type + ";-)" + ReponseVraiFaux + ";-)" + ChoixSelcMult + ";-)" + ReponseSelcMult; 
        }

        public override bool Equals(object? obj)
        {
            return obj is Question question && Enonce == question.Enonce;
        }

    }
}
