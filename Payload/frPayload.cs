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

namespace Payload
{
    public partial class frPayload: Form
    {
        public frPayload()
        {
            InitializeComponent();
        }
        private void getListPayloads()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Type payload");
            dt.Columns.Add("delta V");
            dt.Columns.Add("Masse");
            dt.Columns.Add("nbr Vol");
            dt.Columns.Add("Commentaire(s)");

            var payloads = DAO_Payload.getPayloadList();

            foreach (var payload in payloads)
            {
                var row = dt.NewRow();

                row["ID"] = payload.getId();
                row["Nom"] = payload.getName();
                row["Type payload"] = payload.getType();
                row["delta V"] = payload.getDeltaV();
                row["Masse"] = payload.getWeight();
                row["nbr Vol"] = payload.getNbrVol();
                row["Commentaire(s)"] = payload.getComment();

                dt.Rows.Add(row);
            }

            dgv_listPayloads.DataSource = dt;
        }

        private void frPayload_Load(object sender, EventArgs e)
        {
            getListPayloads();
        }
    }
}
