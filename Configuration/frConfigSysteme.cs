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
    public partial class frConfigSysteme: Form
    {
        public frConfigSysteme()
        {
            InitializeComponent();
        }
        private void getListSysteme()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var systemes = DAO_Systeme.getSystemeList();

            foreach (var systeme in systemes)
            {
                var row = dt.NewRow();

                row["ID"] = systeme.getId();
                row["Libellé"] = systeme.getDescription();

                dt.Rows.Add(row);
            }

            dgv_listSysteme.DataSource = dt;
        }
        private void frConfigSysteme_Load(object sender, EventArgs e)
        {
            getListSysteme();
        }
    }
}
