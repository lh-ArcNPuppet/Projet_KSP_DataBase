using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using LIB_DAL;

namespace Mission
{
    public partial class frMission: Form
    {
        public frMission()
        {
            InitializeComponent();
        }

        private void getListMissions()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("N° vol");
            dt.Columns.Add("Status mission");
            dt.Columns.Add("Nom mission");
            dt.Columns.Add("Lanceur");
            dt.Columns.Add("Payload(s)");
            dt.Columns.Add("Astronaute(s)");
            dt.Columns.Add("Objectif(s)");
            dt.Columns.Add("Situation_Actuelle");
            dt.Columns.Add("Résultat");
            dt.Columns.Add("Commentaire(s)");

            var missions = DAO_Mission.getMissionsList();

            foreach (var mission in missions)
            {
                var row = dt.NewRow();

                row["N° vol"] = mission.getNumFlight();
                row["Status mission"] = mission.getMissionState();
                row["Nom mission"] = mission.getName();
                row["Lanceur"] = mission.getLanceur();
                row["Payload(s)"] = mission.getPayloadList();
                row["Astronaute(s)"] = mission.getAstronautList();
                row["Objectif(s)"] = mission.getObjectif();
                row["Situation_Actuelle"] = mission.getActualSituation();
                row["Résultat"] = mission.getResultsMission();
                row["Commentaire(s)"] = mission.getComments();

                dt.Rows.Add(row);
            }

            dgv_listeMission.DataSource = dt;
        }

        private void frMission_Load(object sender, EventArgs e)
        {
            getListMissions();
        }
    }
}
