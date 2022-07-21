using SSU_Diploma.MainForm.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SSU_Diploma.Database.Database;

namespace SSU_Diploma.MainForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Database.Database.SetInputLanguage(InputLanguages.Georgia);
            var hh = new MainHandler();
            hh.FillUsersCombo(cmbUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == -1)
            {
                MessageBox.Show("გთხოვთ აირჩიოთ მომხმარებელი.", "სოხუმის სახელმწიფო უნივერსიტეტი");
                return;
            }

            var frm = new frmMain();
            frm.UserName = cmbUser.Text;
            frm.Show();
            this.Hide();
        }

    }
}
