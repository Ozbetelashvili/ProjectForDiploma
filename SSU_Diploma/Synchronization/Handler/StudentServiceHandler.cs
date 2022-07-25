using Newtonsoft.Json;
using SSU_Diploma.Synchronization.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Synchronization.Handler
{
    public class StudentServiceHandler
    {
        private readonly string _api;
        private readonly SaveSyncData _model;
        StudentData result = null;

        public StudentServiceHandler()
        {
            _api = "http://217.147.236.36:8001/getstudentdatanoimage?pmPersonalNumber=";
        }

        public StudentServiceHandler(SaveSyncData model)
        {
            _model = model;
        }

        public async Task<StudentData> GetStudentInfo(string request)
        {
            try
            {
                string value;
                string json;
                json = JsonConvert.SerializeObject(request);

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_api + request);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (StreamWriter streamWriter = new StreamWriter(await httpWebRequest.GetRequestStreamAsync()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)(await httpWebRequest.GetResponseAsync());
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    value = streamReader.ReadToEnd();
                }

                //გაპარსავს დაბრუნებულ შედეგს
                return result = JsonConvert.DeserializeObject<StudentData>(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Boolean SaveData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SaveSyncData", Database.Database.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", _model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", _model.LastName);
                    cmd.Parameters.AddWithValue("@PrivateNo", _model.PersonalNumber);
                    cmd.Parameters.AddWithValue("@BirthDate", _model.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", _model.Gender);
                    cmd.Parameters.AddWithValue("@Address", _model.PostalAddress);
                    cmd.Parameters.AddWithValue("@Phone", _model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", _model.EmailAddress);
                    cmd.Parameters.AddWithValue("@Faculty", _model.Faculty);
                    cmd.Parameters.AddWithValue("@Program", _model.Program);
                    cmd.Parameters.AddWithValue("@Semester", _model.Semester);
                    cmd.Parameters.AddWithValue("@Level", _model.Level);
                    cmd.Parameters.AddWithValue("@status", _model.status);

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
