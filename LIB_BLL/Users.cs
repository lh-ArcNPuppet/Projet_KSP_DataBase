using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Users
    {
        //Attributs privés
        private int id;
        private string username;
        private string pswd;

        //Constructeur
        public Users(int id, string username, string pswd)
        {
            this.id = id;
            this.username = username;
            this.pswd = pswd;
        }

        //Accesseurs - Getter
        public int getID() { return this.id; }
        public string getUsername() { return this.username; }
        public string getPassword() { return this.pswd; }

        //Accesseurs - Setter
        public void setID(int id) { this.id = id; }
        public void setUsername(string username) { this.username = username; }
        public void setPassword(string pswd) { this.pswd = pswd; }
    }
}
