using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_Dashboard
    {
        public static string getCurrentUsername()
        {
            string res = "";
            try
            {
                string sql = "SELECT SUBSTRING_INDEX(USER(), '@', 1) AS NomUtilisateur;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    res = dr.GetString(0);
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR SQL REQUEST : " + ex.Message);
                res = "Inconnu";
            }
            return res;
        }

        public static string getRoleUser()
        {
            string res = "";
            try
            {
                string sql = "SELECT TRIM(BOTH '`' FROM SUBSTRING_INDEX(CURRENT_ROLE(), '@', 1)) AS RoleNom;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    res = dr.GetString(0);
                    dr.Close();
                }
                if (res == "NONE")
                {
                    res = "Aucun rôle";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR SQL REQUEST : " + ex.Message);
                res = "Aucun rôle";
            }
            return res;
        }
    }
}
