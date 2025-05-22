using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_TypePayload
    {
        public static List<DB_TypePayload> getTypePayloadList()
        {
            var typePayloads = new List<DB_TypePayload>();

            try
            {
                string sql = "SELECT * FROM type_payload;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_TypePayload typePayload = new DB_TypePayload(dr.GetString(0), dr.GetString(1));
                    //Console.Write(typePayload);
                    typePayloads.Add(typePayload);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return typePayloads;
        }

        public static string getCodeByLibelle(string libelle)
        {
            string res = "";

            try
            {
                string sql = "SELECT * FROM type_payload WHERE libelle = @libelle;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypePayload tp = new DB_TypePayload(dr.GetString(0), dr.GetString(1));
                            res = tp.getCode();
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
                string sql = "SELECT * FROM type_payload WHERE code = @code;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypePayload tp = new DB_TypePayload(dr.GetString(0), dr.GetString(1));
                            res = tp.getLibelle();
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
