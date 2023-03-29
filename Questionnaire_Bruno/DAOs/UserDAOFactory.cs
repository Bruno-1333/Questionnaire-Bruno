using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public class UserDAOFactory
    {
        public static IUserDAO CreerUserDAO(string type) 
        { 
            if (type == "FILE") return new UserDAOFile(); 
            else return new UserDaoBD(); 
        }
    }
}
