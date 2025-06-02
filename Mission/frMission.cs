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
            dt.Columns.Add("Début mission");
            dt.Columns.Add("Fin Mission");
            dt.Columns.Add("Lanceur");
            dt.Columns.Add("Payload(s)");
            dt.Columns.Add("Astronaute(s)");
            dt.Columns.Add("Objectif(s)");
            dt.Columns.Add("Situation_Actuelle");
            dt.Columns.Add("Résultat");

            var missions = DAO_Mission.getMissionsList();

            foreach (var mission in missions)
            {
                var row = dt.NewRow();

                row["N° vol"] = mission.getNumFlight();
                row["Status mission"] = mission.getMissionState();
                row["Nom mission"] = mission.getName();
                row["Début mission"] = mission.getDateTimeMissionStart();
                row["Fin Mission"] = mission.getDateTimeMissionEnd();
                row["Lanceur"] = mission.getLanceur();
                row["Payload(s)"] = mission.getPayloadList();
                row["Astronaute(s)"] = mission.getAstronautList();
                row["Objectif(s)"] = mission.getObjectif();
                row["Situation_Actuelle"] = mission.getActualSituation();
                row["Résultat"] = mission.getResultsMission();

                dt.Rows.Add(row);
            }

            dgv_listeMission.DataSource = dt;
        }

        private void frMission_Load(object sender, EventArgs e)
        {
            getListMissions();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frNewMission frNewMission = new frNewMission();
            DialogResult res = frNewMission.ShowDialog();
            if (res == DialogResult.OK) { getListMissions(); }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listeMission.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var mission = DAO_Mission.getMission(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer la mission \"" + mission.getName() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_Mission.deleteMission(Convert.ToInt32(value));
                getListMissions();
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listeMission.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            frEditMission frEditMission = new frEditMission(Convert.ToInt32(value));
            DialogResult res = frEditMission.ShowDialog();

            if (res == DialogResult.OK) { getListMissions(); }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var value = dgv_listeMission.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            frDetailsMission frDetailsMission = new frDetailsMission(Convert.ToInt32(value));
            frDetailsMission.Show();
        }
    }
}
