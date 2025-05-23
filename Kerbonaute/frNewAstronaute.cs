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

namespace Kerbonaute
{
    public partial class frNewAstronaute: Form
    {
        public frNewAstronaute()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void frNewAstronaute_Load(object sender, EventArgs e)
        {
            foreach (DB_TypeProfession tpro in DAO_Profession.getProfessionList())
            {
                cbo_profession.Items.Add(tpro.getLibelle());
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text.Trim().Length == 0)
            {
                if (cbo_profession.Text.Trim().Length == 0)
                {
                    if ((rdBtn_masculin.Checked == false) && (rdBtn_feminin.Checked == false))
                    {
                        if ((rdBtn_enVie.Checked == false) && (rdBtn_decede.Checked == false))
                        {
                            string nom = txtBox_nom.Text.Trim();
                            int idProfession = DAO_Profession.getIdByLibelle(cbo_profession.SelectedItem.ToString());

                            char sexe;
                            if (rdBtn_masculin.Checked) { sexe = 'M'; }
                            if (rdBtn_feminin.Checked) { sexe = 'F'; }

                            int niveau = Convert.ToInt32(numUD_niveau.Value);
                            int courrage = Convert.ToInt32(numUD_tauxCourrage.Value);
                            int stupidite = Convert.ToInt32(numUD_tauxStupidite.Value);

                            int veteran;
                            if (chkBox_estVeteran.Checked) { veteran = 1; }
                            else { veteran = 0; }

                            string statusVital;
                            if (rdBtn_enVie.Checked) { statusVital = "En Vie"; }
                            if (rdBtn_decede.Checked) { statusVital = "Décédé"; }

                            DB_Astronaute astronaute = new DB_Astronaute(nom, idProfession, sexe, niveau, courrage, stupidite, veteran, statusVital);
                            bool res = DAO_Astronaute.createAstronaute(astronaute);
                            if (res)
                            {
                                MessageBox.Show(
                                "Astronaute ajouté avec succès",
                                "Nouvel astronaute",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                "Erreur lors de la requête\n" +
                                "Le nouvel astronaute n'a pas pus être ajouté",
                                "Erreur d'ajout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Création impossible.\n" +
                            "Un status vital doit être défini pour l'astronaute.",
                            "Entrée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Création impossible.\n" +
                            "L'astronaute doit avoir un sexe défini",
                            "Entrée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show(
                    "Création impossible.\n" +
                    "L'astronaute doit avoir une profession.",
                    "Entrée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Création impossible.\n" +
                    "Un nom est nécessaire pour l'ajout d'un nouvel astronaute.",
                    "Entrée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
