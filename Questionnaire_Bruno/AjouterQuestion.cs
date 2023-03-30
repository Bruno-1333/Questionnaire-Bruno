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
    public partial class AjouterQuestion : UserControl
    {
        public AjouterQuestion()
        {
            InitializeComponent();
        }

        private void radioBtnQuestionVraiFaux_CheckedChanged(object sender, EventArgs e)
        {
            pnlBonneReponse.Controls.Clear();
            pnlBonneReponse.Controls.Add(new ReponseVraiFaux());
        }

        private void radioBtnQuestionSelecMult_CheckedChanged(object sender, EventArgs e)
        {
            pnlBonneReponse.Controls.Clear();
            pnlBonneReponse.Controls.Add(new ReponseSelecMult());
        }
    }
}
