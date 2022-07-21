using SSU_Diploma.Faculty.Handler;
using SSU_Diploma.Faculty.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Faculty.Forms
{
    public partial class frmFalultyAndDirectionAddEdit : Form
    {
        public frmFalultyAndDirectionAddEdit()
        {
            InitializeComponent();
        }
        public int ID;
        public int UsingParentID;
        public int ParentID { get { return Convert.ToInt32(cmbGroup.SelectedValue); } set { cmbGroup.SelectedValue = value; } }
        public string FacultyName { get { return txtName.Text.Trim(); } set { txtName.Text = value; } }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = -1;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int selectPatientId;
            if (cmbGroup.SelectedIndex == -1)
            {
                selectPatientId = -1;
            }
            else { selectPatientId = ParentID; }
            FacultyModel fm = new FacultyModel();
            FacultyHandler fh = new FacultyHandler(fm);
            fm.FacultyName = FacultyName;
            fm.ParentID = selectPatientId;
            fm.ID = ID;

            ID = fh.FacultySet();
            if (Modal) { DialogResult = DialogResult.OK; } else { this.Close(); }
        }

        private void frmFalultyAndDirectionAddEdit_Load(object sender, EventArgs e)
        {
            FacultyModel fm = new FacultyModel();
            FacultyHandler fh = new FacultyHandler();


            fh.FacultyFillCombo(cmbGroup, UsingParentID - 1);
            if (ID > 0)
            {
                fm = fh.FacultyGet(ID - 1);
                ID = fm.ID;
                ParentID = fm.ParentID;
                FacultyName = fm.FacultyName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
