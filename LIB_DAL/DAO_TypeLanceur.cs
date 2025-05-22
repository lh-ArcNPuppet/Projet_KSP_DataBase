using LIB_BLL;
using LIB_DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_TypeLanceur
    {
        public static List<DB_TypeLanceur> getTypeLanceurList()
        {
            var typesLanceur = new List<DB_TypeLanceur>();

            try
            {
                string sql = "SELECT * FROM type_lanceur;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DB_TypeLanceur typeLanceur = new DB_TypeLanceur(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                            typesLanceur.Add(typeLanceur);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }

            return typesLanceur;
        }
        public static string getCodeByLibelle(string libelle)
        {
            string res = "";

            try
            {
                string sql = "SELECT * FROM type_lanceur WHERE libelle = @libelle;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypeLanceur tl = new DB_TypeLanceur(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                            res = tl.getCode();
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
        public static string getLibelleByCode(string code)
        {
            string res = "";

            try
            {
                using (var conn = new MySqlConnection(BDD_Connect.connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM type_lanceur WHERE code = @code;";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DB_TypeLanceur tl = new DB_TypeLanceur(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                                res = tl.getLibelle();
                            }
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
