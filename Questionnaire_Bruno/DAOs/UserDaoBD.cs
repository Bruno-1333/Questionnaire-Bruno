using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public class UserDaoBD : IUserDAO
    {
        public void Ajouuter(User user)
        {
            throw new NotImplementedException();
        }

        public User ChercherParLogin(string Login)
        {
            throw new NotImplementedException();
        }

        public User ChercherParLoginMPType(string Login, string mp, bool type)
        {
            throw new NotImplementedException();
        }

        public List<User> ChercherTout()
        {
            throw new NotImplementedException();
        }

        public void Modifier(User user)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(User user)
        {
            throw new NotImplementedException();
        }
    }
}
