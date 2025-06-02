using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_Mission
    {
        //Attributs privés
        private int numVol;
        private string nom;

        private int idStatusMission;
        private string statusMission; //Utilisé uniquement pour la vue associé

        private int idLanceur;
        private string lanceur; //Utilisé uniquement pour la vue associé

        private string payloadList;
        private int cost;

        private DateTime dateHeureDebut;
        private DateTime dateHeureFin;
        private string dureeMission;

        private string listAstronaute;

        private string systeme; //Utilisé uniquement pour la vue associé
        private int idSysteme;

        private string astre; //Utilisé uniquement pour la vue associé
        private int idAstre;

        private string objectif;

        private int idSituationActuelle;
        private string situationActuelle; //Utilisé uniquement pour la vue associé

        private string resultMission;
        private string commentaire;


        //Constructeur
        public DB_Mission(
            int numVol,
            string nom,
            int idStatusMission,
            int idLanceur,
            int cost,
            string payloadList,
            DateTime dtpMissionStart,
            DateTime dtpMissionEnd,
            string dureeMission,
            string listAstronaute,
            int idSysteme,
            int idAstre,
            string objectif,
            int idSituationActuelle,
            string resultMission,
            string commentaire)
        {
            this.numVol = numVol;
            this.nom = nom;
            this.idStatusMission = idStatusMission;
            this.idLanceur = idLanceur;
            this.payloadList = payloadList;
            this.cost = cost;
            this.dateHeureDebut = dtpMissionStart;
            this.dateHeureFin = dtpMissionEnd;
            this.dureeMission = dureeMission;
            this.listAstronaute = listAstronaute;
            this.idSysteme = idSysteme;
            this.idAstre = idAstre;
            this.objectif = objectif;
            this.idSituationActuelle = idSituationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }
        public DB_Mission(
            int numVol,
            string statusMission,
            string nom,
            string lanceur,
            int cost,
            string payloadList,
            DateTime dtpMissionStart,
            DateTime dtpMissionEnd,
            string dureeMission,
            string listAstronaute,
            string astre,
            string systeme,
            string objectif,
            string situationActuelle,
            string resultMission,
            string commentaire)
        {
            this.numVol = numVol;
            this.nom = nom;
            this.statusMission = statusMission;
            this.lanceur = lanceur;
            this.payloadList = payloadList;
            this.cost = cost;
            this.dateHeureDebut = dtpMissionStart;
            this.dateHeureFin = dtpMissionEnd;
            this.dureeMission = dureeMission;
            this.listAstronaute = listAstronaute;
            this.systeme = systeme;
            this.astre = astre;
            this.objectif = objectif;
            this.situationActuelle = situationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }
        public DB_Mission(
            string nom,
            int idStatusMission,
            int idLanceur,
            string payloadList,
            int cost,
            DateTime dtpMissionStart,
            DateTime dtpMissionEnd,
            string dureeMission,
            string listAstronaute,
            int idSysteme,
            int idAstre,
            string objectif,
            int idSituationActuelle,
            string resultMission,
            string commentaire)
        {
            this.nom = nom;
            this.idStatusMission = idStatusMission;
            this.idLanceur = idLanceur;
            this.payloadList = payloadList;
            this.cost = cost;
            this.dateHeureDebut = dtpMissionStart;
            this.dateHeureFin = dtpMissionEnd;
            this.dureeMission = dureeMission;
            this.listAstronaute = listAstronaute;
            this.idSysteme = idSysteme;
            this.idAstre = idAstre;
            this.objectif = objectif;
            this.idSituationActuelle = idSituationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }

        public DB_Mission(
            int numVol,
            string statusMission,
            string nom,
            DateTime dtpMissionStart,
            DateTime dtpMissionEnd,
            string lanceur,
            string payloadList,
            string listAstronaute,
            string objectif,
            string situationActuelle,
            string resultMission)
        {
            this.numVol = numVol;
            this.nom = nom;
            this.statusMission = statusMission;
            this.payloadList = payloadList;
            this.dateHeureDebut = dtpMissionStart;
            this.lanceur = lanceur;
            this.dateHeureFin = dtpMissionEnd;
            this.listAstronaute = listAstronaute;
            this.objectif = objectif;
            this.situationActuelle = situationActuelle;
            this.resultMission = resultMission;
        }


        //Accesseurs - Getter
        public int getNumFlight() { return this.numVol; }
        public string getName() { return this.nom; }
        public string getMissionState() { return this.statusMission; }
        public int getIdMissionState() { return this.idStatusMission; }
        public string getLanceur() { return this.lanceur; }
        public int getIdLanceur() { return this.idLanceur; }
        public string getPayloadList() { return this.payloadList; }
        public int getCost() { return this.cost; }
        public DateTime getDateTimeMissionStart() { return this.dateHeureDebut; }
        public DateTime getDateTimeMissionEnd() { return this.dateHeureFin; }
        public string getMissionDuration() { return this.dureeMission; }
        public string getAstronautList() { return this.listAstronaute; }
        public string getAstre() { return this.astre; }
        public int getIdAstre() { return this.idAstre; }
        public string getSysteme() { return this.systeme; }
        public int getIdSysteme() { return this.idSysteme; }
        public string getObjectif() { return this.objectif; }
        public string getActualSituation() { return this.situationActuelle; }
        public int getIdActualSituation() { return this.idSituationActuelle; }
        public string getResultsMission() { return this.resultMission; }
        public string getComments() { return this.commentaire; }

        //Accesseurs - Setter
        public void setName(string nom) { this.nom = nom; }
        public void setMissionState(string ms) { this.statusMission = ms; }
        public void setLanceur(string l) { this.lanceur = l; }
        public void setPayloadList(string pl) { this.payloadList = pl; }
        public void setCost(int c) { this.cost = c; }
        public void setDateTimeMissionStart(DateTime dtMissionStart) { this.dateHeureDebut = dtMissionStart; }
        public void setDateTimeMissionEnd(DateTime dtMissionEnd) { this.dateHeureFin = dtMissionEnd; }
        public void setMissionDuration(string dureeMission) { this.dureeMission = dureeMission; }
        public void setAstronautList(string al) { this.listAstronaute = al; }
        public void setAstre(string a) { this.astre = a; }
        public void setSysteme(string s) { this.systeme = s; }
        public void setObjectif(string o) { this.objectif = o; }
        public void setActualSituation(string acst) { this.situationActuelle = acst; }
        public void setResultMission(string r) { this.resultMission = r; }
        public void setComments(string com) { this.commentaire = com; }
    }
}
