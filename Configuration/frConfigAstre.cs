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

namespace Configuration
{
    public partial class frConfigAstre: Form
    {
        private int id;
        public frConfigAstre()
        {
            InitializeComponent();
        }
        private void getListAstres()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Type");
            dt.Columns.Add("Système");

            var astres = DAO_Astre.getAstreList();

            foreach (var astre in astres)
            {
                var row = dt.NewRow();

                row["ID"] = astre.getId();
                row["Nom"] = astre.getName();
                row["Type"] = astre.getType();
                row["Système"] = astre.getRelatedSystem();

                dt.Rows.Add(row);
            }

            dgv_listeAstre.DataSource = dt;
        }

        private void frConfigAstre_Load(object sender, EventArgs e)
        {
            getListAstres();
            foreach (DB_TypeAstre ta in DAO_TypeAstre.getTypeAstreList())
            {
                cbo_type.Items.Add(ta.getLibelle());
            }
            foreach (DB_Systeme s in DAO_Systeme.getSystemeList())
            {
                cbo_systemeParent.Items.Add(s.getLibelle());
            }
            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text.Trim().Length != 0)
            {
                if (cbo_type.Text.Trim().Length != 0)
                {
                    if (cbo_systemeParent.Text.Trim().Length != 0)
                    {
                        string nom = txtBox_nom.Text.Trim();
                        string type = DAO_TypeAstre.getIdByLibelle(cbo_type.SelectedItem.ToString()).ToString();
                        string idSysteme = DAO_Systeme.getIdByName(cbo_systemeParent.SelectedItem.ToString()).ToString();
                        decimal rayon = numUD_rayon.Value;
                        int temp = Convert.ToInt32(numUD_temperature.Value);
                        decimal gravSurf = numUD_graviteSurface.Value;
                        string atmos = txtBox_atmosphere.Text.Trim();
                        string period = txtBox_periodeOrbitale.Text.Trim();
                        string desc = txtBox_description.Text.Trim();

                        /*MessageBox.Show(
                            "Nom : " + nom + "\n" +
                            "Type : " + type + "\n" +
                            "Systeme : " + idSysteme + "\n" +
                            "rayon : " + rayon + "\n" +
                            "temp : " + temp + "\n" +
                            "gS : " + gravSurf + "\n" +
                            "atm : " + atmos + "\n" +
                            "period : " + period + "\n" +
                            "desc : " + desc + "\n"
                            );*/

                        DB_Astre astre = new DB_Astre(nom, type, idSysteme, rayon, temp, gravSurf, atmos, period, desc);
                        bool res = DAO_Astre.createAstre(astre);
                        if (res) {
                            MessageBox.Show(
                                "Astre ajouté avec succès",
                                "Ajout astre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            getListAstres();

                            lbl_numAstre.Text = "-";
                            txtBox_nom.Clear();
                            cbo_type.Text = "";
                            cbo_systemeParent.Text = "";
                            numUD_rayon.Value = 0;
                            numUD_temperature.Value = 0;
                            numUD_graviteSurface.Value = 0;
                            txtBox_atmosphere.Clear();
                            txtBox_periodeOrbitale.Text.Trim();
                            txtBox_description.Clear();

                            btn_enregistrer.Enabled = true;
                            btn_update.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "L'astre n'a pas pus être ajouté.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Enregistrement de l'astre impossible :\n" +
                            "Système de référence de l'astre non renseigné.",
                            "Avertissement : donnée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Enregistrement de l'astre impossible :\n" +
                        "Type d'astre non renseigné.",
                        "Avertissement : donnée manquante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
            }
            else
            {
                MessageBox.Show(
                    "Enregistrement de l'astre impossible :\n" +
                    "Nom de l'astre non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var value = dgv_listeAstre.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var astre = DAO_Astre.getAstre(Convert.ToInt32(value));
            id = astre.getId();

            lbl_numAstre.Text = astre.getId().ToString();
            txtBox_nom.Text = astre.getName();
            cbo_type.Text = astre.getType();
            cbo_systemeParent.Text = astre.getRelatedSystem();
            numUD_rayon.Value = astre.getRadius();
            numUD_temperature.Value = astre.getTemperature();
            numUD_graviteSurface.Value = astre.getAbsoluteGravity();
            txtBox_atmosphere.Text = astre.getAthmosphere();
            txtBox_periodeOrbitale.Text = astre.getOrbitPeriod();
            txtBox_description.Text = astre.getDescription();

            btn_enregistrer.Enabled = false;
            btn_update.Enabled = true;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var value = dgv_listeAstre.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null) return;

            var astre = DAO_Astre.getAstre(Convert.ToInt32(value));

            DialogResult res = MessageBox.Show(
                "Voulez-vous supprimer l'astre \"" + astre.getName() + "\" ?\n" +
                "(Cette action est irréversible)",
                "Confirmation suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (res == DialogResult.Yes)
            {
                DAO_Astre.deleteAstre(Convert.ToInt32(value));

                lbl_numAstre.Text = "-";
                txtBox_nom.Clear();
                cbo_type.Text = "";
                cbo_systemeParent.Text = "";
                numUD_rayon.Value = 0;
                numUD_temperature.Value = 0;
                numUD_graviteSurface.Value = 0;
                txtBox_atmosphere.Clear();
                txtBox_periodeOrbitale.Clear();
                txtBox_description.Clear();

                btn_enregistrer.Enabled = true;
                btn_update.Enabled = false;

                getListAstres();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text.Trim().Length != 0)
            {
                if (cbo_type.Text.Trim().Length != 0)
                {
                    if (cbo_systemeParent.Text.Trim().Length != 0)
                    {
                        string nom = txtBox_nom.Text.Trim();
                        string type = DAO_TypeAstre.getIdByLibelle(cbo_type.SelectedItem.ToString()).ToString();
                        string idSysteme = DAO_Systeme.getIdByName(cbo_systemeParent.SelectedItem.ToString()).ToString();
                        decimal rayon = numUD_rayon.Value;
                        int temp = Convert.ToInt32(numUD_temperature.Value);
                        decimal gravSurf = numUD_graviteSurface.Value;
                        string atmos = txtBox_atmosphere.Text.Trim();
                        string  period = txtBox_periodeOrbitale.Text.Trim();
                        string desc = txtBox_description.Text.Trim();

                        DB_Astre astre = new DB_Astre(id, nom, type, idSysteme, rayon, temp, gravSurf, atmos, period, desc);
                        bool res = DAO_Astre.updateAstre(astre);
                        if (res)
                        {
                            MessageBox.Show(
                                "Astre modifié avec succès",
                                "Modification astre",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            getListAstres();

                            lbl_numAstre.Text = "-";
                            txtBox_nom.Clear();
                            cbo_type.Text = "";
                            cbo_systemeParent.Text = "";
                            numUD_rayon.Value = 0;
                            numUD_temperature.Value = 0;
                            numUD_graviteSurface.Value = 0;
                            txtBox_atmosphere.Clear();
                            txtBox_periodeOrbitale.Clear();
                            txtBox_description.Clear();

                            btn_enregistrer.Enabled = true;
                            btn_update.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "L'astre n'a pas pus être modifié.",
                                "Erreur de modification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Enregistrement de l'astre impossible :\n" +
                            "Système de référence de l'astre non renseigné.",
                            "Avertissement : donnée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Enregistrement de l'astre impossible :\n" +
                        "Type d'astre non renseigné.",
                        "Avertissement : donnée manquante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
            }
            else
            {
                MessageBox.Show(
                    "Enregistrement de l'astre impossible :\n" +
                    "Nom de l'astre non renseigné.",
                    "Avertissement : donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_numAstre.Text = "-";
            txtBox_nom.Clear();
            cbo_type.Text = "";
            cbo_systemeParent.Text = "";
            numUD_rayon.Value = 0;
            numUD_temperature.Value = 0;
            numUD_graviteSurface.Value = 0;
            txtBox_atmosphere.Clear();
            txtBox_periodeOrbitale.Clear();
            txtBox_description.Clear();

            btn_enregistrer.Enabled = true;
            btn_update.Enabled = false;
        }
    }
}
