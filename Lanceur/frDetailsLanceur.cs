using LIB_BLL;
using LIB_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanceur
{
    public partial class frDetailsLanceur : Form
    {
        private int id;
        public frDetailsLanceur(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frDetailsLanceur_Load(object sender, EventArgs e)
        {
            var lanceur = DAO_Lanceur.getLanceur(id);

            lbl_id.Text = Convert.ToString(id);
            lbl_nom.Text = lanceur.getName();
            lbl_type.Text = DAO_TypeLanceur.getLibelleByCode(lanceur.getType());
            lbl_nbrEtage.Text = lanceur.getNbrStage().ToString();
            lbl_deltaV.Text = lanceur.getDeltaV().ToString() + " m/s";
            lbl_leoMax.Text = lanceur.getLEO_Max().ToString() + " tonne(s)";
            lbl_masse.Text = lanceur.getWeight().ToString() + " tonne(s)";
            lbl_longueur.Text = lanceur.getLenght().ToString() + " mètre(s)";
            lbl_largeur.Text = lanceur.getLenght().ToString() + " mètre(s)";
            lbl_hauteur.Text = lanceur.getHeight().ToString() + " mètre(s)";
            lbl_cout.Text = lanceur.getCost().ToString();
            txtBox_commentaire.Text = lanceur.getComment().ToString();
        }
    }
}
