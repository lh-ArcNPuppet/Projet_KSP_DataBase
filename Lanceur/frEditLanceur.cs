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

namespace Lanceur
{
    public partial class frEditLanceur : Form
    {
        private int _id;
        public frEditLanceur(int id)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            this._id = id;
        }

        private void frEditLanceur_Load(object sender, EventArgs e)
        {
            foreach (DB_TypeLanceur tl in DAO_TypeLanceur.getTypeLanceurList())
            {
                cbo_typeLanceur.Items.Add(tl.getLibelle());
            }

            var lanceur = DAO_Lanceur.getLanceur(_id);

            lbl_id.Text = Convert.ToString(_id);
            txtBox_nom.Text = lanceur.getName();
            cbo_typeLanceur.Text = DAO_TypeLanceur.getLibelleByCode(lanceur.getType());
            numUD_nbrEtage.Value = lanceur.getNbrStage();
            numUD_deltaV.Value = lanceur.getDeltaV();
            numUD_LKO.Value = lanceur.getLEO_Max();
            numUD_masse.Value = lanceur.getWeight();
            numUD_longueur.Value = lanceur.getLenght();
            numUD_largeur.Value = lanceur.getLenght();
            numUD_hauteur.Value = lanceur.getHeight();
            numUD_cout.Value = lanceur.getCost();
            txtBox_commentaire.Text = lanceur.getComment();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txtBox_nom.Text != "")
            {
                if (cbo_typeLanceur.Text != "")
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

                    DB_Lanceur lanceur = new DB_Lanceur(_id, nom, codeType, nbrEtage, deltaV, leoMax, masse, longueur, largeur, hauteur, cout, commentaire);

                    bool res = DAO_Lanceur.updateLanceur(lanceur);
                    if (res)
                    {
                        MessageBox.Show(
                        "Lanceur modifié avec succès",
                        "Modification lanceur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Erreur lors de la requête\n" +
                        "Le lanceur n'a pas pus être modifié",
                        "Erreur de modification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Close();
                    }
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
                    "Un nom est nécessaire pour la modification d'un lanceur.",
                    "Entrée manquante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
