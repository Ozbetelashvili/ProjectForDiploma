using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Synchronization.Forms
{
    public partial class frmGetPrivateNo : Form
    {
        public frmGetPrivateNo()
        {
            InitializeComponent();
        }

        public string privateNo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            privateNo = txtPrivateNo.Text.ToString();
            if (privateNo.Length != 11)
            {
                MessageBox.Show("არასრული პირადი ნომერი", "ინფო", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void txtPrivateNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }
    }
}
