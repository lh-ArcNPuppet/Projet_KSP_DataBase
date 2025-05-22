using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_SituationActuelle
    {
        public static List<DB_SituationActuelle> getSituationActuelleList()
        {
            var situationActuelles = new List<DB_SituationActuelle>();

            try
            {
                string sql = "SELECT * FROM situation_actuelle;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_SituationActuelle situationActuelle = new DB_SituationActuelle(dr.GetInt32(0), dr.GetString(1));
                    //Console.Write(typePayload);
                    situationActuelles.Add(situationActuelle);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return situationActuelles;
        }
    }
}
