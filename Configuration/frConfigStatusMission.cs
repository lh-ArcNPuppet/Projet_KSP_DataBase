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
    public partial class frConfigStatusMission: Form
    {
        public frConfigStatusMission()
        {
            InitializeComponent();
        }
        private void getListStatusMission()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var statusMissions = DAO_StatusMission.getStatusMissionList();

            foreach (var statusMission in statusMissions)
            {
                var row = dt.NewRow();

                row["ID"] = statusMission.getId();
                row["Libellé"] = statusMission.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listStatusMission.DataSource = dt;
        }
        private void frConfigStatusMission_Load(object sender, EventArgs e)
        {
            getListStatusMission();
        }
    }
}
