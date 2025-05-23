using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LIB_DAL
{
    public class DAO_Astronaute
    {
        public static List<DB_Astronaute> getAstronauteList()
        {
            var astronautes = new List<DB_Astronaute>();

            try
            {
                if (BDD_Connect.cnx.State != System.Data.ConnectionState.Open)
                    BDD_Connect.cnx.Open();

                string sql = "SELECT * FROM vue_astronaute;";
                using (var cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var astronaute = new DB_Astronaute(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetChar(2),
                            dr.GetString(3),
                            dr.GetInt32(4),
                            dr.GetInt32(5),
                            dr.GetString(6),
                            dr.GetInt32(7)
                        );
                        astronautes.Add(astronaute);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }

            return astronautes;
        }

        public static DB_Astronaute getAstronaute(int id)
        {
            try
            {
                string sql =
                    "SELECT " +
                    "astronaute.id, " +
                    "astronaute.nom, " +
                    "astronaute.sexe, " +
                    "type_profession.libelle, " +
                    "astronaute.niveau, " +
                    "astronaute.tauxCourrage, " +
                    "astronaute.tauxStupidite, " +
                    "astronaute.estVeteran, " +
                    "astronaute.statusVital " +
                    "FROM astronaute " +
                    "JOIN Type_Profession ON Astronaute.idProfession = Type_Profession.id " +
                    "WHERE astronaute.id = @id;";

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
                                DB_Astronaute astronaute = new DB_Astronaute(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetChar(2),
                                    dr.GetString(3),
                                    dr.GetInt32(4),
                                    dr.GetInt32(5),
                                    dr.GetInt32(6),
                                    dr.GetInt32(7),
                                    dr.GetString(8)
                                );
                                Console.WriteLine(astronaute.getId());
                                Console.WriteLine(astronaute.getName());
                                Console.WriteLine(astronaute.getSexe());
                                Console.WriteLine(astronaute.getProfession());
                                Console.WriteLine(astronaute.getLevel());
                                Console.WriteLine(astronaute.getCourageRate());
                                Console.WriteLine(astronaute.getStupidityRate());
                                Console.WriteLine(astronaute.getVeteranState());
                                Console.WriteLine(astronaute.getVitalsState());

                                return astronaute;
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

        public static bool createAstronaute(DB_Astronaute newAstronaute)
        {
            try
            {
                string sql =
                    "INSERT INTO astronaute(nom, sexe, idProfession, niveau, tauxCourrage, tauxStupidite, estVeteran, statusVital) " +
                    "VALUES (" +
                    "@nom, " +
                    "@sexe, " +
                    "@idProfession, " +
                    "@niveau, " +
                    "@tauxCourrage, " +
                    "@tauxStupidite, " +
                    "@estVeteran, " +
                    "@statusVital);";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", newAstronaute.getName());
                        cmd.Parameters.AddWithValue("@sexe", newAstronaute.getSexe());
                        cmd.Parameters.AddWithValue("@idProfession", newAstronaute.getProfession());
                        cmd.Parameters.AddWithValue("@niveau", newAstronaute.getLevel());
                        cmd.Parameters.AddWithValue("@tauxCourrage", newAstronaute.getCourageRate());
                        cmd.Parameters.AddWithValue("@tauxStupidite", newAstronaute.getStupidityRate());
                        cmd.Parameters.AddWithValue("@estVeteran", newAstronaute.getVeteranState());
                        cmd.Parameters.AddWithValue("@statusVital", newAstronaute.getVitalsState());

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

        public static bool updateAstronaute(DB_Astronaute newAstronaute)
        {
            try
            {
                string sql =
                    "UPDATE astronaute " +
                    "SET " +
                    "nom = @nom, " +
                    "sexe = @sexe, " +
                    "idProfession = @idProfession, " +
                    "niveau = @niveau, " +
                    "tauxCourrage = @tauxCourrage, " +
                    "tauxStupidite = @tauxStupidite, " +
                    "estVeteran = @estVeteran, " +
                    "statusVital = @statusVital " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", newAstronaute.getId());
                        cmd.Parameters.AddWithValue("@nom", newAstronaute.getName());
                        cmd.Parameters.AddWithValue("@sexe", newAstronaute.getSexe());
                        cmd.Parameters.AddWithValue("@idProfession", newAstronaute.getProfession());
                        cmd.Parameters.AddWithValue("@niveau", newAstronaute.getLevel());
                        cmd.Parameters.AddWithValue("@tauxCourrage", newAstronaute.getCourageRate());
                        cmd.Parameters.AddWithValue("@tauxStupidite", newAstronaute.getStupidityRate());
                        cmd.Parameters.AddWithValue("@estVeteran", newAstronaute.getVeteranState());
                        cmd.Parameters.AddWithValue("@statusVital", newAstronaute.getVitalsState());

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

        public static bool deleteAstronaute(int idAstronaute)
        {
            try
            {
                string sql =
                    "DELETE FROM astronaute " +
                    "WHERE id = @id;";

                using (var cnx = new MySqlConnection(BDD_Connect.connectionString))
                {
                    cnx.Open();
                    using (var cmd = new MySqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@id", idAstronaute);

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
