using Questionnaire_Bruno.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_Bruno
{
    public partial class SupprimerUtilisateur : UserControl
    {
        List<User> listUser;
        public SupprimerUtilisateur()
        {
            InitializeComponent();
        }

        private void SupprimerUtilisateur_Load(object sender, EventArgs e)
        {
            // recuper la liste de utilisateur 
            listUser = UserDAOFactory.CreerUserDAO("FILE").ChercherTout();
            //Afecter la list a la grille
            dataGridSupprimerUtilisateur.DataSource = listUser;

        }


        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            //Supprimer user du ficher
            UserDAOFactory.CreerUserDAO("FILE").Supprimer(listUser[dataGridSupprimerUtilisateur.SelectedCells[0].RowIndex]);

            // Suprimer user de la list
            listUser.RemoveAt(dataGridSupprimerUtilisateur.SelectedCells[0].RowIndex);

            dataGridSupprimerUtilisateur.DataSource = null;
            dataGridSupprimerUtilisateur.DataSource = listUser;
        }
    }
}
