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
        public static List<TypePayload> getAstreList()
        {
            var typePayloads = new List<TypePayload>();

            try
            {
                string sql = "SELECT * FROM type_payload;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TypePayload typePayload = new TypePayload(dr.GetString(0), dr.GetString(1));
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
    }
}
