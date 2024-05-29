using MySql.Data.MySqlClient;
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
    public partial class Dashboard : UserControl
    {
        public string loginBdd = "u967421408_benhatta";
        public string pwdBdd = "|aGt9v3L";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Connexion à la base de données
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd + ";password=" + pwdBdd + ";";
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connexion.Open();

                // Commande pour compter le nombre d'utilisateurs
                string req = "SELECT COUNT(*) FROM utilisateurs";
                using (MySqlCommand command = new MySqlCommand(req, connexion))
                {
                    // Exécutez la commande et obtenez le résultat (s'effectue à chaque exécution de commande)
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    // Afficher le nombre d'utilisateurs dans le label
                    label4.Text = count.ToString();
                }

                // Requête 2
                string req2 = "SELECT COUNT(*) FROM articles";
                using (MySqlCommand command2 = new MySqlCommand(req2, connexion))
                {
                    int count2 = Convert.ToInt32(command2.ExecuteScalar());
                    label7.Text = count2.ToString();
                }

                // Requête 3
                string req3 = "SELECT COUNT(*) FROM commentaires";
                using (MySqlCommand command3 = new MySqlCommand(req3, connexion))
                {
                    int count3 = Convert.ToInt32(command3.ExecuteScalar());
                    label5.Text = count3.ToString();
                }
            } // La connexion sera fermée automatiquement à la fin du bloc using
        }


        //-------------------------PANEL 5 UTILISATEURS-----------------------//
        private void panel5_Click(object sender, EventArgs e)
        {
            // Connexion à la base de données
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd + ";password=" + pwdBdd + ";";

            // Définir la requête SQL pour récupérer tous les articles
            string req = "SELECT * FROM utilisateurs";

            // Créer un DataTable pour stocker les résultats de la requête
            DataTable userTable = new DataTable();

            // Utiliser un adaptateur MySQL pour remplir le DataTable avec les résultats de la requête
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(req, connexion))
                {
                    try
                    {
                        // Ouvrir la connexion à la base de données
                        connexion.Open();

                        // Remplir le DataTable avec les résultats de la requête
                        adapter.Fill(userTable);

                        // Afficher les résultats dans le DataGridView
                        dataGridView1.DataSource = userTable;
                    }
                    catch (Exception ex)
                    {
                        // Gérer les erreurs éventuelles
                        MessageBox.Show("Une erreur est survenue lors de la récupération des utilisateurs : " + ex.Message);
                    }
                }
            }
        }


        //-------------------------PANEL 7 ARTICLES-----------------------//
        private void panel7_Click(object sender, EventArgs e)
        {
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd + ";password=" + pwdBdd + ";";
            string req = "SELECT * FROM articles";

            DataTable articleTable = new DataTable();

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(req, connexion))
                {
                    try
                    {
                        // Ouvrir la connexion à la base de données
                        connexion.Open();

                        // Remplir le DataTable avec les résultats de la requête
                        adapter.Fill(articleTable);

                        // Afficher les résultats dans le DataGridView
                        dataGridView1.DataSource = articleTable;
                    }
                    catch (Exception ex)
                    {
                        // Gérer les erreurs éventuelles
                        MessageBox.Show("Une erreur est survenue lors de la récupération des articles : " + ex.Message);
                    }
                }
            }
        }

        //-------------------------PANEL 6 COMMENTAIRES-----------------------//

        private void panel6_Click(object sender, EventArgs e)
        {
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd + ";password=" + pwdBdd + ";";

            // Définir la requête SQL pour récupérer tous les articles
            string req = "SELECT * FROM commentaires";

            // Créer un DataTable pour stocker les résultats de la requête
            DataTable commentTable = new DataTable();

            // Utiliser un adaptateur MySQL pour remplir le DataTable avec les résultats de la requête
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(req, connexion))
                {
                    try
                    {
                        // Ouvrir la connexion à la base de données
                        connexion.Open();

                        // Remplir le DataTable avec les résultats de la requête
                        adapter.Fill(commentTable);

                        // Afficher les résultats dans le DataGridView
                        dataGridView1.DataSource = commentTable;
                    }
                    catch (Exception ex)
                    {
                        // Gérer les erreurs éventuelles
                        MessageBox.Show("Une erreur est survenue lors de la récupération des commentaires : " + ex.Message);
                    }
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
