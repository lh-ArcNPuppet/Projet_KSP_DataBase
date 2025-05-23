using LIB_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kerbonaute
{
    public partial class frDetailsAstronaute : Form
    {
        private int id;
        public frDetailsAstronaute(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frDetailsAstronaute_Load(object sender, EventArgs e)
        {
            var astronaute = DAO_Astronaute.getAstronaute(id);

            lbl_id.Text = id.ToString();
            lbl_nom.Text = astronaute.getName();
            lbl_profession.Text = astronaute.getProfession();
            char valSexe = astronaute.getSexe();
            if (valSexe == 'M') { lbl_sexe.Text = "Masculin"; }
            if (valSexe == 'F') { lbl_sexe.Text = "Féminin"; }
            lbl_niveau.Text = astronaute.getLevel().ToString();
            lbl_courrage.Text = astronaute.getCourageRate().ToString();
            lbl_stupidite.Text = astronaute.getStupidityRate().ToString();
            int vet = astronaute.getVeteranState();
            if (vet == 1) { lbl_veteran.Text = "Oui"; }
            else { lbl_veteran.Text = "Non"; }
            lbl_vitals.Text = astronaute.getVitalsState();
        }
    }
}
