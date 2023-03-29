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
    }
}
