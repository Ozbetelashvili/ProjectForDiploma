using SSU_Diploma.Faculty.Handler;
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
    public partial class frmFacultyList : Form
    {
        public frmFacultyList()
        {
            InitializeComponent();
        }


        private void frmFacultyList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var hh = new FacultyHandler();
            trFaculty.DataSource = hh.FacultyListGet();
            trFaculty.BestFitColumns();
        }


        private void tsAdd_Click(object sender, EventArgs e)
        {
            int UsingparentID;
            if (trFaculty.GetFocusedRowCellValue(trParentID) == DBNull.Value)
            {
                UsingparentID = 0;
            }
            else { UsingparentID = Convert.ToInt32(trFaculty.GetFocusedRowCellValue(trParentID)); }


            var form = new frmFalultyAndDirectionAddEdit();
            form.ID = 0;
            form.UsingParentID = UsingparentID;

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            //int UsingparentID;
            //if (trFaculty.GetFocusedRowCellValue(trParentID) == DBNull.Value)
            //{
            //    UsingparentID = 0;
            //}
            //else { UsingparentID = Convert.ToInt32(trFaculty.GetFocusedRowCellValue(trParentID)); }

            var form = new frmFalultyAndDirectionAddEdit();
            form.ID = Convert.ToInt32(trFaculty.GetFocusedRowCellValue(trIteratorID));
            form.UsingParentID = trFaculty.GetFocusedRowCellValue(trParentID) is DBNull ? -1 : Convert.ToInt32(trFaculty.GetFocusedRowCellValue(trParentID));

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
