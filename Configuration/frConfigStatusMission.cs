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

namespace Configuration
{
    public partial class frConfigStatusMission: Form
    {
        public frConfigStatusMission()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListStatusMission()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var statusMissions = DAO_StatusMission.getStatusMissionList();

            foreach (var statusMission in statusMissions)
            {
                var row = dt.NewRow();

                row["ID"] = statusMission.getId();
                row["Libellé"] = statusMission.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listStatusMission.DataSource = dt;
        }
        private void frConfigStatusMission_Load(object sender, EventArgs e)
        {
            getListStatusMission();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_idStatusMission.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idStatusMission.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_StatusMission statusMission = new DB_StatusMission(id, libelle);
                    bool res = DAO_StatusMission.createStatusMission(statusMission);
                    if (res)
                    {
                        MessageBox.Show(
                                "Status mission ajouté avec succès",
                                "Ajout status mission",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idStatusMission.Clear();
                        txtBox_libelle.Clear();
                        getListStatusMission();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le status mission n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement du status mission impossible :\n" +
                    "> Libellé non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Enregistrement du status mission impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listStatusMission.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var statusMission = DAO_StatusMission.getStatusMission(Convert.ToInt32(value));
            txtBox_idStatusMission.Text = statusMission.getId().ToString();
            txtBox_libelle.Text = statusMission.getLibelle();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_idStatusMission.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idStatusMission.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_StatusMission statusMission = new DB_StatusMission(id, libelle);
                    bool res = DAO_StatusMission.updateStatusMission(statusMission);
                    if (res)
                    {
                        MessageBox.Show(
                                "Status mission modifié avec succès",
                                "Modification status mission",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idStatusMission.Clear();
                        txtBox_libelle.Clear();
                        getListStatusMission();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le status mission n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification du status mission impossible :\n" +
                    "> Libellé non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Modification du status mission impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listStatusMission.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var profession = DAO_StatusMission.getStatusMission(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer le status mission \"" + profession.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_StatusMission.deleteStatusMission(Convert.ToInt32(value));

                txtBox_idStatusMission.Clear();
                txtBox_libelle.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListStatusMission();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_idStatusMission.Clear();
            txtBox_libelle.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
