using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Lanceur
    {
        public static List<Lanceur> getLanceurList()
        {
            var lanceurs = new List<Lanceur>();

            try
            {
                string sql = "SELECT * FROM Vue_Lanceur;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lanceur lanceur = new Lanceur(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetDecimal(5), dr.GetInt32(6), dr.GetString(7));
                    //Console.Write(lanceur);
                    lanceurs.Add(lanceur);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return lanceurs;
        }
    }
}
