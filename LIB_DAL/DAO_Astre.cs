using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;

namespace LIB_DAL
{
    public class DAO_Astre
    {
        public static List<Astre> getAstreList()
        {
            var astres = new List<Astre>();

            try
            {
                string sql = "SELECT * FROM vue_astre;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Astre astre = new Astre(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                    //Console.Write(astre);
                    astres.Add(astre);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return astres;
        }

        public static List<Astre> getAstres()
        {
            try
            {
                List<Astre> res = new List<Astre>();
                string sql = "SELECT * FROM Vue_Astre;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Astre a = new Astre(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                    res.Add(a);
                    //Console.WriteLine(a);
                }

                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }

        public static decimal getSurfaceGravityByName(string nom)
        {
            decimal res = 0;
            try
            {
                string sql =
                    "SELECT graviteSurface FROM Astre " +
                    "WHERE nom = @nom;";

                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                cmd.Parameters.AddWithValue("@nom", nom);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    res = dr.GetDecimal(0);
                }
                dr.Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
                return 0;
            }
            
        }

    }
}
