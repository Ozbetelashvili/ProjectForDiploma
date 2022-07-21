using SSU_Diploma.Users.Handler;
using SSU_Diploma.Users.Model;
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
    public partial class frmUserAddEdit : Form
    {
        public frmUserAddEdit()
        {
            InitializeComponent();
        }

        public int ID;
        public string UserName { get { return txtUserName.Text.Trim(); } set { txtUserName.Text = value; } }
        public bool IsActive { get { return ckbIsActive.Checked; } set { ckbIsActive.Checked = value; } }

        private void btnApply_Click(object sender, EventArgs e)
        {
            UsersModel um = new UsersModel();
            UsersHandler uh = new UsersHandler(um);
            um.ID = ID;
            um.UserName = UserName;
            um.IsActive = IsActive;

            ID = uh.UsersSet();
            if (Modal) { DialogResult = DialogResult.OK; } else { this.Close(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserAddEdit_Load(object sender, EventArgs e)
        {
            UsersModel um = new UsersModel();
            UsersHandler uh = new UsersHandler();

            if (ID > 0)
            {
                um = uh.UsersGet(ID);

                ID = um.ID;
                UserName = um.UserName;
                IsActive = um.IsActive;
            }
        }
    }
}
