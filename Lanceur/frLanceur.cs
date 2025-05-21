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

namespace Lanceur
{
    public partial class frLanceur: Form
    {
        public frLanceur()
        {
            InitializeComponent();
        }
        private void getListLanceurs()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Type lanceur");
            dt.Columns.Add("Nbr étage");
            dt.Columns.Add("delta V");
            dt.Columns.Add("LEO Max");
            dt.Columns.Add("nbr Vol");
            dt.Columns.Add("Commentaire(s)");

            var lanceurs = DAO_Lanceur.getLanceurList();

            foreach (var lanceur in lanceurs)
            {
                var row = dt.NewRow();

                row["ID"] = lanceur.getId();
                row["Nom"] = lanceur.getName();
                row["Type lanceur"] = lanceur.getType();
                row["Nbr étage"] = lanceur.getNbrStage();
                row["delta V"] = lanceur.getDeltaV();
                row["LEO Max"] = lanceur.getLEO_Max();
                row["nbr Vol"] = lanceur.getNbrVol();
                row["Commentaire(s)"] = lanceur.getComment();

                dt.Rows.Add(row);
            }

            dgv_listeLanceur.DataSource = dt;
        }

        private void frLanceur_Load(object sender, EventArgs e)
        {
            getListLanceurs();
        }
    }
}
