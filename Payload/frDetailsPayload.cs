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

namespace Payload
{
    public partial class frDetailsPayload : Form
    {
        private int id;
        public frDetailsPayload(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frDetailsPayload_Load(object sender, EventArgs e)
        {
            var payload = DAO_Payload.getPayload(id);

            lbl_id.Text = Convert.ToString(id);
            lbl_nom.Text = payload.getName();
            lbl_type.Text = DAO_TypePayload.getLibelleByCode(payload.getType());
            lbl_deltaV.Text = payload.getDeltaV().ToString();
            lbl_capacite.Text = payload.getKerbalCapacity().ToString();
            lbl_autoElec.Text = payload.getElecAutonomy();
            lbl_autoFood.Text = payload.getFoodAutonomy();
            lbl_autoEau.Text = payload.getWaterAutonomy();
            lbl_autoOxy.Text = payload.getOxygenAutonomy();
            lbl_masse.Text = payload.getWeight().ToString();
            lbl_longueur.Text = payload.getLenght().ToString();
            lbl_largeur.Text = payload.getWidht().ToString();
            lbl_hauteur.Text = payload.getHeight().ToString();
            lbl_cout.Text = payload.getCost().ToString();
            txtBox_Commentaire.Text = payload.getComment();
        }
    }
}
