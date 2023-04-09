using Questionnaire_Bruno.DAOs;

namespace Questionnaire_Bruno
{
    public partial class Form1 : Form
    {
        public User UtilisateurConnecte { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void Annuler_Click(object sender, EventArgs e)
        {
            textLogin.Text = string.Empty;
            textMotPasse.Text = string.Empty;
            radioButtonAdm.Checked = false;
            radioButtonUser.Checked = false;

        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string mp = textMotPasse.Text;
            bool type = (radioButtonUser.Checked == true) ? false : true;

            var userDAO = UserDAOFactory.CreerUserDAO("FILE");
            var user = userDAO.ChercherParLoginMPType(login, mp, type);

            if (user == null)
            {
                MessageBox.Show("Utilizateur NON trouvé :-(");

            }
            else
            {
                UtilisateurConnecte = user;
                if (type)
                {
                    MessageBox.Show("Utilizateur trouvé ;-)");
                    new SectionAdministrateur().Show();
                }
                else
                {

                    PanelUtilisateur panelUtilisateur = new PanelUtilisateur(user);
                    panelUtilisateur.Show();

                }


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormUser().Show();


        }
    }
}