using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;

namespace LIB_DAL
{
    public class DAO_Mission
    {
        public static List<DB_Mission> getMissionsList()
        {
            var missions = new List<DB_Mission>();

            try
            {
                string sql = "SELECT * FROM Vue_Mission;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_Mission mission = new DB_Mission(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDateTime(3),
                        dr.GetDateTime(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9),
                        dr.GetString(10)
                        );
                    //Console.Write(mission);
                    missions.Add(mission);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return missions;
        }

        public static bool createMission(DB_Mission newMission)
        {
            try
            {
                string sql =
                    "INSERT INTO mission(" +
                    "nom, " +
                    "idStatusMission, " +
                    "idLanceur, " +
                    "coutTotaux, " +
                    "listePayload, " +
                    "dateHeureDebut, " +
                    "dateHeureFin, " +
                    "dureeMission, " +
                    "listeAstronaute, " +
                    "idAstre, " +
                    "idSysteme, " +
                    "objectif, " +
                    "idSituationActuelle, " +
                    "resultatMission, " +
                    "commentaire) " +

                    "VALUES (" +
                    "@nom, " +
                    "@idStatusMission, " +
                    "@idLanceur, " +
                    "@coutTotaux, " +
                    "@listePayload, " +
                    "@dateHeureDebut, " +
                    "@dateHeureFin, " +
                    "@dureeMission, " +
                    "@listeAstronaute, " +
                    "@idAstre, " +
                    "@idSysteme, " +
                    "@objectif, " +
                    "@idSituationActuelle, " +
                    "@resultatMission, " +
                    "@commentaire);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", newMission.getName());
                        cmd.Parameters.AddWithValue("@idStatusMission", newMission.getIdMissionState());
                        cmd.Parameters.AddWithValue("@idLanceur", newMission.getIdLanceur());
                        cmd.Parameters.AddWithValue("@coutTotaux", newMission.getCost());
                        cmd.Parameters.AddWithValue("@listePayload", newMission.getPayloadList());
                        cmd.Parameters.AddWithValue("@dateHeureDebut", newMission.getDateTimeMissionStart());
                        cmd.Parameters.AddWithValue("@dateHeureFin", newMission.getDateTimeMissionEnd());
                        cmd.Parameters.AddWithValue("@dureeMission", newMission.getMissionDuration());
                        cmd.Parameters.AddWithValue("@listeAstronaute", newMission.getAstronautList());
                        cmd.Parameters.AddWithValue("@idAstre", newMission.getIdAstre());
                        cmd.Parameters.AddWithValue("@idSysteme", newMission.getIdSysteme());
                        cmd.Parameters.AddWithValue("@objectif", newMission.getObjectif());
                        cmd.Parameters.AddWithValue("@idSituationActuelle", newMission.getIdActualSituation());
                        cmd.Parameters.AddWithValue("@resultatMission", newMission.getResultsMission());
                        cmd.Parameters.AddWithValue("@commentaire", newMission.getComments());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Mission");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static DB_Mission getMission(int numVol)
        {
            try
            {
                string sql =
                    "SELECT * FROM vue_mission_full WHERE Num_vol = @numVol;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@numVol", numVol);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_Mission mission = new DB_Mission(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetString(3),
                                    dr.GetInt32(4),
                                    dr.GetString(5),
                                    dr.GetDateTime(6),
                                    dr.GetDateTime(7),
                                    dr.GetString(8),
                                    dr.GetString(9),
                                    dr.GetString(10),
                                    dr.GetString(11),
                                    dr.GetString(12),
                                    dr.GetString(13),
                                    dr.GetString(14),
                                    dr.GetString(15)
                                );
                                return mission;
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

        public static bool updateMission(DB_Mission newMission)
        {
            try
            {
                string sql =
                    "UPDATE mission " +
                    "SET " +
                    "nom = @nom, " +
                    "idStatusMission = @idStatusMission, " +
                    "idLanceur = @idLanceur, " +
                    "coutTotaux = @coutTotaux, " +
                    "listePayload = @listePayload, " +
                    "dateHeureDebut = @dateHeureDebut, " +
                    "dateHeureFin = @dateHeureFin, " +
                    "dureeMission = @dureeMission, " +
                    "listeAstronaute = @listeAstronaute, " +
                    "idAstre = @idAstre, " +
                    "idSysteme = @idSysteme, " +
                    "objectif = @objectif, " +
                    "idSituationActuelle = @idSituationActuelle, " +
                    "resultatMission = @resultatMission, " +
                    "commentaire = @commentaire " +
                    "WHERE mission.numVol = @numVol;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@numVol", newMission.getNumFlight());
                        cmd.Parameters.AddWithValue("@nom", newMission.getName());
                        cmd.Parameters.AddWithValue("@idStatusMission", newMission.getIdMissionState());
                        cmd.Parameters.AddWithValue("@idLanceur", newMission.getIdLanceur());
                        cmd.Parameters.AddWithValue("@coutTotaux", newMission.getCost());
                        cmd.Parameters.AddWithValue("@listePayload", newMission.getPayloadList());
                        cmd.Parameters.AddWithValue("@dateHeureDebut", newMission.getDateTimeMissionStart());
                        cmd.Parameters.AddWithValue("@dateHeureFin", newMission.getDateTimeMissionEnd());
                        cmd.Parameters.AddWithValue("@dureeMission", newMission.getMissionDuration());
                        cmd.Parameters.AddWithValue("@listeAstronaute", newMission.getAstronautList());
                        cmd.Parameters.AddWithValue("@idAstre", newMission.getIdAstre());
                        cmd.Parameters.AddWithValue("@idSysteme", newMission.getIdSysteme());
                        cmd.Parameters.AddWithValue("@objectif", newMission.getObjectif());
                        cmd.Parameters.AddWithValue("@idSituationActuelle", newMission.getIdActualSituation());
                        cmd.Parameters.AddWithValue("@resultatMission", newMission.getResultsMission());
                        cmd.Parameters.AddWithValue("@commentaire", newMission.getComments());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Mission");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteMission(int numVol)
        {
            try
            {
                string sql =
                    "DELETE FROM mission " +
                    "WHERE numVol = @numVol;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@numVol", numVol);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Mission");

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
