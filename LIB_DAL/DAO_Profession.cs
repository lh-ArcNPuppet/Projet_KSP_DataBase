using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Profession
    {
        public static List<TypeProfession> getProfessionList()
        {
            var professions = new List<TypeProfession>();

            try
            {
                string sql = "SELECT * FROM type_profession;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TypeProfession profession = new TypeProfession(dr.GetInt32(0), dr.GetString(1));
                    //Console.Write(typePayload);
                    professions.Add(profession);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return professions;
        }
    }
}
