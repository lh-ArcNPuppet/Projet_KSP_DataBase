﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;

namespace LIB_DAL
{
    public class DAO_Astre
    {
        public static List<DB_Astre> getAstreList()
        {
            var astres = new List<DB_Astre>();

            try
            {
                string sql = "SELECT * FROM vue_astre;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_Astre astre = new DB_Astre(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                    //Console.Write(astre);
                    astres.Add(astre);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return astres;
        }

        public static decimal getSurfaceGravityByName(string nom)
        {
            decimal res = 0;
            try
            {
                string sql =
                    "SELECT graviteSurface FROM Astre " +
                    "WHERE nom = @nom;";

                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                cmd.Parameters.AddWithValue("@nom", nom);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    res = dr.GetDecimal(0);
                }
                dr.Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return 0;
            }
            
        }

        public static bool createAstre(DB_Astre newAstre)
        {
            try
            {
                string sql =
                    "INSERT INTO astre(nom, idTypeAstre, idSysteme, rayon, temperature, graviteAbsolue, graviteSurface, atmosphere, periodeOrbitale, description) " +
                    "VALUES (" +
                    "@nom, " +
                    "@idTypeAstre, " +
                    "@idSysteme, " +
                    "@rayon, " +
                    "@temp, " +
                    "@graviteAbsolue, " +
                    "@graviteSurface, " +
                    "@atmosphere, " +
                    "@periodeOrbitale, " +
                    "@description);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                        cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", newAstre.getName());
                        cmd.Parameters.AddWithValue("@idTypeAstre", newAstre.getType());
                        cmd.Parameters.AddWithValue("@idSysteme", newAstre.getRelatedSystem());
                        cmd.Parameters.AddWithValue("@rayon", newAstre.getRadius());
                        cmd.Parameters.AddWithValue("@graviteAbsolue", newAstre.getAbsoluteGravity());
                        cmd.Parameters.AddWithValue("@graviteSurface", newAstre.getSurfaceGravity());
                        cmd.Parameters.AddWithValue("@temp", newAstre.getTemperature());
                        cmd.Parameters.AddWithValue("@atmosphere", newAstre.getAthmosphere());
                        cmd.Parameters.AddWithValue("@periodeOrbitale", newAstre.getOrbitPeriod());
                        cmd.Parameters.AddWithValue("@description", newAstre.getDescription());

                        cmd.ExecuteNonQuery();
                    }
                }
                // Log l'action après succès
                BDD_Connect.sendLogAction("INSERT", "Astre");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static DB_Astre getAstre(int id)
        {
            try
            {
                string sql =
                    "SELECT astre.id, astre.nom, type_astre.libelle, systeme.nom, astre.rayon, astre.temperature, astre.graviteAbsolue, astre.graviteSurface, astre.atmosphere, astre.periodeOrbitale, astre.description " +
                    "FROM astre " +
                    "JOIN type_astre ON astre.idTypeAstre = type_astre.id " +
                    "JOIN systeme ON astre.idSysteme = systeme.id " +
                    "WHERE astre.id = @id;";

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
                                DB_Astre astre = new DB_Astre
                                    (
                                    dr.GetInt32(0), 
                                    dr.GetString(1), 
                                    dr.GetInt32(2), 
                                    dr.GetInt32(3),
                                    dr.GetDecimal(4),
                                    dr.GetInt32(5),
                                    dr.GetDecimal(6),
                                    dr.GetDecimal(7),
                                    dr.GetString(8),
                                    dr.GetString(9),
                                    dr.GetString(10)
                                    );

                                return astre;
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

        public static bool updateAstre(DB_Astre newAstre)
        {
            try
            {
                string sql =
                    "UPDATE astre " +
                    "SET " +
                    "nom = @nom, " +
                    "idTypeAstre = @idTypeAstre, " +
                    "idSysteme = @idSysteme, " +
                    "rayon = @rayon, " +
                    "temperature = @temp, " +
                    "graviteAbsolue = @graviteAbsolue, " +
                    "graviteSurface = @graviteSurface, " +
                    "atmosphere = @atmosphere, " +
                    "periodeOrbitale = @periodeOrbitale, " +
                    "description = @description " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newAstre.getId());
                        cmd.Parameters.AddWithValue("@nom", newAstre.getName());
                        cmd.Parameters.AddWithValue("@idTypeAstre", newAstre.getType());
                        cmd.Parameters.AddWithValue("@idSysteme", newAstre.getRelatedSystem());
                        cmd.Parameters.AddWithValue("@rayon", newAstre.getRadius());
                        cmd.Parameters.AddWithValue("@temp", newAstre.getTemperature());
                        cmd.Parameters.AddWithValue("@graviteAbsolue", newAstre.getAbsoluteGravity());
                        cmd.Parameters.AddWithValue("@graviteSurface", newAstre.getSurfaceGravity());
                        cmd.Parameters.AddWithValue("@atmosphere", newAstre.getAthmosphere());
                        cmd.Parameters.AddWithValue("@periodeOrbitale", newAstre.getOrbitPeriod());
                        cmd.Parameters.AddWithValue("@description", newAstre.getDescription());

                        cmd.ExecuteNonQuery();
                    }
                }
                // Log l'action après succès
                BDD_Connect.sendLogAction("UPDATE", "Astre");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return false;
            }
        }

        public static bool deleteAstre(int idAstre)
        {
            try
            {
                string sql =
                    "DELETE FROM astre " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idAstre);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Log l'action après succès
                BDD_Connect.sendLogAction("DELETE", "Astre");

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
                string sql = "SELECT * FROM astre WHERE nom = @nom;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_Astre astre = new DB_Astre(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetInt32(2),
                                    dr.GetInt32(3),
                                    dr.GetDecimal(4),
                                    dr.GetInt32(5),
                                    dr.GetDecimal(6),
                                    dr.GetDecimal(7),
                                    dr.GetString(8),
                                    dr.GetString(9),
                                    dr.GetString(10)
                                    );
                            res = astre.getId();
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
