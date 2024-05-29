using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOBGAMEBLOG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // Affiche une boîte de dialogue avec un message de confirmation et des boutons "Oui" et "Non"       Dialog result retourne un choix de l'utilisateur ex DilaogResut.None ne retourne rien
            DialogResult check = MessageBox.Show("Etes vous sur de vouloir quitter ?", // Message à afficher
                "Message de confirmation", // Titre de la boîte de dialogue
                MessageBoxButtons.YesNo, // Boutons disponibles : "Oui" et "Non"
                MessageBoxIcon.Question); // Icône de la boîte de dialogue : une icône de question

            // La variable 'check' stocke le résultat de la boîte de dialogue, c'est-à-dire le bouton sur lequel l'utilisateur a cliqué

            // Si dialog result =  oui on change de page
            if (check == DialogResult.Yes)
            {
                //Création d'une nouvelle instance de la classe
                Form1 loginForm = new Form1();
                //montrer la nouvelle page de login form
                loginForm.Show();
                //cacher la page actuelle
                this.Hide();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            userControl1.Visible = false;
            article_Commentaire1.Visible = false;

        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            userControl1.Visible = true;
            article_Commentaire1.Visible = false;
        }

        private void article_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            userControl1.Visible = false;
            article_Commentaire1.Visible = true;
        }
    }
}
