using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_TypeLanceur
    {
        //Attributs privés
        private string code;
        private string libelle;
        private string description;

        //Constructeur
        public DB_TypeLanceur(string code, string lib, string desc)
        {
            this.code = code;
            this.libelle = lib;
            this.description = desc;
        }

        //Accesseurs - Getter
        public string getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }
        public string getDescription() { return this.description; }

        //Accesseurs - Setter
        public void setCode(string code) { this.code = code; }
        public void setLibelle(string lib) { this.libelle = lib; }
        public void setDescription(string desc) { this.description = desc; }
    }
}
