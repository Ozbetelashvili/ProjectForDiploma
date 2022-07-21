using SSU_Diploma.Faculty.Forms;
using SSU_Diploma.Students.forms;
using SSU_Diploma.Users.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.MainForm
{
    public partial class frmMain : Form
    {
        public string UserName { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var frm = new frmMainForm();
            frm.MdiParent = this;
            tsUser.Text = UserName;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("გსურთ პროგრამიდან გამოსვლა?", "ყურადღება...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                e.Cancel = false;
                var frm = new frmLogin();
                frm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ფაკულტეტიToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmFacultyList();
            frm.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            var frm = new frmUsers();
            frm.Show();
        }

        private void tsStudents_Click(object sender, EventArgs e)
        {
            var frm = new frmMainForm();
            frm.Show();
        }
    }
}
