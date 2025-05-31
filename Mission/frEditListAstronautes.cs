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
    public partial class frEditListAstronautes : Form
    {
        public string resultatList { get; private set; }
        public frEditListAstronautes(string inputList)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            if (inputList != "")
            {
                string[] listAstronauteArray = inputList.Split(',');

                lst_usedAstronaute.Items.Clear();
                lst_usedAstronaute.Items.AddRange(listAstronauteArray);
            }
            else
            {
                lst_usedAstronaute.Items.Clear();
            }
        }
        private void getListAstronaute()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nom");
            dt.Columns.Add("Profession");
            dt.Columns.Add("Etat");

            var astronautes = DAO_Astronaute.getAstronauteList();

            foreach (var astronaute in astronautes)
            {
                var row = dt.NewRow();

                row["Nom"] = astronaute.getName();
                row["Profession"] = astronaute.getProfession();
                row["Etat"] = astronaute.getVitalsState();

                dt.Rows.Add(row);
            }

            dgv_listAstronaute.DataSource = dt;
        }

        private void frEditListAstronautes_Load(object sender, EventArgs e)
        {
            getListAstronaute();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            var value = dgv_listAstronaute.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var astronaute = DAO_Astronaute.getAstronaute(DAO_Astronaute.getIdByName(value));

            if (!lst_usedAstronaute.Items.Contains(astronaute.getName()))
            {
                lst_usedAstronaute.Items.Add(astronaute.getName());
            }
            else
            {
                MessageBox.Show(
                    "L'astronaute " + astronaute.getName() + " est déjà présent dans la liste.",
                    "Ajout impossible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            if (lst_usedAstronaute.SelectedItem != null) { lst_usedAstronaute.Items.Remove(lst_usedAstronaute.SelectedItem); }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (lst_usedAstronaute.Items.Count > 0)
            {
                List<string> usedAstronaute = new List<string>();
                foreach (var item in lst_usedAstronaute.Items)
                {
                    usedAstronaute.Add(item.ToString());
                }

                resultatList = string.Join(",", usedAstronaute);

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else { Close(); }
        }
    }
}
