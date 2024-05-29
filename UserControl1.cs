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

  
    public partial class UserControl1 : UserControl
    {
        //Connextion a la base de donnée stockée dans la variable public connexion
        public MySqlConnection connexion = new MySqlConnection("server=193.203.168.48;database=u967421408_benhatta;user id=u967421408_benhatta;password=|aGt9v3L;");

        public UserControl1()
        {
            InitializeComponent();

            // TO DISPLAY THE VIEW OF DATA to your grid view
            displayUserData();
        }

        public void displayUserData()
        {
            // Crée une nouvelle instance de la classe UserData en utilisant le constructeur par défaut
            UserData ud = new UserData();

            // Appelle la méthode UserListData() de l'objet ud pour récupérer une liste d'objets UserData
            List<UserData> listData = ud.UserListData();

            // Lie la source de données de la dataGridView1 à la liste d'objets UserData récupérée
            dataGridView1.DataSource = listData;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // Vérifier si tous les champs sont remplis
            if (addUser_id.Text == "" || addUser_fullname.Text == "" || addUser_password.Text == "" || addUser_email.Text == "" || addUser_role.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Vérifier si la connexion à la base de données est fermée
                if (connexion.State == ConnectionState.Closed)
                {
                    try
                    {
                        connexion.Open();

                        // Vérifier si l'utilisateur existe déjà en fonction de son ID
                        string checkUserID = "SELECT COUNT(*) FROM utilisateurs WHERE id = @userId";
                        using (MySqlCommand checkUser = new MySqlCommand(checkUserID, connexion))
                        {
                            // Ajouter le paramètre pour l'ID avec sa valeur à la commande. Lier le @id avec le id.Text entrée. Trim() pour effacer les espaces
                            checkUser.Parameters.AddWithValue("@userId", addUser_id.Text.Trim());

                            // Exécuter la commande SQL et récupérer le résultat     ExecuteScalar est utilisé pour récuperer une valeur en général soit un count...
                            long count = (long)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("L'utilisateur existe déjà : " + addUser_id.Text.Trim(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insérer les données de l'utilisateur dans la base de données
                                string insertData = "INSERT INTO utilisateurs (id, username, password, email, role) VALUES (@userId, @fullname, @password, @email, @role)";
                                using (MySqlCommand command = new MySqlCommand(insertData, connexion))
                                {
                                    // Ajouter les valeurs des paramètres //reliée les valeurs des champs saisies avec l'@....
                                    command.Parameters.AddWithValue("@userId", addUser_id.Text.Trim());
                                    command.Parameters.AddWithValue("@fullname", addUser_fullname.Text.Trim());
                                    command.Parameters.AddWithValue("@password", addUser_password.Text.Trim());
                                    command.Parameters.AddWithValue("@email", addUser_email.Text.Trim());
                                    command.Parameters.AddWithValue("@role", addUser_role.Text.Trim());

                                    // Exécuter la commande SQL
                                    command.ExecuteNonQuery();

                                    // Mettre à jour l'affichage des données utilisateur
                                    displayUserData();

                                    MessageBox.Show("Ajouté avec succès !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
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
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Vérifier si tous les champs sont remplis
            if (addUser_id.Text == "" || addUser_fullname.Text == "" || addUser_password.Text == "" || addUser_email.Text == "" || addUser_role.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Vérifier si la connexion à la base de données est fermée
                if (connexion.State == ConnectionState.Closed)
                {
                    try
                    {
                        connexion.Open();


                        // Insérer les données de l'utilisateur dans la base de données
                        string updateData = "UPDATE utilisateurs SET username = @fullname, password = @password, email = @email, role = @role WHERE id = @userId";
                        using (MySqlCommand command = new MySqlCommand(updateData, connexion))
                        {
                            // Ajouter les valeurs des paramètres //reliée les valeurs des champs saisies avec l'@....
                            command.Parameters.AddWithValue("@userId", addUser_id.Text.Trim());
                            command.Parameters.AddWithValue("@fullname", addUser_fullname.Text.Trim());
                            command.Parameters.AddWithValue("@password", addUser_password.Text.Trim());
                            command.Parameters.AddWithValue("@email", addUser_email.Text.Trim());
                            command.Parameters.AddWithValue("@role", addUser_role.Text.Trim());

                            // Exécuter la commande SQL
                            command.ExecuteNonQuery();

                            // Mettre à jour l'affichage des données utilisateur
                            displayUserData();
                            

                            MessageBox.Show("La modification à été ajoutée !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }



        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Vérifier si la connexion à la base de données est fermée
            if (connexion.State == ConnectionState.Closed)
            {
                try
                {
                    connexion.Open();


                    // Insérer les données de l'utilisateur dans la base de données
                    string DeleteData = "DELETE FROM utilisateurs WHERE id = @userId";
                    using (MySqlCommand command = new MySqlCommand(DeleteData, connexion))
                    {
                        // Ajouter les valeurs des paramètres //reliée les valeurs des champs saisies avec l'@....
                        command.Parameters.AddWithValue("@userId", addUser_id.Text.Trim());

                        // Exécuter la commande SQL
                        command.ExecuteNonQuery();

                        // Mettre à jour l'affichage des données utilisateur
                        displayUserData();

                        MessageBox.Show("L'utilisateurs à été supprimée !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            addUser_id.Text = "";
            addUser_fullname.Text = "";
            addUser_password.Text = "";
            addUser_email.Text = "";
            addUser_role.Text = "";
        }
    }
}
