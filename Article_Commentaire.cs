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
    public partial class Article_Commentaire : UserControl
    {
        public string loginBdd = "u967421408_benhatta";
        public string pwdBdd = "|aGt9v3L";

        //Connextion a la base de donnée stockée dans la variable public connexion
        public MySqlConnection connexion = new MySqlConnection("server=193.203.168.48;database=u967421408_benhatta;user id=u967421408_benhatta;password=|aGt9v3L;");

        public Article_Commentaire()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Article_Commentaire_Load(object sender, EventArgs e)
        {
            // Connexion à la base de données
            string connectionString = "server=193.203.168.48;database=" + loginBdd + ";user id=" + loginBdd + ";password=" + pwdBdd + ";";

            // Définir les requêtes SQL pour récupérer tous les articles et tous les commentaires
            string reqArticles = "SELECT * FROM articles";
            string reqComments = "SELECT * FROM commentaires";

            // Créer deux DataTables pour stocker les résultats des requêtes
            DataTable articleTable = new DataTable();
            DataTable commentTable = new DataTable();

            // Utiliser une seule connexion pour les deux requêtes
            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connexion.Open();

                    // Récupérer les articles
                    using (MySqlDataAdapter adapterArticles = new MySqlDataAdapter(reqArticles, connexion))
                    {
                        // Remplir le DataTable avec les résultats de la requête
                        adapterArticles.Fill(articleTable);
                    }

                    // Récupérer les commentaires
                    using (MySqlDataAdapter adapterComments = new MySqlDataAdapter(reqComments, connexion))
                    {
                        // Remplir le DataTable avec les résultats de la requête
                        adapterComments.Fill(commentTable);
                    }

                    // Afficher les résultats dans les DataGridViews
                    dataGridView1.DataSource = articleTable;
                    dataGridView2.DataSource = commentTable;
                }
                catch (Exception ex)
                {
                    // Gérer les erreurs éventuelles
                    MessageBox.Show("Une erreur est survenue lors de la récupération des données : " + ex.Message);
                }
            }
        }

        private void deleteComm_btn_Click(object sender, EventArgs e)
        {

            // Vérifier si la connexion à la base de données est fermée
            if (connexion.State == ConnectionState.Closed)
            {
                try
                {
                    connexion.Open();


                    // Insérer les données de l'utilisateur dans la base de données
                    string DeleteData = "DELETE FROM commentaires WHERE id = @userId";
                    using (MySqlCommand command = new MySqlCommand(DeleteData, connexion))
                    {
                        // Ajouter les valeurs des paramètres //reliée les valeurs des champs saisies avec l'@....
                        command.Parameters.AddWithValue("@userId", id_comment.Text.Trim());

                        // Exécuter la commande SQL
                        command.ExecuteNonQuery();

                        // Mettre à jour l'affichage des données utilisateur
                        // displayUserData();

                        MessageBox.Show("Le commentaire à été supprimée !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //réactualisation de l'affichage
                        Article_Commentaire_Load(sender, e);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connexion.Close();
                }
            }
        }

        private void deleteArticle_btn_Click(object sender, EventArgs e)
        {
            if (connexion.State == ConnectionState.Closed)
            {
                try
                {
                    connexion.Open();


                    // Insérer les données de l'utilisateur dans la base de données
                    string DeleteData = "DELETE FROM articles WHERE id = @userId";
                    using (MySqlCommand command = new MySqlCommand(DeleteData, connexion))
                    {
                        // Ajouter les valeurs des paramètres //reliée les valeurs des champs saisies avec l'@....
                        command.Parameters.AddWithValue("@userId", id_article.Text.Trim());

                        // Exécuter la commande SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("L'article à été supprimée !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //réactualisation de l'affichage
                        Article_Commentaire_Load(sender, e);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connexion.Close();
                }
            }
        }

        private void id_article_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
