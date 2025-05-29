using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_SituationActuelle
    {
        public static List<DB_SituationActuelle> getSituationActuelleList()
        {
            var situationActuelles = new List<DB_SituationActuelle>();

            try
            {
                string sql = "SELECT * FROM situation_actuelle;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_SituationActuelle situationActuelle = new DB_SituationActuelle(dr.GetInt32(0), dr.GetString(1));
                    //Console.Write(typePayload);
                    situationActuelles.Add(situationActuelle);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return situationActuelles;
        }

        public static DB_SituationActuelle getSituationActuelle(int idSituationActuelle)
        {
            try
            {
                string sql =
                    "SELECT * " +
                    "FROM situation_actuelle " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idSituationActuelle);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_SituationActuelle sa = new DB_SituationActuelle(
                                    dr.GetInt32(0),
                                    dr.GetString(1)
                                );

                                return sa;
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

        public static bool createSituationActuelle(DB_SituationActuelle newActualSituation)
        {
            try
            {
                string sql =
                    "INSERT INTO situation_actuelle(id, libelle) " +
                    "VALUES (" +
                    "@id, " +
                    "@libelle);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newActualSituation.getId());
                        cmd.Parameters.AddWithValue("@libelle", newActualSituation.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Situation actuelle");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool updateSituationActuelle(DB_SituationActuelle newActualSituation)
        {
            try
            {
                string sql =
                    "UPDATE situation_actuelle " +
                    "SET " +
                    "libelle = @libelle " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newActualSituation.getId());
                        cmd.Parameters.AddWithValue("@libelle", newActualSituation.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Situation actuelle");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteSituationActuelle(int idSituationActuelle)
        {
            try
            {
                string sql =
                    "DELETE FROM situation_actuelle " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idSituationActuelle);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Situation actuelle");

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
