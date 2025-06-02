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

namespace Mission
{
    public partial class frNewMission : Form
    {
        public frNewMission()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void frNewMission_Load(object sender, EventArgs e)
        {
            rdBtn_nonTermine.Checked = true;
            foreach (DB_StatusMission sm in DAO_StatusMission.getStatusMissionList())
            {
                cbo_statusMission.Items.Add(sm.getLibelle());
            }
            foreach (DB_Lanceur lanceur in DAO_Lanceur.getLanceurList())
            {
                cbo_lanceur.Items.Add(lanceur.getName());
            }
            foreach (DB_Systeme systeme in DAO_Systeme.getSystemeList())
            {
                cbo_systemeCible.Items.Add(systeme.getLibelle());
            }
            foreach (DB_Astre astre in DAO_Astre.getAstreList())
            {
                cbo_astreCible.Items.Add(astre.getName());
            }
            foreach (DB_SituationActuelle sa in DAO_SituationActuelle.getSituationActuelleList())
            {
                cbo_situationActuelle.Items.Add(sa.getLibelle());
            }
        }

        private void btn_viderListPayload_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous vider la liste des payloads ?",
                "Confirmation de vidage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res == DialogResult.Yes) { lst_listPayload.Items.Clear(); }
        }

        private void btn_viderListKerbonaute_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous vider la liste des astronautes ?",
                "Confirmation de vidage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res == DialogResult.Yes) { lst_astronaute.Items.Clear(); }
        }

        private void btn_editListPayload_Click(object sender, EventArgs e)
        {
            string concatPayload = "";
            if (lst_listPayload.Items.Count > 0)
            {
                List<string> usedPayloads = new List<string>();
                foreach (var item in lst_listPayload.Items)
                {
                    usedPayloads.Add(item.ToString());
                }

                concatPayload = string.Join(",", usedPayloads);
            }

            frEditListUsedPayload frEditListUsedPayload = new frEditListUsedPayload(concatPayload);

            if (frEditListUsedPayload.ShowDialog() == DialogResult.OK)
            {
                string listResult = frEditListUsedPayload.resultatList;
                string[] listPayloadsArray = listResult.Split(',');

                lst_listPayload.Items.Clear();
                lst_listPayload.Items.AddRange(listPayloadsArray);
            }
        }

        private void btn_editListKerbonaute_Click(object sender, EventArgs e)
        {
            string concatAstronaute = "";
            if (lst_astronaute.Items.Count > 0)
            {
                List<string> usedAstronaute = new List<string>();
                foreach (var item in lst_astronaute.Items)
                {
                    usedAstronaute.Add(item.ToString());
                }

                concatAstronaute = string.Join(",", usedAstronaute);
            }

            frEditListAstronautes frEditListAstronautes = new frEditListAstronautes(concatAstronaute);

            if (frEditListAstronautes.ShowDialog() == DialogResult.OK)
            {
                string listResult = frEditListAstronautes.resultatList;
                string[] listAstronauteArray = listResult.Split(',');

                lst_astronaute.Items.Clear();
                lst_astronaute.Items.AddRange(listAstronauteArray);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Voulez-vous remettre à zéro le formulaire d'ajout de mission ?",
                "Confirmation de remise à zéro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res == DialogResult.Yes)
            {
                txtBox_nomMission.Clear();
                cbo_statusMission.SelectedItem = null;
                cbo_lanceur.SelectedItem = null;
                lst_listPayload.Items.Clear();
                numUD_coutTotaux.Value = 0;

                lst_astronaute.Items.Clear();
                cbo_systemeCible.SelectedItem = null;
                cbo_astreCible.SelectedItem = null;
                txtBox_objectif.Clear();
                cbo_situationActuelle.SelectedItem = null;
                rdBtn_nonTermine.Checked = true;
                txtBox_commentaire.Clear();
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_nomMission.Text.Trim().Length != 0)
            {
                if (cbo_statusMission.Text.Trim().Length != 0)
                {
                    if (cbo_lanceur.Text.Trim().Length != 0)
                    {
                        if (cbo_systemeCible.Text.Trim().Length != 0)
                        {
                            if (cbo_systemeCible.Text.Trim().Length != 0)
                            {
                                if (cbo_astreCible.Text.Trim().Length != 0)
                                {
                                    if (cbo_situationActuelle.Text.Trim().Length != 0)
                                    {
                                        if (txtBox_objectif.Text.Trim().Length == 0)
                                        {
                                            DialogResult res = MessageBox.Show(
                                                "La mission ne comporte actuellement aucun objectif.\n" +
                                                "Voulez-vous continuer à créer la mission sans objectifs.",
                                                "Avertissement - Aucun objectif",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
                                            if (res == DialogResult.Yes)
                                            {
                                                string nom = txtBox_nomMission.Text.Trim();
                                                int idMissionState = DAO_StatusMission.getIdByLibelle(cbo_statusMission.SelectedItem.ToString());
                                                int idLanceur = DAO_Lanceur.getIdByName(cbo_lanceur.SelectedItem.ToString());
                                                string listPayload = "";
                                                if (lst_listPayload.Items.Count > 0)
                                                {
                                                    List<string> usedPayloads = new List<string>();
                                                    foreach (var item in lst_listPayload.Items)
                                                    {
                                                        usedPayloads.Add(item.ToString());
                                                    }
                                                    listPayload = string.Join(",", usedPayloads);
                                                }
                                                int cout = Convert.ToInt32(numUD_coutTotaux.Value);
                                                DateTime dtDebut = dtp_dateHeureDebut.Value;
                                                DateTime dtFin = dtp_dateHeureFin.Value;
                                                string dureeMission = txtBox_dureeMission.Text.Trim();
                                                string listAstronaute = "";
                                                if (lst_astronaute.Items.Count > 0)
                                                {
                                                    List<string> usedAstronautes = new List<string>();
                                                    foreach (var item in lst_astronaute.Items)
                                                    {
                                                        usedAstronautes.Add(item.ToString());
                                                    }
                                                    listAstronaute = string.Join(",", usedAstronautes);
                                                }
                                                int idSysteme = DAO_Systeme.getIdByName(cbo_systemeCible.Text.Trim());
                                                int idAstre = DAO_Astre.getIdByName(cbo_astreCible.Text.Trim());
                                                string objectifs = "";
                                                int idSituationActuelle = DAO_SituationActuelle.getIdByLibelle(cbo_situationActuelle.SelectedItem.ToString());
                                                string resultMission = "";
                                                if (rdBtn_nonTermine.Checked) { resultMission = "Non défini"; }
                                                if (rdBtn_reussite.Checked) { resultMission = "Réussite"; }
                                                if (rdBtn_semiEchec.Checked) { resultMission = "Semi-Echec"; }
                                                if (rdBtn_echec.Checked) { resultMission = "Echec"; }
                                                string commentaires = txtBox_commentaire.Text.Trim();

                                                DB_Mission mission = new DB_Mission(
                                                    nom,
                                                    idMissionState,
                                                    idLanceur,
                                                    listPayload,
                                                    cout,
                                                    dtDebut,
                                                    dtFin,
                                                    dureeMission,
                                                    listAstronaute,
                                                    idSysteme,
                                                    idAstre,
                                                    objectifs,
                                                    idSituationActuelle,
                                                    resultMission,
                                                    commentaires
                                                    );
                                                bool resCreate = DAO_Mission.createMission(mission);
                                                if (resCreate)
                                                {
                                                    MessageBox.Show(
                                                    "Nouvelle mission ajouté avec succès",
                                                    "Nouvelle mission",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                                    DialogResult = DialogResult.OK;
                                                    Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show(
                                                    "Erreur lors de la requête\n" +
                                                    "La mission n'a pas pus être ajouté",
                                                    "Erreur d'ajout",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                                    Close();
                                                }
                                            }
                                            else { return; }
                                        }
                                        else
                                        {
                                            string nom = txtBox_nomMission.Text.Trim();
                                            int idMissionState = DAO_StatusMission.getIdByLibelle(cbo_statusMission.SelectedItem.ToString());
                                            int idLanceur = DAO_Lanceur.getIdByName(cbo_lanceur.SelectedItem.ToString());
                                            string listPayload = "";
                                            if (lst_listPayload.Items.Count > 0)
                                            {
                                                List<string> usedPayloads = new List<string>();
                                                foreach (var item in lst_listPayload.Items)
                                                {
                                                    usedPayloads.Add(item.ToString());
                                                }
                                                listPayload = string.Join(",", usedPayloads);
                                            }
                                            int cout = Convert.ToInt32(numUD_coutTotaux.Value);
                                            DateTime dtDebut = dtp_dateHeureDebut.Value;
                                            DateTime dtFin = dtp_dateHeureFin.Value;
                                            string dureeMission = txtBox_dureeMission.Text.Trim();
                                            string listAstronaute = "";
                                            if (lst_astronaute.Items.Count > 0)
                                            {
                                                List<string> usedAstronautes = new List<string>();
                                                foreach (var item in lst_astronaute.Items)
                                                {
                                                    usedAstronautes.Add(item.ToString());
                                                }
                                                listAstronaute = string.Join(",", usedAstronautes);
                                            }
                                            int idSysteme = DAO_Systeme.getIdByName(cbo_systemeCible.Text.Trim());
                                            int idAstre = DAO_Astre.getIdByName(cbo_astreCible.Text.Trim());
                                            string objectifs = txtBox_objectif.Text.Trim();
                                            int idSituationActuelle = DAO_SituationActuelle.getIdByLibelle(cbo_situationActuelle.SelectedItem.ToString());
                                            string resultMission = "";
                                            if (rdBtn_nonTermine.Checked) { resultMission = "Non défini"; }
                                            if (rdBtn_reussite.Checked) { resultMission = "Réussite"; }
                                            if (rdBtn_semiEchec.Checked) { resultMission = "Semi-Echec"; }
                                            if (rdBtn_echec.Checked) { resultMission = "Echec"; }
                                            string commentaires = txtBox_commentaire.Text.Trim();

                                            DB_Mission mission = new DB_Mission(
                                                nom,
                                                idMissionState,
                                                idLanceur,
                                                listPayload,
                                                cout,
                                                dtDebut,
                                                dtFin,
                                                dureeMission,
                                                listAstronaute,
                                                idSysteme,
                                                idAstre,
                                                objectifs,
                                                idSituationActuelle,
                                                resultMission,
                                                commentaires
                                                );
                                            bool resCreate = DAO_Mission.createMission(mission);
                                            if (resCreate)
                                            {
                                                MessageBox.Show(
                                                "Nouvelle mission ajouté avec succès",
                                                "Nouvelle mission",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                                DialogResult = DialogResult.OK;
                                                Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show(
                                                "Erreur lors de la requête\n" +
                                                "La mission n'a pas pus être ajouté",
                                                "Erreur d'ajout",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                                Close();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(
                                            "Création impossible.\n" +
                                            "Une situation actuelle est nécessaire pour la création d'une nouvelle mission.",
                                            "Avertissement - Donnée manquante",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "Création impossible.\n" +
                                        "Un astre cible est nécessaire pour la création d'une nouvelle mission.",
                                        "Avertissement - Donnée manquante",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Création impossible.\n" +
                                    "Un système cible est nécessaire pour la création d'une nouvelle mission.",
                                    "Avertissement - Donnée manquante",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Création impossible.\n" +
                                "Un système cible est nécessaire pour la création d'une nouvelle mission.",
                                "Avertissement - Donnée manquante",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Création impossible.\n" +
                            "Un lanceur est nécessaire pour la création d'une nouvelle mission.",
                            "Avertissement - Donnée manquante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Création impossible.\n" +
                        "Un status de mission est nécessaire pour la création d'une nouvelle mission.",
                        "Avertissement - Donnée manquante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Création impossible.\n" +
                    "Un nom est nécessaire pour la création d'une nouvelle mission.",
                    "Avertissement - Donnée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
