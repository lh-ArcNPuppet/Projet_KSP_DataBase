using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Astre
    {
        //Attributs privés
        private int id;
        private string nom;
        private string type;
        private string systemeRelatif;

        //Constructeur
        public Astre(int id, string nom, string type, string systemeR)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.systemeRelatif = systemeR;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public string getType() { return this.type; }
        public string getRelatedSystem() { return this.systemeRelatif; }

        //Accesseurs - Setter
        public void setName(string nom) { this.nom = nom; }
        public void setType(string type) { this.type = type; }
        public void setRelatedSystem(string systemR) { this.systemeRelatif = systemR; }
    }
}
