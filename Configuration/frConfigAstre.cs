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

namespace Configuration
{
    public partial class frConfigAstre: Form
    {
        public frConfigAstre()
        {
            InitializeComponent();
        }
        private void getListAstres()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Type");
            dt.Columns.Add("Système");

            var astres = DAO_Astre.getAstreList();

            foreach (var astre in astres)
            {
                var row = dt.NewRow();

                row["ID"] = astre.getId();
                row["Nom"] = astre.getName();
                row["Type"] = astre.getType();
                row["Système"] = astre.getRelatedSystem();

                dt.Rows.Add(row);
            }

            dgv_listeAstre.DataSource = dt;
        }

        private void frConfigAstre_Load(object sender, EventArgs e)
        {
            getListAstres();
        }
    }
}
