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
    public partial class frConfigSituationActuelle: Form
    {
        public frConfigSituationActuelle()
        {
            InitializeComponent();
        }
        private void getListSituationActuelle()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Libellé");

            var situationActuelles = DAO_SituationActuelle.getSituationActuelleList();

            foreach (var situationActuelle in situationActuelles)
            {
                var row = dt.NewRow();

                row["ID"] = situationActuelle.getId();
                row["Libellé"] = situationActuelle.getLibelle();

                dt.Rows.Add(row);
            }

            dgv_listSituationActuelle.DataSource = dt;
        }
        private void frConfigSituationActuelle_Load(object sender, EventArgs e)
        {
            getListSituationActuelle();
        }
    }
}
