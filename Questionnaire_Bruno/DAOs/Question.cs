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
        public int Id { get; set; }
        public string Enonce { get; set; }
        private int _poids = 1;
        public int Poids
        {
            get { return _poids; }
            set
            {
                if (value == 1 || value == 2 || value ==3)
                {
                    _poids = value;
                }
            }
        }
        public bool Type { get; set; } // Vrai = Vrai/Faux, Faux = Sélection multiple
        public List<bool> Reponses { get; set; } 

        public Question(int id, string enonce, int poids, bool type, List<bool> reponses)
        {
            Id = ++ctp;
            Enonce = enonce;
            Poids = poids;
            Type = type;
            Reponses = reponses;
        }
        public Question()
        {
            Id = ++ctp;
        }  
        
        public int CalculerResultat()
        {
            int Ctp = 0;

            if (Type == true)
                for (int i = 0; i < Reponses.Count; i++)
                    if (Reponses[i] == true)
                        Ctp += 100;
            else
                        for(int x = 0; x < Reponses.Count; x++)
                            if (Reponses[x] == false) 
                                Ctp += 50; // ou 0
            return Ctp;
        }

        public override string ToString()
        {
            return Id + ";-)" + Enonce + ";-)" + Poids + ";-)" + Type + ";-)" + string.Join(";-)", Reponses); 
        }

        public override bool Equals(object? obj)
        {
            return obj is Question question && Enonce == question.Enonce;
        }

    }
}
