using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Payload
    {
        //Attributs privés
        private int id;
        private string nom;
        private string type;
        private int deltaV;
        private int capKerbal;

        private string autoResElec;
        private string autoResFood;
        private string autoResWater;
        private string autoResOxygen;

        private decimal masse;
        private decimal longueur;
        private decimal largueur;
        private decimal hauteur;
        private int cout;
        private string commentaire;


        //Constructeur
        public Payload(int id, string nom, string t, int dV, int capKerb, string aElec, string aFood, string aWater, string aOx, decimal m, decimal lon, decimal lar, decimal hau, int cost, string com)
        {
            this.id = id;
            this.nom = nom;
            this.type = t;
            this.deltaV = dV;
            this.capKerbal = capKerb;
            this.autoResElec = aElec;
            this.autoResFood = aFood;
            this.autoResWater = aWater;
            this.autoResOxygen = aOx;
            this.masse = m;
            this.longueur = lon;
            this.largueur = lar;
            this.hauteur = hau;
            this.cout = cost;
            this.commentaire = com;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public string getType() { return this.type; }
        public int getDeltaV() { return this.deltaV; }
        public int getKerbalCapacity() { return this.capKerbal; }
        public string getElecAutonomy() { return this.autoResElec; }
        public string getFoodAutonomy() { return this.autoResFood; }
        public string getWaterAutonomy() { return this.autoResWater; }
        public string getOxygenAutonomy() { return this.autoResOxygen; }
        public decimal getWeight() { return this.masse; }
        public decimal getLenght() { return this.longueur; }
        public decimal getWidht() { return this.largueur; }
        public decimal getHeight() { return this.hauteur; }
        public int getCost() { return this.cout; }
        public string getComment() { return this.commentaire; }

        //Accesseurs - Setter
        public void setId(int id) { this.id = id; }
        public void setName(string nom) { this.nom = nom; }
        public void setType(string t) { this.type = t; }
        public void setDeltaV(int dV) { this.deltaV = dV; }
        public void setKerbalCapacity(int capKerb) { this.capKerbal = capKerb; }
        public void setElecAutonomy(string aElec) { this.autoResElec = aElec; }
        public void setFoodAutonomy(string aFood) { this.autoResFood = aFood; }
        public void setWaterAutonomy(string aWater) { this.autoResWater = aWater; }
        public void setOxygenAutonomy(string aOx) { this.autoResOxygen = aOx; }
        public void setWeight(decimal m) { this.masse = m; }
        public void setLenght(decimal lon) { this.longueur = lon; }
        public void setWidht(decimal lar) { this.largueur = lar; }
        public void setHeight(decimal hau) { this.hauteur = hau; }
        public void setCost(int cost) { this.cout = cost; }
        public void setComment(string com) { this.commentaire = com; }
    }
}
