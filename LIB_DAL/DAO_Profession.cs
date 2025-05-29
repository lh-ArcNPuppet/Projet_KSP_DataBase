using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LIB_DAL
{
    public class DAO_Profession
    {
        public static List<DB_TypeProfession> getProfessionList()
        {
            var professions = new List<DB_TypeProfession>();

            try
            {
                if (BDD_Connect.cnx.State != System.Data.ConnectionState.Open)
                    BDD_Connect.cnx.Open();

                string sql = "SELECT * FROM type_profession;";

                using (var cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var profession = new DB_TypeProfession(dr.GetInt32(0), dr.GetString(1));
                        professions.Add(profession);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.Message);
            }

            return professions;
        }

        public static int getIdByLibelle(string libelle)
        {
            int res = 0;

            try
            {
                string sql = "SELECT * FROM type_profession WHERE libelle = @libelle;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypeProfession tpro = new DB_TypeProfession(dr.GetInt32(0), dr.GetString(1));
                            res = tpro.getId();
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

        public static string getLibelleById(int id)
        {
            string res = "";

            try
            {
                string sql = "SELECT * FROM type_profession WHERE id = @id;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypeProfession tpro = new DB_TypeProfession(dr.GetInt32(0), dr.GetString(1));
                            res = tpro.getLibelle();
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

        public static DB_TypeProfession getProfession(int idProfession)
        {
            try
            {
                string sql =
                    "SELECT * " +
                    "FROM type_profession " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idProfession);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_TypeProfession tpro = new DB_TypeProfession(
                                    dr.GetInt32(0),
                                    dr.GetString(1)
                                );

                                return tpro;
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

        public static bool createTypeProfession(DB_TypeProfession newProfession)
        {
            try
            {
                string sql =
                    "INSERT INTO type_profession(id, libelle) " +
                    "VALUES (" +
                    "@id, " +
                    "@libelle);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newProfession.getId());
                        cmd.Parameters.AddWithValue("@libelle", newProfession.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Type profession");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool updateTypeProfession(DB_TypeProfession newProfession)
        {
            try
            {
                string sql =
                    "UPDATE type_profession " +
                    "SET " +
                    "libelle = @libelle " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newProfession.getId());
                        cmd.Parameters.AddWithValue("@libelle", newProfession.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Type profession");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteTypeProfession(int idProfession)
        {
            try
            {
                string sql =
                    "DELETE FROM type_profession " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idProfession);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Type profession");

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
