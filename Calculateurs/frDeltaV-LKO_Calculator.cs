using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateurs
{
    public partial class frDeltaV_Calculator: Form
    {
        public frDeltaV_Calculator()
        {
            InitializeComponent();
        }

        private void refreshStagingDisplay()
        {
            if (numUD_nbrEtage.Value >= 2)
            {
                numUD_etage2_m0.Enabled = true;
                numUD_etage2_mf.Enabled = true;
                numUD_etage2_isp.Enabled = true;
                txtBox_etage2_g.Enabled = true;
                txtBox_etage2_dV.Enabled = true;
            }
            else
            {
                numUD_etage2_m0.Enabled = false;
                numUD_etage2_mf.Enabled = false;
                numUD_etage2_isp.Enabled = false;
                txtBox_etage2_g.Enabled = false;
                txtBox_etage2_dV.Enabled = false;
            }
            if (numUD_nbrEtage.Value >= 3)
            {
                numUD_etage3_m0.Enabled = true;
                numUD_etage3_mf.Enabled = true;
                numUD_etage3_isp.Enabled = true;
                txtBox_etage3_g.Enabled = true;
                txtBox_etage3_dV.Enabled = true;
            }
            else
            {
                numUD_etage3_m0.Enabled = false;
                numUD_etage3_mf.Enabled = false;
                numUD_etage3_isp.Enabled = false;
                txtBox_etage3_g.Enabled = false;
                txtBox_etage3_dV.Enabled = false;
            }
            if (numUD_nbrEtage.Value >= 4)
            {
                numUD_etage4_m0.Enabled = true;
                numUD_etage4_mf.Enabled = true;
                numUD_etage4_isp.Enabled = true;
                txtBox_etage4_g.Enabled = true;
                txtBox_etage4_dV.Enabled = true;
            }
            else
            {
                numUD_etage4_m0.Enabled = false;
                numUD_etage4_mf.Enabled = false;
                numUD_etage4_isp.Enabled = false;
                txtBox_etage4_g.Enabled = false;
                txtBox_etage4_dV.Enabled = false;
            }
            if (numUD_nbrEtage.Value >= 5)
            {
                numUD_etage5_m0.Enabled = true;
                numUD_etage5_mf.Enabled = true;
                numUD_etage5_isp.Enabled = true;
                txtBox_etage5_g.Enabled = true;
                txtBox_etage5_dV.Enabled = true;
            }
            else
            {
                numUD_etage5_m0.Enabled = false;
                numUD_etage5_mf.Enabled = false;
                numUD_etage5_isp.Enabled = false;
                txtBox_etage5_g.Enabled = false;
                txtBox_etage5_dV.Enabled = false;
            }
        }

        private void frDeltaV_Calculator_Load(object sender, EventArgs e)
        {
            refreshStagingDisplay();
        }

        private void numUD_nbrEtage_ValueChanged(object sender, EventArgs e)
        {
            refreshStagingDisplay();
        }
    }
}
