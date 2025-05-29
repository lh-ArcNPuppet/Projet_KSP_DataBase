using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Payload
    {
        public static List<DB_Payload> getPayloadList()
        {
            var payloads = new List<DB_Payload>();

            try
            {
                string sql = "SELECT * FROM vue_payload;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();

                    using (var cmd = new MySqlCommand(sql, cnx))
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DB_Payload payload = new DB_Payload(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetInt32(3),
                                dr.GetDecimal(4),
                                dr.GetInt32(5),
                                dr.GetString(6)
                            );
                            payloads.Add(payload);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }

            return payloads;
        }

        public static bool createPayload(DB_Payload newPayload)
        {
            try
            {
                string sql =
                    "INSERT INTO payload(nom, codePayload, deltaV, capaciteAstronaute, autonomieElectricite, autonomieNourriture, autonomieEau, autonomieOxygene, masse, longueur, largeur, hauteur, cout, commentaire) " +
                    "VALUES (" +
                    "@nom, " +
                    "@codePayload, " +
                    "@deltaV, " +
                    "@capaciteAstronaute, " +
                    "@autonomieEletricite, " +
                    "@autonomieNourriture, " +
                    "@autonomieEau, " +
                    "@autonomieOxygene, " +
                    "@masse, " +
                    "@longueur, " +
                    "@largeur, " +
                    "@hauteur, " +
                    "@cout, " +
                    "@commentaire);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", newPayload.getName());
                        cmd.Parameters.AddWithValue("@codePayload", newPayload.getType());
                        cmd.Parameters.AddWithValue("@deltaV", newPayload.getDeltaV());
                        cmd.Parameters.AddWithValue("@capaciteAstronaute", newPayload.getKerbalCapacity());
                        cmd.Parameters.AddWithValue("@autonomieEletricite", newPayload.getElecAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieNourriture", newPayload.getFoodAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieEau", newPayload.getWaterAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieOxygene", newPayload.getOxygenAutonomy());
                        cmd.Parameters.AddWithValue("@masse", newPayload.getWeight());
                        cmd.Parameters.AddWithValue("@longueur", newPayload.getLenght());
                        cmd.Parameters.AddWithValue("@largeur", newPayload.getWidht());
                        cmd.Parameters.AddWithValue("@hauteur", newPayload.getHeight());
                        cmd.Parameters.AddWithValue("@cout", newPayload.getCost());
                        cmd.Parameters.AddWithValue("@commentaire", newPayload.getComment());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Payload");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static DB_Payload getPayload(int id)
        {
            try
            {
                string sql =
                    "SELECT * FROM payload WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_Payload payload = new DB_Payload(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetInt32(3),
                                    dr.GetInt32(4),
                                    dr.GetString(5),
                                    dr.GetString(6),
                                    dr.GetString(7),
                                    dr.GetString(8),
                                    dr.GetDecimal(9),
                                    dr.GetDecimal(10),
                                    dr.GetDecimal(11),
                                    dr.GetDecimal(12),
                                    dr.GetInt32(13),
                                    dr.GetString(14)
                                );
                                return payload;
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

        public static bool updatePayload(DB_Payload newPayload)
        {
            try
            {
                string sql =
                    "UPDATE payload " +
                    "SET " +
                    "nom = @nom, " +
                    "codePayload = @codePayload, " +
                    "deltaV = @deltaV, " +
                    "capaciteAstronaute = @capaciteAstronaute, " +
                    "autonomieElectricite = @autonomieElectricite, " +
                    "autonomieNourriture = @autonomieNourriture, " +
                    "autonomieEau = @autonomieEau, " +
                    "autonomieOxygene = @autonomieOxygene, " +
                    "masse = @masse, " +
                    "longueur = @longueur, " +
                    "largeur = @largeur, " +
                    "hauteur = @hauteur, " +
                    "cout = @cout, " +
                    "commentaire = @commentaire " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newPayload.getId());
                        cmd.Parameters.AddWithValue("@nom", newPayload.getName());
                        cmd.Parameters.AddWithValue("@codePayload", newPayload.getType());
                        cmd.Parameters.AddWithValue("@deltaV", newPayload.getDeltaV());
                        cmd.Parameters.AddWithValue("@capaciteAstronaute", newPayload.getKerbalCapacity());
                        cmd.Parameters.AddWithValue("@autonomieElectricite", newPayload.getElecAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieNourriture", newPayload.getFoodAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieEau", newPayload.getWaterAutonomy());
                        cmd.Parameters.AddWithValue("@autonomieOxygene", newPayload.getOxygenAutonomy());
                        cmd.Parameters.AddWithValue("@masse", newPayload.getWeight());
                        cmd.Parameters.AddWithValue("@longueur", newPayload.getLenght());
                        cmd.Parameters.AddWithValue("@largeur", newPayload.getWidht());
                        cmd.Parameters.AddWithValue("@hauteur", newPayload.getHeight());
                        cmd.Parameters.AddWithValue("@cout", newPayload.getCost());
                        cmd.Parameters.AddWithValue("@commentaire", newPayload.getComment());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Payload");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deletePayload(int idPayload)
        {
            try
            {
                string sql =
                    "DELETE FROM payload " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idPayload);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Payload");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static int getIdByLibelle(string nomPayload)
        {
            int res = 0;

            try
            {
                string sql = "SELECT * FROM payload WHERE nom = @nom;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@nom", nomPayload);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_Payload payload = new DB_Payload(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetInt32(3),
                                    dr.GetInt32(4),
                                    dr.GetString(5),
                                    dr.GetString(6),
                                    dr.GetString(7),
                                    dr.GetString(8),
                                    dr.GetDecimal(9),
                                    dr.GetDecimal(10),
                                    dr.GetDecimal(11),
                                    dr.GetDecimal(12),
                                    dr.GetInt32(13),
                                    dr.GetString(14)
                                );
                            res = payload.getId();
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
    }
}
