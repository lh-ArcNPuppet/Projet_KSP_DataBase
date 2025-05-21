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
        public static List<Payload> getPayloadList()
        {
            var payloads = new List<Payload>();

            try
            {
                string sql = "SELECT * FROM Vue_Payload;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Payload payload = new Payload(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetDecimal(4), dr.GetInt32(5), dr.GetString(6));
                    //Console.Write(lanceur);
                    payloads.Add(payload);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return payloads;
        }
    }
}
