using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    internal interface IResultatDAO
    {
        void Ajouter(Questionnaire questionnaire);
        List<Questionnaire>? ChercherTout();
    }
}
