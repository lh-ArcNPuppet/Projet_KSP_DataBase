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
    public partial class frConfigListePayload : Form
    {
        public frConfigListePayload()
        {
            InitializeComponent();
        }
        private void getListTypePayload()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Libellé");

            var typesPayload = DAO_TypePayload.getTypePayloadList();

            foreach (var typePayload in typesPayload)
            {
                var row = dt.NewRow();

                row["Code"] = typePayload.getCode();
                row["Libellé"] = typePayload.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listTypePayload.DataSource = dt;
        }

        private void frConfigListePayload_Load(object sender, EventArgs e)
        {
            getListTypePayload();
        }
    }
}
