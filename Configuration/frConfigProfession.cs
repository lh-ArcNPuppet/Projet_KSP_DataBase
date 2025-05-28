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
    public partial class frConfigProfession: Form
    {
        public frConfigProfession()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListProfession()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var professions = DAO_Profession.getProfessionList();

            foreach (var profession in professions)
            {
                var row = dt.NewRow();

                row["ID"] = profession.getId();
                row["Libellé"] = profession.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listProfession.DataSource = dt;
        }
        private void frConfigProfession_Load(object sender, EventArgs e)
        {
            getListProfession();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_idProfession.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idProfession.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_TypeProfession profession = new DB_TypeProfession(id, libelle);
                    bool res = DAO_Profession.createTypeProfession(profession);
                    if (res)
                    {
                        MessageBox.Show(
                                "Profession ajouté avec succès",
                                "Ajout profession",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idProfession.Clear();
                        txtBox_libelle.Clear();
                        getListProfession();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "La profession n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement de la profession impossible :\n" +
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
                    "Enregistrement de la profession impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listProfession.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var profession = DAO_Profession.getProfession(Convert.ToInt32(value));
            txtBox_idProfession.Text = profession.getId().ToString();
            txtBox_libelle.Text = profession.getLibelle();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_idProfession.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idProfession.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_TypeProfession profession = new DB_TypeProfession(id, libelle);
                    bool res = DAO_Profession.updateTypeProfession(profession);
                    if (res)
                    {
                        MessageBox.Show(
                                "Profession modifié avec succès",
                                "Modification profession",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idProfession.Clear();
                        txtBox_libelle.Clear();
                        getListProfession();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "La profession n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification de la profession impossible :\n" +
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
                    "Modification de la profession impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listProfession.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var profession = DAO_Profession.getProfession(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer la profession \"" + profession.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_Profession.deleteTypeProfession(Convert.ToInt32(value));

                txtBox_idProfession.Clear();
                txtBox_libelle.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListProfession();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_idProfession.Clear();
            txtBox_libelle.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
