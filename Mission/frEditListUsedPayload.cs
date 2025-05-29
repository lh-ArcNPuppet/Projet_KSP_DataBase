using LIB_BLL;
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

namespace Mission
{
    public partial class frEditListUsedPayload : Form
    {
        public frEditListUsedPayload()
        {
            InitializeComponent();
        }

        private void frEditListUsedPayload_Load(object sender, EventArgs e)
        {
            foreach (DB_Astronaute astronaute in DAO_Astronaute.getAstronauteList())
            {
                cbo_listAstronaute.Items.Add(astronaute.getName());
            }
        }
    }
}
