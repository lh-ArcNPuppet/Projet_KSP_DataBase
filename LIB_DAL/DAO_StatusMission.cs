using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_StatusMission
    {
        public static List<DB_StatusMission> getStatusMissionList()
        {
            var statusMissions = new List<DB_StatusMission>();

            try
            {
                string sql = "SELECT * FROM status_mission;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_StatusMission statusMission = new DB_StatusMission(dr.GetInt32(0), dr.GetString(1));
                    statusMissions.Add(statusMission);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return statusMissions;
        }

        public static DB_StatusMission getStatusMission(int idStatusMission)
        {
            try
            {
                string sql =
                    "SELECT * " +
                    "FROM status_mission " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idStatusMission);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_StatusMission sm = new DB_StatusMission(
                                    dr.GetInt32(0),
                                    dr.GetString(1)
                                );

                                return sm;
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

        public static bool createStatusMission(DB_StatusMission newStatusMission)
        {
            try
            {
                string sql =
                    "INSERT INTO status_mission(id, libelle) " +
                    "VALUES (" +
                    "@id, " +
                    "@libelle);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newStatusMission.getId());
                        cmd.Parameters.AddWithValue("@libelle", newStatusMission.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Status mission");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool updateStatusMission(DB_StatusMission newStatusMission)
        {
            try
            {
                string sql =
                    "UPDATE status_mission " +
                    "SET " +
                    "libelle = @libelle " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newStatusMission.getId());
                        cmd.Parameters.AddWithValue("@libelle", newStatusMission.getLibelle());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Status mission");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteStatusMission(int idStatusMission)
        {
            try
            {
                string sql =
                    "DELETE FROM status_mission " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idStatusMission);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Status mission");

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
