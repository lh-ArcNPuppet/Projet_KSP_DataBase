using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_DAL;
using LIB_BLL;

namespace Lanceur
{
    public partial class frNewLanceur: Form
    {
        public frNewLanceur()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void frNewLanceur_Load(object sender, EventArgs e)
        {
            foreach (DB_TypeLanceur tl in DAO_TypeLanceur.getTypeLanceurList())
            {
                cbo_typeLanceur.Items.Add(tl.getLibelle());
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text.Trim().Length != 0)
            {
                if (cbo_typeLanceur.Text.Trim().Length != 0)
                {
                    string nom = txtBox_nom.Text.Trim();
                    string codeType = DAO_TypeLanceur.getCodeByLibelle(cbo_typeLanceur.SelectedItem.ToString());
                    int nbrEtage = Convert.ToInt32(numUD_nbrEtage.Value);
                    int deltaV = Convert.ToInt32(numUD_deltaV.Value);
                    decimal leoMax = numUD_LKO.Value;
                    decimal masse = numUD_masse.Value;
                    decimal longueur = numUD_longueur.Value;
                    decimal largeur = numUD_largeur.Value;
                    decimal hauteur = numUD_hauteur.Value;
                    int cout = Convert.ToInt32(numUD_cout.Value);
                    string commentaire = txtBox_commentaire.Text.Trim();

                    /*MessageBox.Show(
                        "Nom : " + nom + "\n" +
                        "Type : " + codeType + "\n" +
                        "nbrEtage : " + nbrEtage + "\n" +
                        "deltaV : " + deltaV + "\n" +
                        "leoMax : " + leoMax + "\n" +
                        "masse : " + masse + "\n" +
                        "longueur : " + longueur + "\n" +
                        "largeur : " + largeur + "\n" +
                        "hauteur : " + hauteur + "\n" +
                        "cout : " + cout + "\n" +
                        "commentaire : " + commentaire);*/

                     DB_Lanceur lanceur = new DB_Lanceur(nom, codeType, nbrEtage, deltaV, leoMax, masse, longueur, largeur, hauteur, cout, commentaire);

                    bool res = DAO_Lanceur.createLanceur(lanceur);
                    if (res) {
                        MessageBox.Show(
                        "Nouveau lanceur ajouté avec succès",
                        "Nouveau lanceur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else {
                        MessageBox.Show(
                        "Erreur lors de la requête\n" +
                        "Le nouveau lanceur n'a pas pus être ajouté",
                        "Erreur d'ajout",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Close(); }
                }
                else
                {
                    MessageBox.Show(
                    "Création impossible.\n" +
                    "Le lanceur doit avoir un type pour pouvoir être identifié.",
                    "Entrée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Création impossible.\n" +
                    "Un nom est nécessaire pour la création d'un nouveau lanceur.",
                    "Entrée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
