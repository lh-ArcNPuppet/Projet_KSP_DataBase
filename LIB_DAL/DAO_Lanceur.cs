using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LIB_DAL
{
    public class DAO_Lanceur
    {
        public static List<DB_Lanceur> getLanceurList()
        {
            var lanceurs = new List<DB_Lanceur>();

            try
            {
                string sql = "SELECT * FROM Vue_Lanceur;";
                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DB_Lanceur lanceur = new DB_Lanceur(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetInt32(3),
                                dr.GetInt32(4),
                                dr.GetDecimal(5),
                                dr.GetInt32(6),
                                dr.GetString(7)
                            );
                            lanceurs.Add(lanceur);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return lanceurs;
        }

        public static bool createLanceur(DB_Lanceur newLanceur)
        {
            try
            {
                string sql =
                    "INSERT INTO lanceur(nom, codeLanceur, nbrEtage, deltaV, leoMax, masse, longueur, largeur, hauteur, cout, commentaire) " +
                    "VALUES (@nom, @codeType, @nbrEtage, @deltaV, @leoMax, @masse, @longueur, @largeur, @hauteur, @cout, @commentaire);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", newLanceur.getName());
                        cmd.Parameters.AddWithValue("@codeType", newLanceur.getType());
                        cmd.Parameters.AddWithValue("@nbrEtage", newLanceur.getNbrStage());
                        cmd.Parameters.AddWithValue("@deltaV", newLanceur.getDeltaV());
                        cmd.Parameters.AddWithValue("@leoMax", newLanceur.getLEO_Max());
                        cmd.Parameters.AddWithValue("@masse", newLanceur.getWeight());
                        cmd.Parameters.AddWithValue("@longueur", newLanceur.getLenght());
                        cmd.Parameters.AddWithValue("@largeur", newLanceur.getWidht());
                        cmd.Parameters.AddWithValue("@hauteur", newLanceur.getHeight());
                        cmd.Parameters.AddWithValue("@cout", newLanceur.getCost());
                        cmd.Parameters.AddWithValue("@commentaire", newLanceur.getComment());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Lanceur");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static DB_Lanceur getLanceur(int id)
        {
            try
            {
                string sql =
                    "SELECT * FROM lanceur WHERE id = @id;";

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
                                DB_Lanceur lanceur = new DB_Lanceur(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetInt32(3),
                                    dr.GetInt32(4),
                                    dr.GetDecimal(5),
                                    dr.GetDecimal(6),
                                    dr.GetDecimal(7),
                                    dr.GetDecimal(8),
                                    dr.GetDecimal(9),
                                    dr.GetInt32(10),
                                    dr.GetString(11)
                                );
                                return lanceur;
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

        public static bool updateLanceur(DB_Lanceur newLanceur)
        {
            try
            {
                string sql =
                    "UPDATE lanceur " +
                    "SET " +
                    "nom = @nom, " +
                    "codeLanceur = @codeType, " +
                    "nbrEtage = @nbrEtage, " +
                    "deltaV = @deltaV, " +
                    "leoMax = @leoMax, " +
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
                        cmd.Parameters.AddWithValue("@id", newLanceur.getId());
                        cmd.Parameters.AddWithValue("@nom", newLanceur.getName());
                        cmd.Parameters.AddWithValue("@codeType", newLanceur.getType());
                        cmd.Parameters.AddWithValue("@nbrEtage", newLanceur.getNbrStage());
                        cmd.Parameters.AddWithValue("@deltaV", newLanceur.getDeltaV());
                        cmd.Parameters.AddWithValue("@leoMax", newLanceur.getLEO_Max());
                        cmd.Parameters.AddWithValue("@masse", newLanceur.getWeight());
                        cmd.Parameters.AddWithValue("@longueur", newLanceur.getLenght());
                        cmd.Parameters.AddWithValue("@largeur", newLanceur.getWidht());
                        cmd.Parameters.AddWithValue("@hauteur", newLanceur.getHeight());
                        cmd.Parameters.AddWithValue("@cout", newLanceur.getCost());
                        cmd.Parameters.AddWithValue("@commentaire", newLanceur.getComment());

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Lanceur");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteLanceur(int idLanceur)
        {
            try
            {
                string sql =
                    "DELETE FROM lanceur " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idLanceur);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Lanceur");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static int getIdByName(string nom)
        {
            int res = 0;

            try
            {
                string sql = "SELECT * FROM lanceur WHERE nom = @nom;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_Lanceur lanceur = new DB_Lanceur(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetInt32(3),
                                    dr.GetInt32(4),
                                    dr.GetDecimal(5),
                                    dr.GetDecimal(6),
                                    dr.GetDecimal(7),
                                    dr.GetDecimal(8),
                                    dr.GetDecimal(9),
                                    dr.GetInt32(10),
                                    dr.GetString(11)
                                );
                            res = lanceur.getId();
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
