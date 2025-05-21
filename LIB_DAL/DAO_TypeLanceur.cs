using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_TypeLanceur
    {
        public static List<TypeLanceur> getTypeLanceurList()
        {
            var typesLanceur = new List<TypeLanceur>();

            try
            {
                string sql = "SELECT * FROM type_lanceur;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TypeLanceur typeLanceur = new TypeLanceur(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    typesLanceur.Add(typeLanceur);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return typesLanceur;
        }
    }
}
