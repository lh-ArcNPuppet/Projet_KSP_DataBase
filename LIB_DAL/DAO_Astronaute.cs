using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Astronaute
    {
        public static List<Astronaute> getAstronauteList()
        {
            var astronautes = new List<Astronaute>();

            try
            {
                string sql = "SELECT * FROM vue_astronaute;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Astronaute astronaute = new Astronaute(dr.GetInt32(0), dr.GetString(1), dr.GetChar(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetString(6), dr.GetInt32(7));
                    //Console.Write(lanceur);
                    astronautes.Add(astronaute);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return astronautes;
        }
    }
}
