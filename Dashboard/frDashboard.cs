using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Authentification;
using Configuration;
using Kerbonaute;
using Lanceur;
using LIB_BLL;
using LIB_DAL;
using Mission;
using Payload;
using Calculateurs;

namespace Dashboard
{
    public partial class frDashboard: Form
    {
        public frDashboard()
        {
            InitializeComponent();
        }

        private void missionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frMission frMission = new frMission();
            frMission.Show();
        }

        private void lanceursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frLanceur frLanceur = new frLanceur();
            frLanceur.Show();
        }

        private void payloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPayload frPayload = new frPayload();
            frPayload.Show();
        }

        private void kerbonautesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frKerbonaute frKerbonaute = new frKerbonaute();
            frKerbonaute.Show();
        } 

        private void editerLaListeDesStatusMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConfigStatusMission frConfigStatusMission = new frConfigStatusMission();
            frConfigStatusMission.Show();
        }

        private void editerLaListeDesSituationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConfigSituationActuelle frConfigSituationActuelle = new frConfigSituationActuelle();
            frConfigSituationActuelle.Show();
        }

        private void editerLaListeDesTypesDeLanceursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConfigTypeLanceur frConfigTypeLanceur = new frConfigTypeLanceur();
        }

        private void editerLaListeDesTypesDePayloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConfigListePayload frConfigListePayload = new frConfigListePayload();
            frConfigListePayload.Show();
        }

        private void editerLaListeDesProfessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConfigProfession frConfigProfession = new frConfigProfession();
            frConfigProfession.Show();
        }
    }
}
