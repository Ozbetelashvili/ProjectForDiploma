using Newtonsoft.Json;
using SSU_Diploma.Synchronization.Model;
using System;
using System.Collections.Generic;
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
        StudentData result = null;

        public StudentServiceHandler()
        {
            _api = "http://217.147.236.36:8001/getstudentdatanoimage?pmPersonalNumber=";
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
    }
}
