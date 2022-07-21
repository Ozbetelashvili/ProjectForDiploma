using SSU_Diploma.Students.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace SSU_Diploma.Students.Handler
{
    class StudentsHandler
    {
        public readonly StudentsModel _sm;

        public StudentsHandler() { }
        public StudentsHandler(StudentsModel sm) { _sm = sm; }

        //public static byte[] ImageToByte2(Image img)
        //{
        //    byte[] byteArray = new byte[0];
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        stream.Close();

        //        byteArray = stream.ToArray();
        //    }
        //    return byteArray;
        //}



        public int UsersSet()
        {
            int recordID = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.StudentsSet", Database.Database.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", _sm.ID);
                    cmd.Parameters.AddWithValue("@StudentsImage", _sm.StudentsImage);
                    cmd.Parameters.AddWithValue("@PrivateImage1", _sm.PrivateImage1);
                    cmd.Parameters.AddWithValue("@PrivateImage2", _sm.PrivateImage2);
                    cmd.Parameters.AddWithValue("@FullNameGeo", _sm.FullNameGeo);
                    cmd.Parameters.AddWithValue("@FullNameEn", _sm.FullNameEn);
                    cmd.Parameters.AddWithValue("@FatherName", _sm.FatherName);
                    cmd.Parameters.AddWithValue("@Gender", _sm.Gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", _sm.DateOfBirth);
                    cmd.Parameters.AddWithValue("@PrivateNo", _sm.PrivateNo);
                    cmd.Parameters.AddWithValue("@PhoneNo", _sm.PhoneNo);
                    cmd.Parameters.AddWithValue("@Address", _sm.Address);
                    cmd.Parameters.AddWithValue("@Email", _sm.Email);
                    cmd.Parameters.AddWithValue("@EnrollmentDate", _sm.EnrollmentDate);
                    cmd.Parameters.AddWithValue("@EnrollmentOrderNo", _sm.EnrollmentOrderNo);
                    cmd.Parameters.AddWithValue("@DocumentNo", _sm.DocumentNo);
                    cmd.Parameters.AddWithValue("@Status", _sm.Status);
                    cmd.Parameters.AddWithValue("@MajorFacultyID", _sm.MajorFaculty);
                    cmd.Parameters.AddWithValue("@MajorDirectionID", _sm.MajorDirection);
                    cmd.Parameters.AddWithValue("@MinorFacultyID", _sm.MinorFaculty == -1 ? null : _sm.MinorFaculty);
                    cmd.Parameters.AddWithValue("@MinorDirectionID", _sm.MinorDirection == -1 ? null : _sm.MinorDirection);
                    cmd.Parameters.AddWithValue("@EducationLevelID", _sm.EducationLevel);
                    cmd.Parameters.AddWithValue("@LearningLanguage", _sm.LearningLanguage);
                    cmd.Parameters.AddWithValue("@Semester", _sm.Semester);
                    cmd.Parameters.AddWithValue("@AwardedDiploma", _sm.AwardedDiploma);
                    cmd.Parameters.AddWithValue("@AwardedDiplomaOrderNo", _sm.AwardedDiplomaOrderNo);
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

        public DataTable StudentsListGet()
        {
            var dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.StudentsListGet", Database.Database.GetConnection()))
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

        public DataTable StudentsListGetSearch(string fullname, string privateNo, int? educationLevel, int? faculty, int? direction, string semester)
        {
            var dt = new DataTable();
            try
            {
                using (var da = new SqlDataAdapter("dbo.StudentsListGetSearch", Database.Database.GetConnection()))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@FullName", fullname);
                    da.SelectCommand.Parameters.AddWithValue("@PrivateNo", privateNo);
                    da.SelectCommand.Parameters.AddWithValue("@EducationLevel", educationLevel);
                    da.SelectCommand.Parameters.AddWithValue("@FacultyID", faculty);
                    da.SelectCommand.Parameters.AddWithValue("@DirectionID", direction);
                    da.SelectCommand.Parameters.AddWithValue("@Semester", semester);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public StudentsModel StudentsGet(int ID)
        {
            var dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("dbo.StudentsGet", Database.Database.GetConnection()))
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

            StudentsModel dm = new StudentsModel();
            dm.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            dm.StudentsImage = dt.Rows[0]["StudentsImage"] == DBNull.Value ? null : (byte[])dt.Rows[0]["StudentsImage"];
            dm.PrivateImage1 = dt.Rows[0]["PrivateImage1"] == DBNull.Value ? null : (byte[])dt.Rows[0]["PrivateImage1"];
            dm.PrivateImage2 = dt.Rows[0]["PrivateImage2"] == DBNull.Value ? null : (byte[])dt.Rows[0]["PrivateImage2"];
            dm.FullNameGeo = dt.Rows[0]["FullNameGeo"].ToString();
            dm.FullNameEn = dt.Rows[0]["FullNameEn"].ToString();
            dm.FatherName = dt.Rows[0]["FatherName"].ToString();
            dm.Gender = Convert.ToInt32(dt.Rows[0]["GenderID"]);
            dm.DateOfBirth = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"]);
            dm.PrivateNo = dt.Rows[0]["PrivateNo"].ToString();
            dm.PhoneNo = dt.Rows[0]["Mobile"].ToString();
            dm.Address = dt.Rows[0]["Address"].ToString();
            dm.Email = dt.Rows[0]["Email"].ToString();
            dm.Status = (Boolean)dt.Rows[0]["status"];
            dm.EnrollmentDate = Convert.ToDateTime(dt.Rows[0]["EnrollmentDate"]);
            dm.EnrollmentOrderNo = dt.Rows[0]["EnrollmentOrderNo"].ToString();
            dm.DocumentNo = dt.Rows[0]["DocumentNo"].ToString();
            dm.MajorFaculty = Convert.ToInt32(dt.Rows[0]["MajorFacultyID"]);
            dm.MajorDirection = Convert.ToInt32(dt.Rows[0]["MajorDirectionID"]);
            dm.MinorFaculty = dt.Rows[0]["MinorFacultyID"] == DBNull.Value ? -1 : Convert.ToInt32(dt.Rows[0]["MinorFacultyID"]);
            dm.MinorDirection = dt.Rows[0]["MinorDirectionID"] == DBNull.Value ? -1 : Convert.ToInt32(dt.Rows[0]["MinorDirectionID"]);
            dm.EducationLevel = Convert.ToInt32(dt.Rows[0]["EducationLevelID"]);
            dm.LearningLanguage = Convert.ToInt32(dt.Rows[0]["LearningLanguage"]);
            dm.Semester = dt.Rows[0]["Semester"].ToString();
            dm.AwardedDiploma = (Boolean)dt.Rows[0]["AwardedDiploma"];
            dm.AwardedDiplomaOrderNo = dt.Rows[0]["AwardedDiplomaOrderNo"].ToString();

            return dm;
        }


    }
}
