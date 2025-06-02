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

namespace Mission
{
    public partial class frDetailsMission : Form
    {
        private int id;
        public frDetailsMission(int idMission)
        {
            InitializeComponent();
            this.id = idMission;
        }

        private void frDetailsMission_Load(object sender, EventArgs e)
        {
            var mission = DAO_Mission.getMission(id);

            lbl_numVol.Text = mission.getNumFlight().ToString();
            lbl_nom.Text = mission.getName();
            lbl_statusMission.Text = mission.getMissionState();
            lbl_lanceur.Text = mission.getLanceur();

            string listPayload = mission.getPayloadList();
            string[] listPayloadArray = listPayload.Split(',');
            lst_listPayload.Items.Clear();
            lst_listPayload.Items.AddRange(listPayloadArray);

            lbl_couts.Text = mission.getCost().ToString();
            lbl_debutMission.Text = mission.getDateTimeMissionStart().ToString();
            lbl_missionFin.Text = mission.getDateTimeMissionEnd().ToString();
            lbl_dureeMission.Text = mission.getMissionDuration();

            string listAstronaute = mission.getAstronautList();
            string[] listAstronauteArray = listAstronaute.Split(',');
            lst_astronaute.Items.Clear();
            lst_astronaute.Items.AddRange(listAstronauteArray);

            lbl_systeme.Text = mission.getSysteme();
            lbl_astre.Text = mission.getAstre();
            txtBox_objectif.Text = mission.getObjectif();
            lbl_situationActuelle.Text = mission.getActualSituation();

            lbl_resultatMission.Text = mission.getResultsMission();
            txtBox_commentaire.Text = mission.getComments();
        }
    }
}
