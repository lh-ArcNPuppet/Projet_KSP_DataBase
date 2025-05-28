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
    public partial class frConfigSysteme: Form
    {
        public frConfigSysteme()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListSysteme()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Description");

            var systemes = DAO_Systeme.getSystemeList();

            foreach (var systeme in systemes)
            {
                var row = dt.NewRow();

                row["ID"] = systeme.getId();
                row["Nom"] = systeme.getLibelle();
                row["Description"] = systeme.getDescription();

                dt.Rows.Add(row);
            }

            dgv_listSysteme.DataSource = dt;
        }
        private void frConfigSysteme_Load(object sender, EventArgs e)
        {
            getListSysteme();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_idSysteme.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idSysteme.Text.Trim());
                    string nom = txtBox_nom.Text.Trim();
                    string description = txtBox_description.Text.Trim();

                    DB_Systeme systeme = new DB_Systeme(id, nom, description);
                    bool res = DAO_Systeme.createSysteme(systeme);
                    if (res)
                    {
                        MessageBox.Show(
                                "Système ajouté avec succès",
                                "Ajout système",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idSysteme.Clear();
                        txtBox_nom.Clear();
                        txtBox_description.Clear();
                        getListSysteme();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le système n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement du système impossible :\n" +
                    "> Nom manquant.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Enregistrement du système impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listSysteme.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var systeme = DAO_Systeme.getSysteme(Convert.ToInt32(value));
            txtBox_idSysteme.Text = systeme.getId().ToString();
            txtBox_nom.Text = systeme.getLibelle();
            txtBox_description.Text = systeme.getDescription();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_idSysteme.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idSysteme.Text.Trim());
                    string nom = txtBox_nom.Text.Trim();
                    string description = txtBox_description.Text.Trim();

                    DB_Systeme systeme = new DB_Systeme(id, nom, description);
                    bool res = DAO_Systeme.updateSysteme(systeme);
                    if (res)
                    {
                        MessageBox.Show(
                                "Système modifié avec succès",
                                "Modification système",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idSysteme.Clear();
                        txtBox_nom.Clear();
                        txtBox_description.Clear();
                        getListSysteme();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le système n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification du système impossible :\n" +
                    "> Nom manquant.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Modification du systèmes impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listSysteme.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var systeme = DAO_Systeme.getSysteme(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer le système \"" + systeme.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_Systeme.deleteSysteme(Convert.ToInt32(value));

                txtBox_idSysteme.Clear();
                txtBox_nom.Clear();
                txtBox_description.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListSysteme();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_idSysteme.Clear();
            txtBox_nom.Clear();
            txtBox_description.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
