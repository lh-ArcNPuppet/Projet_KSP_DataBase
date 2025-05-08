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
        private int type;
        private int astreParent;
        private int systemeParent;

        //Constructeur
        public Astre(int id, string nom, int type, int astreP, int systemeP)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.astreParent = astreP;
            this.systemeParent = systemeP;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public int getType() { return this.type; }
        public int getRelatedStar() { return this.astreParent; }
        public int getRelatedSystem() { return this.systemeParent; }

        //Accesseurs - Setter
        public void setId(int id) { this.id = id; }
        public void setName(string nom) { this.nom = nom; }
        public void setType(int t) { this.type = t; }
        public void setRelatedStar(int astreP) { this.astreParent = astreP; }
        public void setRelatedSystem(int systemP) { this.systemeParent = systemP; }
    }
}
