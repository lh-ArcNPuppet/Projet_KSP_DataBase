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
        private decimal rayon;
        private int temperature;
        private decimal graviteSurface;
        private string atmosphere;
        private decimal periodeOrbitale;
        private string description;

        //Constructeur
        public Astre(int id, string nom, string type, string systemeR)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.systemeRelatif = systemeR;
        }
        public Astre(int id, string nom, string type, string systemeR, decimal r, int temp, decimal sg, string atm, decimal pOrbit, string desc)
        {
            this.id = id;
            this.nom = nom;
            this.type = type;
            this.systemeRelatif = systemeR;
            this.rayon = r;
            this.temperature = temp;
            this.graviteSurface = sg;
            this.atmosphere = atm;
            this.periodeOrbitale = pOrbit;
            this.description = desc;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getName() { return this.nom; }
        public string getType() { return this.type; }
        public string getRelatedSystem() { return this.systemeRelatif; }
        public decimal getRadius() { return this.rayon; }
        public int getTemperature() { return this.temperature; }
        public decimal getSurfaceGravity() { return this.graviteSurface; }
        public string getAthmosphere() { return this.atmosphere; }
        public decimal getOrbitPeriod() { return this.periodeOrbitale; }
        public string getDescription() { return this.description; }

        //Accesseurs - Setter
        public void setName(string nom) { this.nom = nom; }
        public void setType(string type) { this.type = type; }
        public void setRelatedSystem(string systemR) { this.systemeRelatif = systemR; }
        public void setRadius(decimal r) { this.rayon = r; }
        public void setTemperature(int temp) { this.temperature = temp; }
        public void setSurfaceGravity(decimal sg) { this.graviteSurface = sg; }
        public void setAtmosphere(string atm) { this.atmosphere = atm; }
        public void setOrbitPeriod(decimal op) { this.periodeOrbitale = op; }
        public void setDescription(string desc) { this.description = desc; }
    }
}
