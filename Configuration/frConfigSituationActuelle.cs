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
    public partial class frConfigSituationActuelle: Form
    {
        public frConfigSituationActuelle()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListSituationActuelle()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var situationActuelles = DAO_SituationActuelle.getSituationActuelleList();

            foreach (var situationActuelle in situationActuelles)
            {
                var row = dt.NewRow();

                row["ID"] = situationActuelle.getId();
                row["Libellé"] = situationActuelle.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listSituationActuelle.DataSource = dt;
        }
        private void frConfigSituationActuelle_Load(object sender, EventArgs e)
        {
            getListSituationActuelle();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_idSituationActuelle.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idSituationActuelle.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_SituationActuelle situationActuelle = new DB_SituationActuelle(id, libelle);
                    bool res = DAO_SituationActuelle.createSituationActuelle(situationActuelle);
                    if (res)
                    {
                        MessageBox.Show(
                                "Situation actuelle ajouté avec succès",
                                "Ajout situation actuelle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idSituationActuelle.Clear();
                        txtBox_libelle.Clear();
                        getListSituationActuelle();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "La situation actuelle n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement de la situation actuelle impossible :\n" +
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
                    "Enregistrement de la situation actuelle impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listSituationActuelle.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var situationActuelle = DAO_SituationActuelle.getSituationActuelle(Convert.ToInt32(value));
            txtBox_idSituationActuelle.Text = situationActuelle.getId().ToString();
            txtBox_libelle.Text = situationActuelle.getLibelle();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_idSituationActuelle.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idSituationActuelle.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_SituationActuelle situationActuelle = new DB_SituationActuelle(id, libelle);
                    bool res = DAO_SituationActuelle.updateSituationActuelle(situationActuelle);
                    if (res)
                    {
                        MessageBox.Show(
                                "Situation actuelle modifié avec succès",
                                "Ajout situation actuelle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idSituationActuelle.Clear();
                        txtBox_libelle.Clear();
                        getListSituationActuelle();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "La situation actuelle n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification de la situation actuelle impossible :\n" +
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
                    "Modification de la situation actuelle impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listSituationActuelle.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var sa = DAO_SituationActuelle.getSituationActuelle(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer la situation actuelle \"" + sa.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_SituationActuelle.deleteSituationActuelle(Convert.ToInt32(value));

                txtBox_idSituationActuelle.Clear();
                txtBox_libelle.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListSituationActuelle();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_idSituationActuelle.Clear();
            txtBox_libelle.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
