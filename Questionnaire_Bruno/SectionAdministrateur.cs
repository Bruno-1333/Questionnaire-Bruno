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
    public partial class SectionAdministrateur : Form
    {
        public SectionAdministrateur()
        {
            InitializeComponent();
        }

        private void MenuAdmAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new AjouterUtilisateur());
        }

        private void MenuAdmSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new SupprimerUtilisateur());
        }

        private void MenuAdmModifierUtilisateur_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new ModifierUtilisateur());
        }

        private void MenuAdmAfficherUtilisateur_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new ChercherUtilisateurs());
        }

        private void MenuAdmAjouterQuestion_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new AjouterQuestion());
        }

        private void MenuAdmSupprimerQuestion_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new SupprimerQuestion());
        }

        private void MenuAdmModifierQuestion_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new ModifierQuestion());
        }

        private void MenuAdmConsulterQuestion_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            PannelPrincipale.Controls.Add(new ConsulterQuestions());
        }

        private void MenuAdmAfficherResultat_Click(object sender, EventArgs e)
        {
            PannelPrincipale.Controls.Clear();
            Resultat resultat = new Resultat();
            PannelPrincipale.Controls.Add(resultat);

            List<Questionnaire> questionnaires =  ResultatDAOFactory.CreerResultatDAO("FILE").ChercherTout();
            resultat.ResultatQuestionnaire(questionnaires);
        }
    }
}
