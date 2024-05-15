using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CV
    {
        private int id; // id user
        private int idCv;
        private string name;
        private string gender;
        private string address;

        private string dateOfBirth;

        private string workExperience;
        private string educationAndCertifications;
        private string professionalSkills;
        private string goalsatwork;
        public CV() { }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }

        public string WorkExperience { get { return workExperience; } set { workExperience = value; } }
        public string EducationAndCertifications { get { return educationAndCertifications; } set { educationAndCertifications = value; } }
        public string ProfessionalSkills { get { return professionalSkills; } set { professionalSkills = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string GoalAtWork { get { return goalsatwork; } set { goalsatwork = value; } }
        public int IdCv {  get { return idCv; } set { idCv = value; } }
    }
}
