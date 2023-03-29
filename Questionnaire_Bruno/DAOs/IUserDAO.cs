using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public interface IUserDAO
    {
        void Ajouuter(User user);
        void Supprimer(User user);
        void Modifier(User user);
        List<User> ChercherTout();
        User? ChercherParLogin(string Login);
        User? ChercherParLoginMPType(string Login, string mp, bool type);
    }
}
