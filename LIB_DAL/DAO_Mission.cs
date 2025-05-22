using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;

namespace LIB_DAL
{
    public class DAO_Mission
    {
        public static List<DB_Mission> getMissionsList()
        {
            var missions = new List<DB_Mission>();

            try
            {
                string sql = "SELECT * FROM Vue_Mission;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_Mission mission = new DB_Mission(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9));
                    //Console.Write(mission);
                    missions.Add(mission);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return missions;
        }
    }
}
