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
    public partial class frConfigProfession: Form
    {
        public frConfigProfession()
        {
            InitializeComponent();
        }
        private void getListProfession()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var professions = DAO_Profession.getProfessionList();

            foreach (var profession in professions)
            {
                var row = dt.NewRow();

                row["ID"] = profession.getId();
                row["Libellé"] = profession.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listProfession.DataSource = dt;
        }
        private void frConfigProfession_Load(object sender, EventArgs e)
        {
            getListProfession();
        }
    }
}
