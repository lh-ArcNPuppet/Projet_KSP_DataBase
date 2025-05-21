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

namespace Configuration
{
    public partial class frConfigTypeLanceur: Form
    {
        public frConfigTypeLanceur()
        {
            InitializeComponent();
        }
        private void getListTypeLanceur()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Libellé");
            dt.Columns.Add("Description");

            var typeLanceurs = DAO_TypeLanceur.getTypeLanceurList();

            foreach (var typeLanceur in typeLanceurs)
            {
                var row = dt.NewRow();

                row["Code"] = typeLanceur.getCode();
                row["Libellé"] = typeLanceur.getLibelle();
                row["Description"] = typeLanceur.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listTypeLanceur.DataSource = dt;
        }
        private void frConfigTypeLanceur_Load(object sender, EventArgs e)
        {
            getListTypeLanceur();
        }
    }
}
