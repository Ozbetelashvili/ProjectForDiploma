using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Diploma.Database
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(@"Data Source=NOZBETELASHVILI\SQLEXPRESS;Encrypt=False;Initial Catalog=Test;Integrated Security=True;User ID=NOZBETELASHVILI\user");
            return conn;
        }

        public enum InputLanguages
        {
            Georgia,
            English
        }

        public static void SetInputLanguage(InputLanguages lang)
        {
            try
            {
                switch (lang)
                {
                    case InputLanguages.Georgia:
                        {
                            var TypeOfLanguage = new System.Globalization.CultureInfo("KA-GE"); // or "fa-IR" for Farsi(Iran) 
                            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
                            break;
                        }

                    case InputLanguages.English:
                        {
                            var TypeOfLanguage = new System.Globalization.CultureInfo("EN-US");
                            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
