using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_Systeme
    {
        //Attributs privés
        private int id;
        private string libelle;
        private string description;

        //Constructeur
        public DB_Systeme(int id, string lib, string desc)
        {
            this.id = id;
            this.libelle = lib;
            this.description = desc;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getLibelle() { return this.libelle; }
        public string getDescription() { return this.description; }

        //Accesseurs - Setter
        public void setID(int id) { this.id = id; }
        public void setLibelle(string lib) { this.libelle = lib; }
        public void setDescription(string desc) { this.description = desc; }
    }
}
