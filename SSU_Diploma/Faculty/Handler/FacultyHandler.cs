using SSU_Diploma.Faculty.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Faculty.Handler
{
    class FacultyHandler
    {

        public readonly FacultyModel _fm;

        public FacultyHandler() { }
        public FacultyHandler(FacultyModel fm) { _fm = fm; }

        public DataTable FacultyListGet()
        {
            var dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.FacultyListGet", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public int FacultySet()
        {
            int recordID = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.FacultySet", Database.Database.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", _fm.ID);
                    cmd.Parameters.AddWithValue("@Name", _fm.FacultyName);
                    cmd.Parameters.AddWithValue("@ParentID", _fm.ParentID);
                    cmd.Connection.Open();

                    recordID = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            return recordID;
        }

        //ჯგუფის კომბოს შევსება
        public void FacultyFillCombo(ComboBox combo, int selectedID)
        {

            DataTable dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.FacultyGetforAddEdit", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ParentID", selectedID);
                    da.Fill(dt);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            combo.DataSource = dt;
            combo.DisplayMember = "FacultyName";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
        }

        //
        public FacultyModel FacultyGet(int ID)
        {
            var dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("dbo.FacultyGetByID", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    da.Fill(dt);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            FacultyModel dm = new FacultyModel();
            dm.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            dm.ParentID = dt.Rows[0]["ParentID"] is DBNull ? -1 : Convert.ToInt32(dt.Rows[0]["ParentID"]);
            dm.FacultyName = dt.Rows[0]["FacultyName"].ToString();

            return dm;
        }


    }
}
