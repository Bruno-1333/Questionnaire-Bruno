﻿using Questionnaire_Bruno.DAOs;
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
    public partial class Resultat : UserControl
    {
        public Resultat()
        {
            InitializeComponent();
        }

        public void ResultatQuestionnaire(List<Questionnaire> questionnaires)
        {
            dataGridResultatQuestions.DataSource = null;
            dataGridResultatQuestions.DataSource = questionnaires;
        }
    }
}
