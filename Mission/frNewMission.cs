using LIB_BLL;
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
    public partial class frNewMission : Form
    {
        public frNewMission()
        {
            InitializeComponent();
        }

        private void frNewMission_Load(object sender, EventArgs e)
        {
            rdBtn_nonFini.Checked = true;
            foreach (DB_StatusMission sm in DAO_StatusMission.getStatusMissionList())
            {
                cbo_statusMission.Items.Add(sm.getLibelle());
            }
            foreach (DB_Lanceur lanceur in DAO_Lanceur.getLanceurList())
            {
                cbo_lanceur.Items.Add(lanceur.getName());
            }
            foreach (DB_Systeme systeme in DAO_Systeme.getSystemeList())
            {
                cbo_systemeCible.Items.Add(systeme.getLibelle());
            }
            foreach (DB_Astre astre in DAO_Astre.getAstreList())
            {
                cbo_astreCible.Items.Add(astre.getName());
            }
            foreach (DB_SituationActuelle sa in DAO_SituationActuelle.getSituationActuelleList())
            {
                cbo_situationActuelle.Items.Add(sa.getLibelle());
            }
        }

        private void btn_viderListPayload_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous vider la liste des payloads ?",
                "Confirmation de vidage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res == DialogResult.Yes) { lst_listPayload.Items.Clear(); }
        }

        private void btn_viderListKerbonaute_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous vider la liste des astronautes ?",
                "Confirmation de vidage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res == DialogResult.Yes) { lst_kerbonaute.Items.Clear(); }
        }

        private void btn_editListPayload_Click(object sender, EventArgs e)
        {
            string concatPayload = "";
            if (lst_listPayload.Items.Count > 0)
            {
                List<string> usedPayloads = new List<string>();
                foreach (var item in lst_listPayload.Items)
                {
                    usedPayloads.Add(item.ToString());
                }

                concatPayload = string.Join(",", usedPayloads);
            }

            frEditListUsedPayload frEditListUsedPayload = new frEditListUsedPayload(concatPayload);

            if (frEditListUsedPayload.ShowDialog() == DialogResult.OK)
            {
                string listResult = frEditListUsedPayload.resultatList;
                string[] listPayloadsArray = listResult.Split(',');

                lst_listPayload.Items.Clear();
                lst_listPayload.Items.AddRange(listPayloadsArray);
            }
        }
    }
}
