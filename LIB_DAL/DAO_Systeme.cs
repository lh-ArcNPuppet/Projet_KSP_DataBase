using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Systeme
    {
        public static List<DB_Systeme> getSystemeList()
        {
            var systemes = new List<DB_Systeme>();

            try
            {
                if (BDD_Connect.cnx.State != System.Data.ConnectionState.Open)
                    BDD_Connect.cnx.Open();

                string sql = "SELECT * FROM systeme;";

                using (var cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var systeme = new DB_Systeme(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                        systemes.Add(systeme);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.Message);
            }

            return systemes;
        }

        public static int getIdByName(string nom)
        {
            int res = 0;

            try
            {
                string sql = "SELECT * FROM systeme WHERE nom = @nom;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_Systeme s = new DB_Systeme(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                            res = s.getId();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }

            return res;
        }

        public static DB_Systeme getSysteme(int idSysteme)
        {
            try
            {
                string sql =
                    "SELECT * " +
                    "FROM systeme " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idSysteme);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_Systeme s = new DB_Systeme(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2)
                                );

                                return s;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return null;
        }

        public static bool createSysteme(DB_Systeme newSystem)
        {
            try
            {
                string sql =
                    "INSERT INTO systeme(id, nom, description) " +
                    "VALUES (" +
                    "@id, " +
                    "@libelle, " +
                    "@description);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newSystem.getId());
                        cmd.Parameters.AddWithValue("@libelle", newSystem.getLibelle());
                        cmd.Parameters.AddWithValue("@description", newSystem.getDescription());

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool updateSysteme(DB_Systeme newSystem)
        {
            try
            {
                string sql =
                    "UPDATE systeme " +
                    "SET " +
                    "libelle = @libelle " +
                    "description = @description" +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newSystem.getId());
                        cmd.Parameters.AddWithValue("@libelle", newSystem.getLibelle());
                        cmd.Parameters.AddWithValue("@description", newSystem.getDescription());

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteSysteme(int idSystem)
        {
            try
            {
                string sql =
                    "DELETE FROM systeme " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idSystem);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }
    }
}
