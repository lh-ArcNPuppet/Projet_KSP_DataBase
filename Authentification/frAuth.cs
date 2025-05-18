using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_DAL;

namespace Authentification
{
    public partial class frAuth: Form
    {
        private int failCount = 0;
        public frAuth()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
        }

        private void chk_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showPassword.Checked == true)
            {
                txtBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                bool verif = BDD_Connect.openConnexion(txtBox_username.Text, txtBox_password.Text);
                if (verif)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox_password.Clear();
                failCount++;
            }

            if (failCount == 5)
            {
                MessageBox.Show(
                    "Vous avez fait 5 tentatives d'authentification erroné.\n" +
                    "Par mesure de sécurité, l'application va se refermer.",
                    "Limites de tentatives erroné atteinte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Close();
            }
        }

    }
}
