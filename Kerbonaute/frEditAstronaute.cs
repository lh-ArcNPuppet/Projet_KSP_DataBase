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
    public partial class frEditAstronaute : Form
    {
        private int id;
        public frEditAstronaute(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frEditAstronaute_Load(object sender, EventArgs e)
        {
            foreach (DB_TypeProfession tpro in DAO_Profession.getProfessionList())
            {
                cbo_profession.Items.Add(tpro.getLibelle());
            }

            var astronaute = DAO_Astronaute.getAstronaute(id);

            lbl_id.Text = id.ToString();
            txtBox_nom.Text = astronaute.getName();
            cbo_profession.Text = astronaute.getProfession();

            char valSexe = astronaute.getSexe();
            if (valSexe == 'M') { rdBtn_masculin.Checked = true; rdBtn_feminin.Checked = false; }
            if (valSexe == 'F') { rdBtn_masculin.Checked = false; rdBtn_feminin.Checked = true; }

            numUD_niveau.Value = astronaute.getLevel();
            numUD_tauxCourrage.Value = astronaute.getCourageRate();
            numUD_tauxStupidite.Value = astronaute.getStupidityRate();

            int vet = astronaute.getVeteranState();
            if (vet == 1) { chkBox_estVeteran.Checked = true; }

            string vitals = astronaute.getVitalsState();
            if (vitals == "En vie") { rdBtn_enVie.Checked = true; rdBtn_decede.Checked = false; }
            if (vitals == "Décédé") { rdBtn_enVie.Checked = false; rdBtn_decede.Checked = true; }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text.Trim().Length != 0)
            {
                if (cbo_profession.Text.Trim().Length != 0)
                {
                    if ((rdBtn_masculin.Checked == false) && (rdBtn_feminin.Checked == false))
                    {
                        MessageBox.Show(
                            "Création impossible.\n" +
                            "L'astronaute doit avoir un sexe défini",
                            "Entrée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if ((rdBtn_enVie.Checked == false) && (rdBtn_decede.Checked == false))
                        {
                            MessageBox.Show(
                            "Création impossible.\n" +
                            "Un status vital doit être défini pour l'astronaute.",
                            "Entrée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string nom = txtBox_nom.Text.Trim();
                            int idProfession = DAO_Profession.getIdByLibelle(cbo_profession.SelectedItem.ToString());

                            char sexe = ' ';
                            if (rdBtn_masculin.Checked) { sexe = 'M'; }
                            if (rdBtn_feminin.Checked) { sexe = 'F'; }

                            int niveau = Convert.ToInt32(numUD_niveau.Value);
                            int courrage = Convert.ToInt32(numUD_tauxCourrage.Value);
                            int stupidite = Convert.ToInt32(numUD_tauxStupidite.Value);

                            int veteran;
                            if (chkBox_estVeteran.Checked) { veteran = 1; }
                            else { veteran = 0; }

                            string statusVital = "";
                            if (rdBtn_enVie.Checked) { statusVital = "En vie"; }
                            if (rdBtn_decede.Checked) { statusVital = "Décédé"; }

                            DB_Astronaute astronaute = new DB_Astronaute(id, nom, sexe, idProfession.ToString(), niveau, courrage, stupidite, veteran, statusVital);
                            bool res = DAO_Astronaute.updateAstronaute(astronaute);
                            if (res)
                            {
                                MessageBox.Show(
                                "Astronaute modifié avec succès",
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
