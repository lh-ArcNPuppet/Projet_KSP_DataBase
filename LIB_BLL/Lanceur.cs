using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Lanceur
    {
        //Attributs privés
        private int id;
        private string nom;
        private string type;

        private int nbrEtage;
        private int deltaV;
        private decimal leoMax;

        private decimal masse;
        private decimal longueur;
        private decimal largeur;
        private decimal hauteur;
        private int cout;
        private string commentaire;
        private int nbrVol;


        //Constructeurs
        public Lanceur(int id, string nom, string type, int nbrEtage, int dV, decimal leoMax, decimal masse, decimal lon, decimal lar, decimal hau, int cost, string commentaire)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.nbrEtage = nbrEtage;
            this.deltaV = dV;
            this.leoMax = leoMax;
            this.masse = masse;
            this.longueur = lon;
            this.largeur = lar;
            this.hauteur = hau;
            this.cout = cost;
            this.commentaire = commentaire;
        }
        public Lanceur(int id, string nom, string type, int nbrEtage, int dV, decimal leoMax, int nbrVol, string commentaire)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.nbrEtage = nbrEtage;
            this.deltaV = dV;
            this.leoMax = leoMax;
            this.nbrVol = nbrVol;
            this.commentaire = commentaire;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public string getType() { return this.type; }
        public int getNbrStage() { return this.nbrEtage; }
        public int getDeltaV() { return this.deltaV; }
        public decimal getLEO_Max() { return this.leoMax; }
        public decimal getWeight() { return this.masse; }
        public decimal getLenght() { return this.longueur; }
        public decimal getWidht() { return this.largeur; }
        public decimal getHeight() { return this.hauteur; }
        public decimal getCost() { return this.cout; }
        public string getComment() { return this.commentaire; }
        public int getNbrVol() {  return this.nbrVol; }


        //Accesseur - Setter
        public void setName(string nom) { this.nom = nom; }
        public void setNbrStage(int nbrEtage) { this.nbrEtage = nbrEtage; }
        public void setDeltaV(int dV) { this.deltaV = dV; }
        public void setLKO_Max(decimal leoMax) { this.leoMax = leoMax; }
        public void setWeight(decimal m) { this.masse = m; }
        public void setLenght(decimal lon) { this.largeur = lon; }
        public void setWidht(decimal lar) { this.largeur = lar; }
        public void setHeight(decimal hau) { this.hauteur = hau; }
        public void setCost(int c) { this.cout = c; }
        public void setComment(string com) { this.commentaire = com; }
    }
}
