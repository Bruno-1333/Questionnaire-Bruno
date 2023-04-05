using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Bruno.DAOs
{
    public class UserDAOFile : IUserDAO
    {
        private string path = @"..\..\..\FILES\users.txt"; // Path du fichier
        public void Ajouuter(User user)
        {
            if (ChercherParLogin(user.Login) == null) 
            {
                string contenu = user.ToString() + "\n"; // Convertir le user en string
                File.AppendAllText(path, contenu); // Ajouter le user au fichier
            }
        }

        public User? ChercherParLogin(string Login) 
        {
            List<User> list = ChercherTout(); // Chercher tout les users
            return list.Find(user => user.Login == Login); // Chercher le user qui a le meme login
        }

        public User? ChercherParLoginMPType(string Login, string mp, bool type)
        {
            // Chercher le user qui a le meme login et mot de passe et type
            List<User> list = ChercherTout();
            return list.Find(user => user.Login == Login && user.MotPasse == mp && user.Type == type); 
        }

        public List<User> ChercherTout()
        {
           List<string> tab = File.ReadAllLines(path).ToList(); // Lire tout les lignes du fichier
            List<User> listUsers = new List<User>(); // Créeer une liste de users
            foreach(string line in tab) // Pour chaque ligne
            {

                string[] tabDecomposer = line.Split(";-)"); // Decomposer la ligne

                // Créeer user
                User user = new User();
                user.Nom = tabDecomposer[0];
                user.Prenom = tabDecomposer[1];
                user.Telephone = tabDecomposer[2];
                user.Type = bool.Parse(tabDecomposer[3]);
                user.AdrNum = int.Parse(tabDecomposer[4]);
                user.AdrRue = tabDecomposer[5];
                user.AdrVille = tabDecomposer[6];
                user.AdrProvince = tabDecomposer[7];
                user.AdrCP = tabDecomposer[8];
                user.Login = tabDecomposer[9];
                user.MotPasse = tabDecomposer[10];
                listUsers.Add(user);


            }
            return listUsers; // Retourner la liste de users

            
        }

        public void Modifier(User user)
        {
            Supprimer(user); // Supprimer l'ancien user
            Ajouuter(user); // Ajouter le nouveau user
        }

        public void Supprimer(User user)
        {
            //créé une liste d'utilisateur 
            List<User> list = ChercherTout();
            //supprime l'utilisateur de la liste
            list.Remove(user);
            //vide le fichier
            File.WriteAllText(path, "");
            //ajoute les utilisateurs de la liste dans le fichier
            foreach (User u in list)
            {
                Ajouuter(u);
            }
        }
    }
}
