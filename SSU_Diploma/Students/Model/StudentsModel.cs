using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU_Diploma.Students.Model
{
    class StudentsModel
    {
        public int ID { get; set; }
        public byte[] StudentsImage { get; set; }
        public byte[] PrivateImage1 { get; set; }
        public byte[] PrivateImage2 { get; set; }
        public string FullNameGeo { get; set; }
        public string FullNameEn { get; set; }
        public string FatherName { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PrivateNo { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EnrollmentOrderNo { get; set; }
        public string DocumentNo { get; set; }
        public Boolean Status { get; set; }
        public int MajorFaculty { get; set; }
        public int MajorDirection { get; set; }
        public int? MinorFaculty { get; set; }
        public int? MinorDirection { get; set; }
        public int LearningLanguage { get; set; }
        public int EducationLevel { get; set; }
        public string Semester { get; set; }
        public Boolean AwardedDiploma { get; set; }
        public string AwardedDiplomaOrderNo { get; set; }

    }
}
