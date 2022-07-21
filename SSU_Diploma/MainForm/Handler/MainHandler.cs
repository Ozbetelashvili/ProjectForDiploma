using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.MainForm.Handler
{
    class MainHandler
    {
        #region Fill Combo
        public void FillUsersCombo(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.UserGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            combo.DataSource = dt;
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
        }

        public Boolean FillFaculties(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.FacultyGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            combo.DataSource = dt;
            combo.DisplayMember = "FacultyName";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
            return true;
        }

        public void FillDirection(ComboBox cb, int? FacultyID)
        {
            var dt = new DataTable();
            try
            {
                using (SqlDataAdapter elg = new SqlDataAdapter("dbo.FacultyGet", Database.Database.GetConnection()))
                {
                    elg.SelectCommand.CommandType = CommandType.StoredProcedure;
                    elg.SelectCommand.Parameters.AddWithValue("@ParentID", FacultyID);
                    elg.Fill(dt);
                    cb.DataSource = dt;
                    cb.ValueMember = "ID";
                    cb.DisplayMember = "FacultyName";
                    cb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LearningLanguageGet(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.LearningLanguageGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            combo.DataSource = dt;
            combo.DisplayMember = "LearningLanguage";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
        }

        public void FillEducationLevel(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.EducationLevelGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            combo.DataSource = dt;
            combo.DisplayMember = "EducationLavel";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
        }

        public void FillGender(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.GenderListGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            combo.DataSource = dt;
            combo.DisplayMember = "GenderName";
            combo.ValueMember = "GenderID";
            combo.SelectedIndex = -1;
        }

        #endregion


    }
}
