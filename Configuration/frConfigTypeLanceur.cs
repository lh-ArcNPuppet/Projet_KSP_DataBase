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
    public partial class frConfigTypeLanceur: Form
    {
        public frConfigTypeLanceur()
        {
            InitializeComponent();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
        private void getListTypeLanceur()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Libellé");
            dt.Columns.Add("Description");

            var typeLanceurs = DAO_TypeLanceur.getTypeLanceurList();

            foreach (var typeLanceur in typeLanceurs)
            {
                var row = dt.NewRow();

                row["Code"] = typeLanceur.getCode();
                row["Libellé"] = typeLanceur.getLibelle();
                row["Description"] = typeLanceur.getDescription();

                dt.Rows.Add(row);
            }

            dgv_listTypeLanceur.DataSource = dt;
        }
        private void frConfigTypeLanceur_Load(object sender, EventArgs e)
        {
            getListTypeLanceur();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_codeLanceur.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    string code = txtBox_codeLanceur.Text.Trim();
                    string nom = txtBox_nom.Text.Trim();
                    string description = txtBox_description.Text.Trim();

                    DB_TypeLanceur typeLanceur = new DB_TypeLanceur(code, nom, description);
                    bool res = DAO_TypeLanceur.createTypeLanceur(typeLanceur);
                    if (res)
                    {
                        MessageBox.Show(
                                "Type lanceur ajouté avec succès",
                                "Ajout système",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_codeLanceur.Clear();
                        txtBox_nom.Clear();
                        txtBox_description.Clear();
                        getListTypeLanceur();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type lanceur n'a pas pus être ajouté.",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Enregistrement du type lanceur impossible :\n" +
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
                    "Enregistrement du type lanceur impossible :\n" +
                    "> Code non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_editer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypeLanceur.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var systeme = DAO_TypeLanceur.getTypeLanceur(value);
            txtBox_codeLanceur.Text = systeme.getCode();
            txtBox_nom.Text = systeme.getLibelle();
            txtBox_description.Text = systeme.getDescription();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_codeLanceur.Text.Trim().Length != 0)
            {
                if (txtBox_nom.Text.Trim().Length != 0)
                {
                    string code = txtBox_codeLanceur.Text.Trim();
                    string nom = txtBox_nom.Text.Trim();
                    string description = txtBox_description.Text.Trim();

                    DB_TypeLanceur typeLanceur = new DB_TypeLanceur(code, nom, description);
                    bool res = DAO_TypeLanceur.updateTypeLanceur(typeLanceur);
                    if (res)
                    {
                        MessageBox.Show(
                                "Type lanceur modifié avec succès",
                                "Modification type lanceur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        txtBox_codeLanceur.Clear();
                        txtBox_nom.Clear();
                        txtBox_description.Clear();
                        getListTypeLanceur();

                        btn_enregistrer.Enabled = true;
                        btn_update.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le type lanceur n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Modification du type lanceur impossible :\n" +
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
                    "> Code non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listTypeLanceur.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var typeLanceur = DAO_TypeLanceur.getTypeLanceur(value);

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer le type lanceur \"" + typeLanceur.getLibelle() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_TypeLanceur.deleteTypeLanceur(value);

                txtBox_codeLanceur.Clear();
                txtBox_nom.Clear();
                txtBox_description.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListTypeLanceur();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_codeLanceur.Clear();
            txtBox_nom.Clear();
            txtBox_description.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
