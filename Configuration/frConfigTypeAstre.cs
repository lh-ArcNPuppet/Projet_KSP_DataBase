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
    public partial class frConfigTypeAstre: Form
    {
        public frConfigTypeAstre()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListTypeAstre()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var typeAstres = DAO_TypeAstre.getTypeAstreList();

            foreach (var typeAstre in typeAstres)
            {
                var row = dt.NewRow();

                row["ID"] = typeAstre.getId();
                row["Libellé"] = typeAstre.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listTypeAstre.DataSource = dt;
        }
        private void frConfigTypeAstre_Load(object sender, EventArgs e)
        {
            getListTypeAstre();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_idTypeAstre.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idTypeAstre.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_TypeAstre typeAstre = new DB_TypeAstre(id, libelle);
                    bool res = DAO_TypeAstre.createTypeAstre(typeAstre);
                    if (res)
                    {
                        MessageBox.Show(
                                "Type astre ajouté avec succès",
                                "Ajout type astre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idTypeAstre.Clear();
                        txtBox_libelle.Clear();
                        getListTypeAstre();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type astre n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement du type astre impossible :\n" +
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
                    "Enregistrement du type astre impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypeAstre.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var profession = DAO_TypeAstre.getTypeAstre(Convert.ToInt32(value));
            txtBox_idTypeAstre.Text = profession.getId().ToString();
            txtBox_libelle.Text = profession.getLibelle();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_idTypeAstre.Text.Trim().Length != 0)
            {
                if (txtBox_libelle.Text.Trim().Length != 0)
                {
                    int id = Convert.ToInt32(txtBox_idTypeAstre.Text.Trim());
                    string libelle = txtBox_libelle.Text.Trim();

                    DB_TypeAstre typeAstre = new DB_TypeAstre(id, libelle);
                    bool res = DAO_TypeAstre.updateTypeAstre(typeAstre);
                    if (res)
                    {
                        MessageBox.Show(
                                "Type astre modifié avec succès",
                                "Modification type astre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_idTypeAstre.Clear();
                        txtBox_libelle.Clear();
                        getListTypeAstre();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type astre n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification du type astre impossible :\n" +
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
                    "Modification du type astre impossible :\n" +
                    "> ID non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypeAstre.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var profession = DAO_TypeAstre.getTypeAstre(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer le type astre \"" + profession.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_TypeAstre.deleteTypeAstre(Convert.ToInt32(value));

                txtBox_idTypeAstre.Clear();
                txtBox_libelle.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListTypeAstre();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_idTypeAstre.Clear();
            txtBox_libelle.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
