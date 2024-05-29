using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MOBGAMEBLOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string loginBdd = "u967421408_benhatta";
        public string pwdBdd = "|aGt9v3L";

        private void exit_Click(object sender, EventArgs e)
        {
            //quitter l'app
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd +";password=" + pwdBdd + ";";
            MySqlConnection connexion = new MySqlConnection(connectionString);

            try
            {
                if (login_username.Text == "admin" && login_password.Text == "root")
                {
                    connexion.Open();
                    MessageBox.Show("Connexion Réussie");

                    //redirection 
                    this.Hide(); // Masquer la page actuelle
                    MainForm mForm = new MainForm();
                    mForm.Show(); // Ouvrir la nouvelle page
                }
                else
                {
                    MessageBox.Show("L'utilisateur ou le mot de passe est incorrecte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }

}
