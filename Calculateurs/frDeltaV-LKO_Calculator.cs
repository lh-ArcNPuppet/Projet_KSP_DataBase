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

        private void calculateData()
        {
            double dV_2 = 0;
            double dV_3 = 0;
            double dV_4 = 0;
            double dV_5 = 0;

            double m01_e1 = Convert.ToDouble(numUD_etage1_m0.Value) + Convert.ToDouble(numUD_massePayload.Value);
            double mf1_e1 = Convert.ToDouble(numUD_etage1_mf.Value) + Convert.ToDouble(numUD_massePayload.Value);
            double dV_1 = (Convert.ToDouble(txtBox_etage1_g.Text) * Convert.ToDouble(numUD_etage1_isp.Value)) * Math.Log(m01_e1 / mf1_e1);
            txtBox_etage1_dV.Text = Convert.ToInt64(dV_1).ToString();

            if (numUD_nbrEtage.Value >= 2)
            {
                double m01_e2 = Convert.ToDouble(numUD_etage2_m0.Value) + Convert.ToDouble(numUD_massePayload.Value);
                double mf1_e2 = Convert.ToDouble(numUD_etage2_mf.Value) + Convert.ToDouble(numUD_massePayload.Value);
                dV_2 = (Convert.ToDouble(txtBox_etage2_g.Text) * Convert.ToDouble(numUD_etage2_isp.Value)) * Math.Log(m01_e2 / mf1_e2);
                txtBox_etage2_dV.Text = Convert.ToInt64(dV_2).ToString();
            }
            else
            {
                txtBox_etage2_dV.Text = "0";
            }

            if (numUD_nbrEtage.Value >= 3)
            {
                double m01_e3 = Convert.ToDouble(numUD_etage3_m0.Value) + Convert.ToDouble(numUD_massePayload.Value);
                double mf1_e3 = Convert.ToDouble(numUD_etage3_mf.Value) + Convert.ToDouble(numUD_massePayload.Value);
                dV_3 = (Convert.ToDouble(txtBox_etage3_g.Text) * Convert.ToDouble(numUD_etage3_isp.Value)) * Math.Log(m01_e3 / mf1_e3);
                txtBox_etage3_dV.Text = Convert.ToInt64(dV_3).ToString();
            }
            else
            {
                txtBox_etage3_dV.Text = "0";
            }

            if (numUD_nbrEtage.Value >= 4)
            {
                double m01_e4 = Convert.ToDouble(numUD_etage4_m0.Value) + Convert.ToDouble(numUD_massePayload.Value);
                double mf1_e4 = Convert.ToDouble(numUD_etage4_mf.Value) + Convert.ToDouble(numUD_massePayload.Value);
                dV_4 = (Convert.ToDouble(txtBox_etage4_g.Text) * Convert.ToDouble(numUD_etage4_isp.Value)) * Math.Log(m01_e4 / mf1_e4);
                txtBox_etage4_dV.Text = Convert.ToInt64(dV_4).ToString();
            }
            else
            {
                txtBox_etage4_dV.Text = "0";
            }

            if (numUD_nbrEtage.Value >= 5)
            {
                double m01_e5 = Convert.ToDouble(numUD_etage5_m0.Value) + Convert.ToDouble(numUD_massePayload.Value);
                double mf1_e5 = Convert.ToDouble(numUD_etage5_mf.Value) + Convert.ToDouble(numUD_massePayload.Value);
                dV_5 = (Convert.ToDouble(txtBox_etage5_g.Text) * Convert.ToDouble(numUD_etage5_isp.Value)) * Math.Log(m01_e5 / mf1_e5);
                txtBox_etage5_dV.Text = Convert.ToInt64(dV_5).ToString();
            }
            else
            {
                txtBox_etage5_dV.Text = "0";
            }

            txtBox_total_dV.Text = Convert.ToInt64(dV_1 + dV_2 + dV_3 + dV_4 + dV_5).ToString();
        }

        private void launchCkeckup()
        {
            if (txtBox_total_dV.Text != "0")
            {
                numUD_massePayload.Enabled = true;
                double val = Convert.ToDouble(txtBox_total_dV.Text);

                int marge = Convert.ToInt32(val - Convert.ToDouble(numUD_dV_requis.Value));
                txtBox_margeEstime.Text = marge.ToString() + " m/s";
                
                if (numUD_dV_requis.Value == 0)
                {
                    lbl_rapport.Text = "deltaV min requis";
                    lbl_rapport.ForeColor = Color.Orange;
                }
                else
                {
                    if (val < 0)
                    {
                        lbl_rapport.Text = "Valeur Δv total invalide";
                        lbl_rapport.ForeColor = Color.Red;
                    }
                    if (val < Convert.ToDouble(numUD_dV_requis.Value))
                    {
                        lbl_rapport.Text = "Configuration incorrecte";
                        lbl_rapport.ForeColor = Color.Red;
                    }
                    if (val == Convert.ToDouble(numUD_dV_requis.Value))
                    {
                        lbl_rapport.Text = "Configuration limite";
                        lbl_rapport.ForeColor = Color.OrangeRed;
                    }
                    if (val > Convert.ToDouble(numUD_dV_requis.Value))
                    {
                        lbl_rapport.Text = "Configuration OK";
                        lbl_rapport.ForeColor = Color.Green;
                    }

                    if (marge < 0)
                    {
                        txtBox_margeEstime.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtBox_margeEstime.ForeColor = Color.Empty;
                    }
                }
            }
        }

        private void frDeltaV_Calculator_Load(object sender, EventArgs e)
        {
            refreshStagingDisplay();
            foreach (DB_Astre a in DAO_Astre.getAstreList())
            {
                cbo_Astre.Items.Add(a.getName());
            }
            numUD_nbrEtage.Focus();
        }

        private void numUD_nbrEtage_ValueChanged(object sender, EventArgs e)
        {
            refreshStagingDisplay();
        }

        private void cbo_Astre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recherche de la valeur de gravité de surface à l'aide du nom renseigné dans la comboBox
            decimal value = DAO_Astre.getSurfaceGravityByName(cbo_Astre.SelectedItem.ToString());
            txtBox_etage1_g.Text = value.ToString();
            txtBox_etage2_g.Text = value.ToString();
            txtBox_etage3_g.Text = value.ToString();
            txtBox_etage4_g.Text = value.ToString();
            txtBox_etage5_g.Text = value.ToString();
        }

        private void btn_calculer_Click(object sender, EventArgs e)
        {
            if (txtBox_etage1_g.Text != "0" || txtBox_etage2_g.Text != "0" || txtBox_etage3_g.Text != "0" || txtBox_etage4_g.Text != "0" || txtBox_etage5_g.Text != "0")
            {
                calculateData();
                launchCkeckup();
            }
            else
            {
                MessageBox.Show(
                    "Calcul impossible.\n" +
                    "Veuillez renseigner une gravité de surface de référence et réessayer.",
                    "Avertissement : calculateur incomplet",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void numUD_dV_requis_ValueChanged(object sender, EventArgs e)
        {
            if (txtBox_total_dV.Text != "0")
            {
                calculateData();
                launchCkeckup();
            }
        }

        private void numUD_massePayload_ValueChanged(object sender, EventArgs e)
        {
            calculateData();
            launchCkeckup();
        }

        private void btn_toggleAide_Click(object sender, EventArgs e)
        {
            frAideCalculateur frAideCalculateur = new frAideCalculateur();
            frAideCalculateur.Show();
        }
    }
}
