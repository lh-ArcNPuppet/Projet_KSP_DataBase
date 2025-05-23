using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_Astronaute
    {
        //Attributs privés
        private int id;
        private string nom;
        private char sexe;
        private string profession;
        private int niveau;
        private int courage;
        private int stupidite;
        private int veteran;
        private string statusVital;
        private int nbrVol;

        //Constructeur
        public DB_Astronaute(string nom, char sexe, string profession, int lv, int c, int s, int v, string sV)
        {
            this.nom = nom;
            this.sexe = sexe;
            this.profession = profession;
            this.niveau = lv;
            this.courage = c;
            this.stupidite = s;
            this.veteran = v;
            this.statusVital = sV;
        }
        public DB_Astronaute(int id, string nom, char sexe, string profession, int lv, int c, int s, int v, string sV)
        {
            this.id = id;
            this.nom = nom;
            this.sexe = sexe;
            this.profession = profession;
            this.niveau = lv;
            this.courage = c;
            this.stupidite = s;
            this.veteran = v;
            this.statusVital = sV;
        }
        public DB_Astronaute(int id, string nom, char sexe, string profession, int lv, int v, string sV, int nbrVol)
        {
            this.id = id;
            this.nom = nom;
            this.sexe = sexe;
            this.profession = profession;
            this.niveau = lv;
            this.veteran = v;
            this.statusVital = sV;
            this.nbrVol = nbrVol;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public char getSexe() { return this.sexe; }
        public int getLevel() { return this.niveau; }
        public string getProfession() { return this.profession; }
        public int getCourageRate() { return this.courage; }
        public int getStupidityRate() { return this.stupidite; }
        public int getVeteranState() { return this.veteran; }
        public string getVitalsState() { return this.statusVital; }
        public int getNbrVol() { return this.nbrVol; }


        //Accesseurs - Setters
        public void setName(string nom) { this.nom = nom; }
        public void setSexe(char sexe) { this.sexe = sexe; }
        public void setLevel(int lv) { this.niveau = lv; }
        public void setCourageRate(int c) { this.courage = c; }
        public void setStupidityRate(int s) { this.stupidite = s; }
        public void setVeteranState(int doVeteran) { this.veteran = doVeteran; }
        public void setVitalState(string vS) { this.statusVital = vS; }
    }
}
