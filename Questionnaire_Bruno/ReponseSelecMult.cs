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
    public partial class ReponseSelecMult : UserControl
    {
        public ReponseSelecMult()
        {
            InitializeComponent();
        }

        public string ReponseSelecMult1 { get { return txtQuestion1.Text; } set { txtQuestion1.Text = value; } }
        public string ReponseSelecMult2 { get { return txtQuestion2.Text; } set { txtQuestion1.Text = value; } }
        public string ReponseSelecMult3 { get { return txtQuestion3.Text; } set { txtQuestion1.Text = value; } }
        public string ReponseSelecMult4 { get { return txtQuestion4.Text; } set { txtQuestion1.Text = value; } }
        public bool checkReponseSelecMult1 { get { return check1Question.Checked; } set { check1Question.Checked = value; } }
        public bool checkReponseSelecMult2 { get { return check2Question.Checked; } set { check1Question.Checked = value; } }
        public bool checkReponseSelecMult3 { get { return check3Question.Checked; } set { check1Question.Checked = value; } }
        public bool checkReponseSelecMult4 { get { return check4Question.Checked; } set { check1Question.Checked = value; } }
    }
}
