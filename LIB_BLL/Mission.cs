using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Mission
    {
        //Attributs privés
        private int numVol;
        private string nom;

        private string statusMission;
        private string lanceur;
        private string payloadList; //A modifier pour une autre approche impliquant l'ajout de listBox
        private int cost;

        private int startYear;
        private int startDay;
        private string startHour;

        private int endYear;
        private int endDay;
        private string endHour;

        private string listAstronaute; //A modifier pour une autre approche impliquant l'ajout de listBox

        private string systeme;
        private string astre;
        private string objectif;

        private string situationActuelle;
        private string resultMission;
        private string commentaire;


        //Constructeur
        public Mission(
            int numVol,
            string nom,
            string sttMission,
            string lanceur,
            string payloadList,
            int cost,
            int startY,
            int startD,
            string startH,
            int endY,
            int endD,
            string endH,
            string listAstronaute,
            string systeme,
            string astre,
            string objectif,
            string situationActuelle,
            string resultMission,
            string commentaire)
        {
            this.numVol = numVol;
            this.nom = nom;
            this.statusMission = sttMission;
            this.lanceur = lanceur;
            this.payloadList = payloadList;
            this.cost = cost;
            this.startYear = startY;
            this.startDay = startD;
            this.startHour = startH;
            this.endYear = endY;
            this.endDay = endD;
            this.endHour = endH;
            this.listAstronaute = listAstronaute;
            this.systeme = systeme;
            this.astre = astre;
            this.objectif = objectif;
            this.situationActuelle = situationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }
        public Mission(
            int numVol,
            string sttMission,
            string nom,
            string lanceur,
            string payloadList,
            string listAstronaute,
            string objectif,
            string situationActuelle,
            string resultMission,
            string commentaire)
        {
            this.numVol = numVol;
            this.nom = nom;
            this.statusMission = sttMission;
            this.lanceur = lanceur;
            this.payloadList = payloadList;
            this.listAstronaute = listAstronaute;
            this.objectif = objectif;
            this.situationActuelle = situationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }

        //Accesseurs - Getter
        public int getNumFlight() { return this.numVol; }
        public string getName() { return this.nom; }
        public string getMissionState() { return this.statusMission; }
        public string getLanceur() { return this.lanceur; }
        public string getPayloadList() { return this.payloadList; }
        public int getCost() { return this.cost; }
        public int getStartYear() { return this.startYear; }
        public int getStartDay() { return this.startDay; }
        public string getTimeStart() { return this.startHour; }
        public int getEndYear() { return this.endYear; }
        public int getEndDay() { return this.endDay; }
        public string getEndTime() { return this.endHour; }
        public string getAstronautList() { return this.listAstronaute; }
        public string getAstre() { return this.astre; }
        public string getSysteme() { return this.systeme; }
        public string getObjectif() { return this.objectif; }
        public string getActualSituation() { return this.situationActuelle; }
        public string getResultsMission() { return this.resultMission; }
        public string getComments() { return this.commentaire; }

        //Accesseurs - Setter
        public void setName(string nom) { this.nom = nom; }
        public void setMissionState(string ms) { this.statusMission = ms; }
        public void setLanceur(string l) { this.lanceur = l; }
        public void setPayloadList(string pl) { this.payloadList = pl; }
        public void setCost(int c) { this.cost = c; }
        public void setStartYear(int sY) { this.startYear = sY; }
        public void setStartDay(int sD) { this.startDay = sD; }
        public void setStartTime(string sTime) { this.startHour = sTime; }
        public void setEndYear(int eY) { this.endYear = eY; }
        public void setEndDay(int eD) { this.endDay = eD; }
        public void setEndTime(string eTime) { this.endHour = eTime; }
        public void setAstronautList(string al) { this.listAstronaute = al; }
        public void setAstre(string a) { this.astre = a; }
        public void setSysteme(string s) { this.systeme = s; }
        public void setObjectif(string o) { this.objectif = o; }
        public void setActualSituation(string acst) { this.situationActuelle = acst; }
        public void setResultMission(string r) { this.resultMission = r; }
        public void setComments(string com) { this.commentaire = com; }
    }
}
