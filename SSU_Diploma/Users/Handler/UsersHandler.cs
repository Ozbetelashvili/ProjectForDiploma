using SSU_Diploma.Users.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Users.Handler
{
    class UsersHandler
    {
        public readonly UsersModel _um;

        public UsersHandler() { }
        public UsersHandler(UsersModel um) { _um = um; }

        public DataTable UserListGet()
        {
            var dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.UserListGet", Database.Database.GetConnection()))
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

        public int UsersSet()
        {
            int recordID = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UserSet", Database.Database.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", _um.ID);
                    cmd.Parameters.AddWithValue("@UserName", _um.UserName);
                    cmd.Parameters.AddWithValue("@IsActive", _um.IsActive);
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

        public UsersModel UsersGet(int ID)
        {
            var dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("dbo.UsersGetByID", Database.Database.GetConnection()))
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

            UsersModel um = new UsersModel();
            um.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            um.UserName = dt.Rows[0]["Name"].ToString();
            um.IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]);

            return um;
        }

    }
}
