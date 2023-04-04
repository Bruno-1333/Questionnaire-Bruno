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
    public partial class ReponseVraiFaux : UserControl
    {
        public ReponseVraiFaux()
        {
            InitializeComponent();
        }
        public bool VraiChecked
        {
            get { return radioBtnReponseVrai.Checked; }
            set { radioBtnReponseVrai.Checked = value; }
        }
        public bool FauxChecked
        {
            get { return radioBtnReponseFaux.Checked; }
            set { radioBtnReponseFaux.Checked = value; }
        }
    }
}
