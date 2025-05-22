using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_TypePayload
    {
        //Attributs privés
        private string code;
        private string libelle;

        //Constructeur
        public DB_TypePayload(string code, string lib)
        {
            this.code = code;
            this.libelle = lib;
        }

        //Accesseurs - Getter
        public string getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }

        //Accesseurs - Setter
        public void setCode(string code) { this.code = code; }
        public void setLibelle(string lib) { this.libelle = lib; }
    }
}
