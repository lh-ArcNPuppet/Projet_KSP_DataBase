using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace LIB_DAL
{
    public class BDD_Connect
    {
        private static bool connecte = false;
        public static MySqlConnection cnx;
        public static string connectionString;

        public static bool openConnexion(string userIn, string pswdIn)
        {
            string server = "server=localhost";
            string db = "database=space_db";
            string user = "user id=" + userIn;
            string pswd = "password=" + pswdIn;

            connectionString = server + ";" + user + ";" + pswd + ";" + db;

            cnx = new MySqlConnection(connectionString);
            cnx.Open();
            connecte = true;
            return connecte;
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
