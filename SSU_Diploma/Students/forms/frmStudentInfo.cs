using SSU_Diploma.MainForm.Handler;
using SSU_Diploma.Students.Handler;
using SSU_Diploma.Students.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SSU_Diploma.Database.Database;

namespace SSU_Diploma.Students.forms
{
    public partial class frmStudentInfo : Form
    {
        MainHandler hh = new MainHandler();
        public int StudentID { get; set; }
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("სტუდენტის ფოტოსურათი", picImage);
        }

        private void ckbAwardedDiploma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAwardedDiploma.Checked)
            {
                lblAwardedDiplomaOrderNo.Visible = true;
                txtAwardedDiplomaOrderNo.Visible = true;
            }
            else
            {
                lblAwardedDiplomaOrderNo.Visible = false;
                txtAwardedDiplomaOrderNo.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPrivateImage1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("პირადობის წინა მხრის ფოტო", picPrivateImage1);
        }

        private void picPrivateImage2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("პირადობის უკანა მხრის ფოტო", picPrivateImage2);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
            }
            else
            {
                var email = new Regex(@"([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})");
                if (email.IsMatch(txtEmail.Text))
                {
                }
                else
                {
                    MessageBox.Show("Email ფორმატი არასწორია");
                }
            }
            Database.Database.SetInputLanguage(InputLanguages.Georgia);
        }

        private void picImage_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = new OpenFileDialog();
            pic.Filter = "JPG ფაილი (*.JPG)|*.jpg|ყველა ფაილი (*.*)|*.*";
            if (pic.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(pic.FileName);
            }
        }

        private void picPrivateImage1_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = new OpenFileDialog();
            pic.Filter = "JPG ფაილი (*.JPG)|*.jpg|ყველა ფაილი (*.*)|*.*";
            if (pic.ShowDialog() == DialogResult.OK)
            {
                picPrivateImage1.Image = Image.FromFile(pic.FileName);
            }
        }

        private void picPrivateImage2_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = new OpenFileDialog();
            pic.Filter = "JPG ფაილი (*.JPG)|*.jpg|ყველა ფაილი (*.*)|*.*";
            if (pic.ShowDialog() == DialogResult.OK)
            {
                picPrivateImage2.Image = Image.FromFile(pic.FileName);
            }
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            hh.FillFaculties(cmbMajorFaculty);
            hh.FillFaculties(cmbMinorFaculty);
            hh.FillEducationLevel(cmbEducationLevel);
            hh.LearningLanguageGet(cmbLearningLanguage);
            cmbLearningLanguage.SelectedValue = 1;
            hh.FillGender(cmbGender);

            if (StudentID > 0)
            {
                var h = new StudentsHandler();

                var sm = h.StudentsGet(StudentID);
                if (sm.StudentsImage != null)
                {
                    var stream = new MemoryStream(sm.StudentsImage);
                    picImage.Image = Image.FromStream(stream);
                }
                if (sm.PrivateImage1 != null)
                {
                    var stream1 = new MemoryStream(sm.PrivateImage1);
                    picPrivateImage1.Image = Image.FromStream(stream1);
                }
                if (sm.PrivateImage2 != null)
                {
                    var stream2 = new MemoryStream(sm.PrivateImage2);
                    picPrivateImage2.Image = Image.FromStream(stream2);
                }
                StudentID = sm.ID;
                txtFullNameGeo.Text = sm.FullNameGeo;
                txtFullNameEN.Text = sm.FullNameEn;
                txtFatherName.Text = sm.FatherName;
                cmbGender.SelectedValue = sm.Gender;
                dtpDateOfBirth.Value = sm.DateOfBirth;
                txtPriveNo.Text = sm.PrivateNo;
                txtPhoneNo.Text = sm.PhoneNo;
                txtAddress.Text = sm.Address;
                txtEmail.Text = sm.Email;
                dtpEnrollmentDate.Value = sm.EnrollmentDate;
                txtEnrollmentOrderNo.Text = sm.EnrollmentOrderNo;
                txtDocumentNo.Text = sm.DocumentNo;
                ckbStatus.Checked = sm.Status;
                cmbMajorFaculty.SelectedValue = sm.MajorFaculty;
                cmbMajorDiretion.SelectedValue = sm.MajorDirection;
                cmbMinorFaculty.SelectedValue = sm.MinorFaculty;
                cmbMinorDirection.SelectedValue = sm.MinorDirection;
                cmbLearningLanguage.SelectedValue = sm.LearningLanguage;
                cmbEducationLevel.SelectedValue = sm.EducationLevel;
                txtSemester.Text = sm.Semester;
                ckbAwardedDiploma.Checked = sm.AwardedDiploma;
                txtAwardedDiplomaOrderNo.Text = sm.AwardedDiplomaOrderNo;

            }

        }

        private void cmbMajorFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            hh.FillDirection(cmbMajorDiretion, cmbMajorFaculty.SelectedIndex);
        }

        private void cmbMinorFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            hh.FillDirection(cmbMinorDirection, cmbMinorFaculty.SelectedIndex);
        }

        private bool validation()
        {
            if (string.IsNullOrWhiteSpace(txtPriveNo.Text))
            {
                MessageBox.Show("სტუდენტის პირადი ნომერი არ შეიძლება იყოს ცარიელი", "ყურადღება!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullNameGeo.Text))
            {
                MessageBox.Show("სტუდენტის გვარი და სახელი არ შეიძლება იყოს ცარიელი", "ყურადღება!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("აირჩიეთ სტუდენტის სქესი", "ყურადღება!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbMajorFaculty.SelectedIndex == -1 || cmbMajorDiretion.SelectedIndex == -1)
            {
                MessageBox.Show("ძირითადი სპეციალობა არ შეიძლება იყოს ცარიელი", "ყურადღება!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbEducationLevel.SelectedIndex == -1)
            {
                MessageBox.Show("სწავლების საფეხური არ შეიძლება იყოს ცარიელი", "ყურადღება!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                return;
            }

            var stream = new MemoryStream();
            var stream1 = new MemoryStream();
            var stream2 = new MemoryStream();
            var sm = new StudentsModel();
            sm.ID = StudentID;
            if (picImage.Image != null)
            {
                picImage.Image.Save(stream, picImage.Image.RawFormat);
                sm.StudentsImage = stream.ToArray();
            }
            if (picPrivateImage1.Image != null)
            {
                picPrivateImage1.Image.Save(stream1, picPrivateImage1.Image.RawFormat);
                sm.PrivateImage1 = stream1.ToArray();
            }
            if (picPrivateImage2.Image != null)
            {
                picPrivateImage2.Image.Save(stream2, picPrivateImage2.Image.RawFormat);
                sm.PrivateImage2 = stream2.ToArray();
            }

            sm.FullNameGeo = txtFullNameGeo.Text;
            sm.FullNameEn = txtFullNameEN.Text;
            sm.FatherName = txtFatherName.Text;
            sm.Gender = (int)cmbGender.SelectedValue;
            sm.DateOfBirth = dtpDateOfBirth.Value;
            sm.PrivateNo = txtPriveNo.Text;
            sm.PhoneNo = txtPhoneNo.Text;
            sm.Address = txtAddress.Text;
            sm.Email = txtEmail.Text;
            sm.EnrollmentDate = dtpEnrollmentDate.Value;
            sm.EnrollmentOrderNo = txtEnrollmentOrderNo.Text;
            sm.DocumentNo = txtDocumentNo.Text;
            sm.Status = ckbStatus.Checked;
            sm.MajorFaculty = (int)cmbMajorFaculty.SelectedValue;
            sm.MajorDirection = (int)cmbMajorDiretion.SelectedValue;
            sm.MinorFaculty = cmbMinorFaculty.SelectedValue == null ? -1 : (int)cmbMinorFaculty.SelectedValue;
            sm.MinorDirection = cmbMinorDirection.SelectedValue == null ? -1 : (int)cmbMinorDirection.SelectedValue;
            sm.LearningLanguage = (int)cmbLearningLanguage.SelectedValue;
            sm.EducationLevel = (int)cmbEducationLevel.SelectedValue;
            sm.Semester = txtSemester.Text;
            sm.AwardedDiploma = ckbAwardedDiploma.Checked;
            sm.AwardedDiplomaOrderNo = txtAwardedDiplomaOrderNo.Text;

            try
            {
                var handel = new StudentsHandler(sm);
                StudentID = handel.StudentsSet();
                if (Modal) { DialogResult = DialogResult.OK; } else { this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtFullNameEN_Leave(object sender, EventArgs e)
        {
            Database.Database.SetInputLanguage(InputLanguages.Georgia);
        }

        private void txtFullNameEN_Enter(object sender, EventArgs e)
        {
            Database.Database.SetInputLanguage(InputLanguages.English);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Database.Database.SetInputLanguage(InputLanguages.English);
        }

        private void btnDetelePrivateImage_Click(object sender, EventArgs e)
        {
            picPrivateImage1.Image = null;
            picPrivateImage2.Image = null;
        }
    }
}
