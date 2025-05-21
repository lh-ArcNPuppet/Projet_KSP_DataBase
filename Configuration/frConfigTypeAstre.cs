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
    public partial class frConfigTypeAstre: Form
    {
        public frConfigTypeAstre()
        {
            InitializeComponent();
        }
        private void getListTypeAstre()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var typeAstres = DAO_TypeAstre.getTypeAstreList();

            foreach (var typeAstre in typeAstres)
            {
                var row = dt.NewRow();

                row["ID"] = typeAstre.getId();
                row["Libellé"] = typeAstre.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listTypeAstre.DataSource = dt;
        }
        private void frConfigTypeAstre_Load(object sender, EventArgs e)
        {
            getListTypeAstre();
        }
    }
}
