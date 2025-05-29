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
        public static string userApplication;

        public static bool openConnexion(string mysqlUser, string mysqlPassword)
        {
            string server = "server=localhost";
            string db = "database=space_db";
            string user = "user id=" + mysqlUser;
            string pswd = "password=" + mysqlPassword;

            connectionString = server + ";" + user + ";" + pswd + ";" + db;

            cnx = new MySqlConnection(connectionString);
            cnx.Open();

            userApplication = mysqlUser;

            connecte = true;
            return connecte;
        }

        public static string showConnexion()
        {
            return "Connecté sur le serveur " + cnx.DataSource + " ➔ " + cnx.Database + "\nEtat = " + cnx.State;
        }

        public static void closeConnexion()
        {
            if ((cnx != null) && (cnx.State == System.Data.ConnectionState.Open)) { cnx.Close(); }
            connecte = false;
        }

        public static void sendLogAction(string operation, string table)
        {
            if (cnx == null || cnx.State != System.Data.ConnectionState.Open)
                throw new InvalidOperationException("[!] Connexion non ouverte.");

            string sql = "INSERT INTO Logs (utilisateur, operation, tableConcerne, dateHeure) " +
                         "VALUES (@utilisateur, @operation, @table, NOW())";

            using (var cmd = new MySqlCommand(sql, cnx))
            {
                cmd.Parameters.AddWithValue("@utilisateur", userApplication);
                cmd.Parameters.AddWithValue("@operation", operation);
                cmd.Parameters.AddWithValue("@table", table);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
