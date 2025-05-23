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

namespace Payload
{
    public partial class frNewPayload: Form
    {
        public frNewPayload()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void frNewPayload_Load(object sender, EventArgs e)
        {
            foreach (DB_TypePayload tp in DAO_TypePayload.getTypePayloadList())
            {
                cbo_Type.Items.Add(tp.getLibelle());
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
                if (cbo_Type.Text.Trim().Length == 0)
                {
                    string nom = txtBox_nom.Text;
                    string codeType = DAO_TypePayload.getCodeByLibelle(cbo_Type.SelectedItem.ToString());
                    int deltaV = Convert.ToInt32(numUD_DeltaV.Value);
                    int capacite = Convert.ToInt32(numUD_Capacite.Value);
                    string autoElec = txtBox_AutoElectricite.Text;
                    string autoFood = txtBox_AutoNourriture.Text;
                    string autoEau = txtBox_AutoEau.Text;
                    string autoOxygene = txtBox_Oxygene.Text;
                    decimal masse = numUD_Masse.Value;
                    decimal longueur = numUD_Longueur.Value;
                    decimal largeur = numUD_Largueur.Value;
                    decimal hauteur = numUD_Hauteur.Value;
                    int cout = Convert.ToInt32(numUD_Cout.Value);
                    string commentaire = txtBox_Commentaire.Text;

                    DB_Payload payload = new DB_Payload(nom, codeType, deltaV, capacite, autoElec, autoFood, autoEau, autoOxygene, masse, longueur, largeur, hauteur, cout, commentaire);

                    bool res = DAO_Payload.createPayload(payload);
                    if (res)
                    {
                        MessageBox.Show(
                        "Nouveau payload ajouté avec succès",
                        "Nouveau payload",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Erreur lors de la requête\n" +
                        "Le nouveau payload n'a pas pus être ajouté",
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
                    "Le payload doit avoir un type pour pouvoir être identifié.",
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
