using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Recruitment
    {
        private int id; // id user
        private string name;
        private string gender;
        private string address;

        private string dateOfBirth;
        private string jobApplication;
        private string workExperience;
        private string educationAndCertifications;
        private string professionalSkills;
        private string goalsatwork;
        private byte[] picture;
        public Recruitment() { }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string JobApplication { get { return jobApplication; } set { jobApplication = value; } }
        public string WorkExperience { get { return workExperience; } set { workExperience = value; } }
        public string EducationAndCertifications { get { return educationAndCertifications; } set { educationAndCertifications = value; } }
        public string ProfessionalSkills { get { return professionalSkills; } set { professionalSkills = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string GoalAtWork { get { return goalsatwork; } set { goalsatwork = value; } }
        public byte[] Picture { get { return picture; } set { picture = value; } }
    }
}