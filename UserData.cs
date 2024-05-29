using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBGAMEBLOG
{
    internal class UserData
    {
        // Propriétés représentant les données utilisateur
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        //Connexion à la base de données
        private MySqlConnection connexion = new MySqlConnection("server=193.203.168.48;database=u967421408_benhatta;user id=u967421408_benhatta;password=|aGt9v3L;");


        // Méthode pour récupérer la liste des utilisateurs
        public List<UserData> UserListData()
        {
            List<UserData> listdata = new List<UserData>();

            try
            {
                // Ouvrir la connexion à la base de données
                connexion.Open();

                // Requête SELECT pour récupérer les utilisateurs
                string req = "SELECT * FROM utilisateurs";
                using (MySqlCommand command = new MySqlCommand(req, connexion))
                {
                    // Exécution de la requête SQL et récupération des résultats dans un MySqlDataReader
                    MySqlDataReader reader = command.ExecuteReader();

                    // Parcourir les lignes de résultats
                    while (reader.Read())
                    {
                        // Créer un nouvel objet UserData pour stocker les données utilisateur
                        UserData ud = new UserData();

                        // Récupérer les valeurs des colonnes de la ligne actuelle du résultat je 
                        ud.ID = (int)reader["id"];
                        ud.Name = reader["username"].ToString();
                        ud.Password = reader["password"].ToString();
                        ud.Email = reader["email"].ToString();
                        ud.Role = reader["role"].ToString();

                        // Ajouter l'objet UserData à la liste des données utilisateur
                        listdata.Add(ud);
                    }

                    // Fermer le MySqlDataReader après utilisation
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs potentielles lors de la récupération des utilisateurs
                Console.WriteLine("Erreur lors de la récupération des utilisateurs : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données dans tous les cas
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }

            // Retourner la liste des données utilisateur
            return listdata;
        }
    }
}
