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

namespace Kerbonaute
{
    public partial class frAstronaute: Form
    {
        public frAstronaute()
        {
            InitializeComponent();
        }
        private void getListAstronautes()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Sexe");
            dt.Columns.Add("Profession");
            dt.Columns.Add("Niveau");
            dt.Columns.Add("Vétéran");
            dt.Columns.Add("Status vital");
            dt.Columns.Add("Nbr vol");

            var astronautes = DAO_Astronaute.getAstronauteList();

            foreach (var astronaute in astronautes)
            {
                var row = dt.NewRow();

                row["ID"] = astronaute.getId();
                row["Nom"] = astronaute.getName();
                row["Sexe"] = astronaute.getSexe();
                row["Profession"] = astronaute.getProfession();
                row["Niveau"] = astronaute.getLevel();
                row["Vétéran"] = astronaute.getVeteranState();
                row["Status vital"] = astronaute.getVitalsState();
                row["Nbr vol"] = astronaute.getNbrVol();

                dt.Rows.Add(row);
            }

            dgv_listKerbonaute.DataSource = dt;
        }
        private void frAstronaute_Load(object sender, EventArgs e)
        {
            getListAstronautes();
        }
    }
}
