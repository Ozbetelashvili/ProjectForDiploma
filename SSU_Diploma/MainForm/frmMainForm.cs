using SSU_Diploma.MainForm.Handler;
using SSU_Diploma.Students.forms;
using SSU_Diploma.Students.Handler;
using SSU_Diploma.Synchronization.Forms;
using SSU_Diploma.Synchronization.Handler;
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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            var hh = new MainHandler();
            hh.FillFaculties(cmbFaculty);
            hh.FillEducationLevel(cmbEducationLevel);
        }

        public int ID { get; set; }
        public string FullName { get { return txtFullName.Text; } set { txtFullName.Text = value; } }
        public string PrivateNo { get { return txtPrivateNo.Text; } set { txtPrivateNo.Text = value; } }
        public string Semester { get { return txtSemester.Text; } set { txtSemester.Text = value; } }
        public string CardNo { get { return txtCardNo.Text; } set { txtCardNo.Text = value; } }
        public int Faculty
        {
            get { return cmbFaculty.SelectedIndex >= 0 ? (int)cmbFaculty.SelectedValue : 0; }
            set { cmbFaculty.SelectedValue = value; }
        }
        public int Diretion
        {
            get { return cmbDiretion.SelectedIndex >= 0 ? (int)cmbDiretion.SelectedValue : 0; }
            set { cmbDiretion.SelectedValue = value; }
        }
        public int EducationLevel
        {
            get { return cmbEducationLevel.SelectedIndex >= 0 ? (int)cmbEducationLevel.SelectedValue : 0; }
            set { cmbEducationLevel.SelectedValue = value; }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var sth = new StudentsHandler();
            gc.DataSource = sth.StudentsListGet();
            gw.BestFitColumns();
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hh = new MainHandler();
            hh.FillDirection(cmbDiretion, cmbFaculty.SelectedIndex);
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmStudentInfo();
            frm.StudentID = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            var frm = new frmStudentInfo();
            frm.StudentID = Convert.ToInt32(gw.GetFocusedRowCellValue(colID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sth = new StudentsHandler();
            gc.DataSource = sth.StudentsListGetSearch(txtFullName.Text, txtPrivateNo.Text, cmbEducationLevel.SelectedIndex, cmbFaculty.SelectedIndex, cmbDiretion.SelectedIndex, txtSemester.Text);
            gw.BestFitColumns();
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            var ID = Int32.Parse(gw.GetFocusedRowCellValue(colID).ToString());
            var handler = new StudentsHandler();
            handler.PrintStudentCard(ID);
        }

        private async void tsSync_Click(object sender, EventArgs e)
        {
            var frm = new frmGetPrivateNo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var handler = new StudentServiceHandler();
                var result = await handler.GetStudentInfo(frm.privateNo);

                var form = new frmSyncInfo(result);
                form.Show();

            }
        }
    }
}
