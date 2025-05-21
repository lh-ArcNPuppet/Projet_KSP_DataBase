using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Systeme
    {
        public static List<Systeme> getSystemeList()
        {
            var systemes = new List<Systeme>();

            try
            {
                string sql = "SELECT * FROM status_mission;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Systeme systeme = new Systeme(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                    //Console.Write(typePayload);
                    systemes.Add(systeme);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return systemes;
        }
    }
}
