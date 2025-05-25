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
    public partial class frConfigListePayload : Form
    {
        public frConfigListePayload()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListTypePayload()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Libellé");

            var typesPayload = DAO_TypePayload.getTypePayloadList();

            foreach (var typePayload in typesPayload)
            {
                var row = dt.NewRow();

                row["Code"] = typePayload.getCode();
                row["Libellé"] = typePayload.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listTypePayload.DataSource = dt;
        }

        private void frConfigListePayload_Load(object sender, EventArgs e)
        {
            getListTypePayload();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_codePayload.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    string code = txtBox_codePayload.Text.Trim();
                    string libelle = txtBox_nom.Text.Trim();

                    DB_TypePayload typePayload = new DB_TypePayload(code, libelle);
                    bool res = DAO_TypePayload.createTypePayload(typePayload);
                    if (res) {
                        MessageBox.Show(
                                "Type payload ajouté avec succès",
                                "Ajout type payload",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_codePayload.Clear();
                        txtBox_nom.Clear();
                        getListTypePayload();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type payload n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement du type payload impossible :\n" +
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
                    "Enregistrement du type payload impossible :\n" +
                    "> Code non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypePayload.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var typePayload = DAO_TypePayload.getTypePayload(value);
            txtBox_codePayload.Text = typePayload.getCode();
            txtBox_nom.Text = typePayload.getLibelle();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_codePayload.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    string code = txtBox_codePayload.Text.Trim();
                    string libelle = txtBox_nom.Text.Trim();

                    DB_TypePayload typePayload = new DB_TypePayload(code, libelle);
                    bool res = DAO_TypePayload.updateTypePayload(typePayload);
                    if (res)
                    {
                        MessageBox.Show(
                                "Type payload modifié avec succès",
                                "Modification type payload",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_codePayload.Clear();
                        txtBox_nom.Clear();
                        getListTypePayload();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type payload n'a pas pus être modifié.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification du type payload impossible :\n" +
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
                    "Modification du type payload impossible :\n" +
                    "> Code non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypePayload.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var typePayload = DAO_TypePayload.getTypePayload(value);

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer le type payload \"" + typePayload.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_TypePayload.deleteTypePayload(value);

                txtBox_codePayload.Clear();
                txtBox_nom.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListTypePayload();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_codePayload.Clear();
            txtBox_nom.Clear();
        }
    }
}
