using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_TypeAstre
    {
        public static List<DB_TypeAstre> getTypeAstreList()
        {
            var typesAstre = new List<DB_TypeAstre>();

            try
            {
                string sql = "SELECT * FROM type_astre;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_TypeAstre typeAstre = new DB_TypeAstre(dr.GetInt32(0), dr.GetString(1));
                    typesAstre.Add(typeAstre);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return typesAstre;
        }

        public static int getIdByLibelle(string libelle)
        {
            int res = 0;

            try
            {
                string sql = "SELECT * FROM type_astre WHERE libelle = @libelle;";
                using (MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DB_TypeAstre ta = new DB_TypeAstre(dr.GetInt32(0), dr.GetString(1));
                            res = ta.getId();
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
