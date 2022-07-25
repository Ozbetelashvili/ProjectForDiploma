using SSU_Diploma.Synchronization.Handler;
using SSU_Diploma.Synchronization.Model;
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
    public partial class frmSyncInfo : Form
    {
        public frmSyncInfo(StudentData result)
        {
            InitializeComponent();
            LoadInfo(result.StudentDataReply);
        }

        #region properties
        public string FirstName
        {
            get
            {
                if (txtFirstName.Enabled == true && !string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    if (txtFirstName.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtFirstName.Text;
                }
                else return null;
            }
            set { }
        }
        public string LastName
        {
            get
            {
                if (txtLastName.Enabled == true && !string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    if (txtLastName.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtLastName.Text;
                }
                else return null;
            }
            set { }
        }
        public string PrivateNo
        {
            get
            {
                if (txtPriveNo.Enabled == true && !string.IsNullOrWhiteSpace(txtPriveNo.Text))
                {
                    if (txtPriveNo.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtPriveNo.Text;
                }
                else return null;
            }
            set { }
        }
        public string DOB
        {
            get
            {
                if (txtDateOfBirth.Enabled == true && !string.IsNullOrWhiteSpace(txtDateOfBirth.Text))
                {
                    if (txtDateOfBirth.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtDateOfBirth.Text;
                }
                else return null;
            }
            set { }
        }
        public string Gender
        {
            get
            {
                if (txtGender.Enabled == true && !string.IsNullOrWhiteSpace(txtGender.Text))
                {
                    if (txtGender.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtGender.Text;
                }
                else return null;
            }
            set { }
        }
        public string Address
        {
            get
            {
                if (txtAddress.Enabled == true && !string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    if (txtAddress.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtAddress.Text;
                }
                else return null;
            }
            set { }
        }
        public string Phone
        {
            get
            {
                if (txtPhone.Enabled == true && !string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    if (txtPhone.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtPhone.Text;
                }
                else return null;
            }
            set { }
        }
        public string Email
        {
            get
            {
                if (txtEmail.Enabled == true && !string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    if (txtEmail.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtEmail.Text;
                }
                else return null;
            }
            set { }
        }
        public string Faculty
        {
            get
            {
                if (txtFaculty.Enabled == true && !string.IsNullOrWhiteSpace(txtFaculty.Text))
                {
                    if (txtFaculty.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtFaculty.Text;
                }
                else return null;
            }
            set { }
        }
        public string Program
        {
            get
            {
                if (txtProgram.Enabled == true && !string.IsNullOrWhiteSpace(txtProgram.Text))
                {
                    if (txtProgram.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtProgram.Text;
                }
                else return null;
            }
            set { }
        }
        public string Semester
        {
            get
            {
                if (txtSemester.Enabled == true && !string.IsNullOrWhiteSpace(txtSemester.Text))
                {
                    if (txtSemester.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtSemester.Text;
                }
                else return null;
            }
            set { }
        }
        public string Level
        {
            get
            {
                if (txtLevel.Enabled == true && !string.IsNullOrWhiteSpace(txtLevel.Text))
                {
                    if (txtLevel.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtLevel.Text;
                }
                else return null;
            }
            set { }
        }
        public string Status
        {
            get
            {
                if (txtStatus.Enabled == true && !string.IsNullOrWhiteSpace(txtStatus.Text))
                {
                    if (txtStatus.Text.Contains("-"))
                    {
                        return null;
                    }
                    else return txtStatus.Text;
                }
                else return null;
            }
            set { }
        }

        #endregion

        private void LoadInfo(StudentModel data)
        {
            txtFirstName.Text = data.FirstName;
            txtLastName.Text = data.LastName;
            txtPriveNo.Text = data.PersonalNumber;
            txtDateOfBirth.Text = data.BirthDate;
            txtGender.Text = data.Gender;
            txtAddress.Text = data.PostalAddress;
            txtPhone.Text = data.PhoneNumber;
            txtEmail.Text = data.EmailAddress;
            txtFaculty.Text = data.Faculty;
            txtProgram.Text = data.Program;
            txtSemester.Text = data.Semester;
            txtLevel.Text = data.Level;
            txtStatus.Text = data.State;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var mm = new SaveSyncData();

            mm.FirstName = FirstName;
            mm.LastName = LastName;
            mm.PersonalNumber = PrivateNo;
            mm.BirthDate = DOB;
            mm.Gender = Gender;
            mm.PostalAddress = Address;
            mm.PhoneNumber = Phone;
            mm.EmailAddress = Email;
            mm.Faculty = Faculty;
            mm.Program = Program;
            mm.Semester = Semester;
            mm.Level = Level;
            mm.status = Status;

            var hh = new StudentServiceHandler(mm);
            if (hh.SaveData()) {
                this.DialogResult = DialogResult.OK;
            }
        }

        #region checkBoxs
        private void cbFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFirstName.Checked) txtFirstName.Enabled = true;
            else txtFirstName.Enabled = false;
        }
        private void cbLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLastName.Checked) txtLastName.Enabled = true;
            else txtLastName.Enabled = false;
        }

        private void ckPrivateNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrivateNo.Checked) txtPriveNo.Enabled = true;
            else txtPriveNo.Enabled = false;
        }

        private void cbDateOfBirth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateOfBirth.Checked) txtDateOfBirth.Enabled = true;
            else txtDateOfBirth.Enabled = false;
        }

        private void cbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGender.Checked) txtGender.Enabled = true;
            else txtGender.Enabled = false;
        }

        private void cbAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddress.Checked) txtAddress.Enabled = true;
            else txtAddress.Enabled = false;
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhone.Checked) txtPhone.Enabled = true;
            else txtPhone.Enabled = false;
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked) txtEmail.Enabled = true;
            else txtEmail.Enabled = false;
        }

        private void cbFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFaculty.Checked) txtFaculty.Enabled = true;
            else txtFaculty.Enabled = false;
        }

        private void cbProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProgram.Checked) txtProgram.Enabled = true;
            else txtProgram.Enabled = false;
        }

        private void cbSemester_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSemester.Checked) txtSemester.Enabled = true;
            else txtSemester.Enabled = false;
        }

        private void cbLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLevel.Checked) txtLevel.Enabled = true;
            else txtLevel.Enabled = false;
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Checked) txtStatus.Enabled = true;
            else txtStatus.Enabled = false;
        }
        #endregion
    }
}
