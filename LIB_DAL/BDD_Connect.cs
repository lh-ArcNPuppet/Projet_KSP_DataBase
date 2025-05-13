using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class BDD_Connect
    {
        private static bool connecte = false;
        public static SqlConnection cnx;

        public static bool openConnexion()
        {
            cnx = new SqlConnection();

            //Informations de connexion relative au serveur SQL Server
            //string dataSource = "Data Source=" + "SRV-SQL\\SQL_SLAM";
            //string initialCatalog = "Initial Catalog=" + "BD_STOCK2";

            string dataSource = "Data Source=" + "PC-F_Louis\\SQLEXPRESS";
            string initialCatalog = "Initial Catalog=" + "KSP_DB";

            string integratedSecurity = "Integrated Security=" + "SSPI";

            cnx.ConnectionString = dataSource + ";" + initialCatalog + ";" + integratedSecurity;
            try
            {
                cnx.Open();
                connecte = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string showConnexion()
        {
            return "Connecté sur le serveur " + cnx.DataSource + " ➔ " + cnx.Database + "\nEtat = " + cnx.State;
        }

        public static void closeConnexion()
        {
            cnx.Close();
            connecte = false;
        }
    }
}
