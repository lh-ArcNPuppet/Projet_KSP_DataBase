using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    class Mission
    {
        //Attributs privés
        private int id;
        private string nom;

        private int statusMission;
        private int idLanceur;
        private string idPayloadList; //A modifier pour une autre approche impliquant l'ajout de listBox
        private int cost;

        private int startYear;
        private int startDay;
        private string startHour;

        private int endYear;
        private int endDay;
        private string endHour;

        private string idListKerbonaute; //A modifier pour une autre approche impliquant l'ajout de listBox

        private int idSysteme;
        private int idAstre;
        private string objectif;

        private int situationActuelle;
        private int resultMission;
        private string commentaire;


        //Constructeur
        public Mission(
            int id,
            string nom,
            int sttMission,
            int idLanceur,
            string idPayloadList,
            int cost,
            int startY,
            int startD,
            string startH,
            int endY,
            int endD,
            string endH,
            string idListKerbonaute,
            int idSysteme,
            int idAstre,
            string objectif,
            int situationActuelle,
            int resultMission,
            string commentaire)
        {
            this.id = id;
            this.nom = nom;
            this.statusMission = sttMission;
            this.idLanceur = idLanceur;
            this.idPayloadList = idPayloadList;
            this.cost = cost;
            this.startYear = startY;
            this.startDay = startD;
            this.startHour = startH;
            this.endYear = endY;
            this.endDay = endD;
            this.endHour = endH;
            this.idListKerbonaute = idListKerbonaute;
            this.idSysteme = idSysteme;
            this.idAstre = idAstre;
            this.objectif = objectif;
            this.situationActuelle = situationActuelle;
            this.resultMission = resultMission;
            this.commentaire = commentaire;
        }

        //Accesseurs - Getter
        public int getInt() { return this.id; }
        public string getName() { return this.nom; }
        public int getMissionState() { return this.statusMission; }
        public int getIdLanceur() { return this.idLanceur; }

        //Accesseurs - Setter
        public void setId(int id) { this.id = id; }
    }
}
