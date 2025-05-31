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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission
{
    public partial class frEditListUsedPayload : Form
    {
        public string resultatList { get; private set; }
        public frEditListUsedPayload(string inputList)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            if (inputList != "")
            {
                string[] listPayloadsArray = inputList.Split(',');

                lst_usedPayloads.Items.Clear();
                lst_usedPayloads.Items.AddRange(listPayloadsArray);
            }
            else
            {
                lst_usedPayloads.Items.Clear();
            }
        }

        private void getListPayload()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nom");
            dt.Columns.Add("Type");

            var payloads = DAO_Payload.getPayloadList();

            foreach (var payload in payloads)
            {
                var row = dt.NewRow();

                row["Nom"] = payload.getName();
                row["Type"] = payload.getType();

                dt.Rows.Add(row);
            }

            dgv_listPayloads.DataSource = dt;
        }

        private void frEditListUsedPayload_Load(object sender, EventArgs e)
        {
            getListPayload();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            var value = dgv_listPayloads.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var payload = DAO_Payload.getPayload(DAO_Payload.getIdByLibelle(value));
            lst_usedPayloads.Items.Add(payload.getName());
        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            if (lst_usedPayloads.SelectedItem != null) { lst_usedPayloads.Items.Remove(lst_usedPayloads.SelectedItem); }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (lst_usedPayloads.Items.Count > 0)
            {
                List<string> usedPayloads = new List<string>();
                foreach (var item in lst_usedPayloads.Items)
                {
                    usedPayloads.Add(item.ToString());
                }

                resultatList = string.Join(",", usedPayloads);
                 
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else { Close(); }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            if (lst_usedPayloads.SelectedItem != null)
            {
                txtBox_modificationNomPayload.Text = lst_usedPayloads.SelectedItem.ToString();

                txtBox_modificationNomPayload.Enabled = true;
                btn_modifier.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "Veuillez sélectionné un payload pour l'éditer.",
                    "Avertissement : aucun payload sélectionné",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int selectedIndex = lst_usedPayloads.SelectedIndex;

            if (txtBox_modificationNomPayload.Text.Trim().Length != 0)
            {
                if (selectedIndex >= 0)
                {
                    // Remplacer l'élément sélectionné
                    lst_usedPayloads.Items[selectedIndex] = txtBox_modificationNomPayload.Text;
                }
            }
            else
            {
                MessageBox.Show(
                    "Modification impossible !\n" +
                    "Un nom doit être renseigné pour pouvoir être modifier",
                    "Erreur : nom incorrect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            txtBox_modificationNomPayload.Clear();
            txtBox_modificationNomPayload.Enabled = false;
            btn_modifier.Enabled = false;
        }
    }
}
