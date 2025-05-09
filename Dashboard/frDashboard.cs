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

        private void calculateurDeDeltaVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void calculateurLKOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editerLaListeDesStatusMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editerLaListeDesSituationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editerLaListeDesTypesDeLanceursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editerLaListeDesTypesDePayloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editerLaListeDesProfessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
