using SSU_Diploma.Users.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Users.Forms
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsersAddEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmUserAddEdit();
            frm.ID = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            var frm = new frmUserAddEdit();
            frm.ID = Convert.ToInt32(gw.GetFocusedRowCellValue(colID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            var hh = new UsersHandler();
            gc.DataSource = hh.UserListGet();
            gw.BestFitColumns();
        }

    }
}
