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

namespace Lanceur
{
    public partial class frLanceur : Form
    {
        public frLanceur()
        {
            InitializeComponent();
        }
        private void getListLanceurs()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Type lanceur");
            dt.Columns.Add("Nbr étage");
            dt.Columns.Add("delta V");
            dt.Columns.Add("LEO Max");
            dt.Columns.Add("nbr Vol");
            dt.Columns.Add("Commentaire(s)");

            var lanceurs = DAO_Lanceur.getLanceurList();

            foreach (var lanceur in lanceurs)
            {
                var row = dt.NewRow();

                row["ID"] = lanceur.getId();
                row["Nom"] = lanceur.getName();
                row["Type lanceur"] = lanceur.getType();
                row["Nbr étage"] = lanceur.getNbrStage();
                row["delta V"] = lanceur.getDeltaV();
                row["LEO Max"] = lanceur.getLEO_Max();
                row["nbr Vol"] = lanceur.getNbrVol();
                row["Commentaire(s)"] = lanceur.getComment();

                dt.Rows.Add(row);
            }

            dgv_listeLanceur.DataSource = dt;
        }

        private void frLanceur_Load(object sender, EventArgs e)
        {
            getListLanceurs();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frNewLanceur frNewLanceur = new frNewLanceur();
            DialogResult res = frNewLanceur.ShowDialog();
            if (res == DialogResult.OK) { getListLanceurs(); }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listeLanceur.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            frEditLanceur frEditLanceur = new frEditLanceur(Convert.ToInt32(value));
            DialogResult res = frEditLanceur.ShowDialog();
            if (res == DialogResult.OK) { getListLanceurs(); }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer ce lanceur ?\n" +
                "(Cette action est irréversible)",
                "Suppression lanceur",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                var value = dgv_listeLanceur.SelectedRows[0].Cells[0].Value.ToString();
                if (value == null) return;

                DAO_Lanceur.deleteLanceur(Convert.ToInt32(value));
                getListLanceurs();
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var value = dgv_listeLanceur.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            frDetailsLanceur frDetailsLanceur = new frDetailsLanceur(Convert.ToInt32(value));
            frDetailsLanceur.Show();
        }
    }
}