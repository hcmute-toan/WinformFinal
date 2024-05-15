using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class ReadSQL
    {
        public static List<Jobs> Jobs()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Jobs", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<Jobs> jobs = new List<Jobs>();
                while (reader.Read())
                {
                    Jobs job = new Jobs();
                    job.Id = (int)reader["Id"];
                    job.CompanyId = (int)reader["CompanyId"];
                    job.NameJob = (string)reader["NameJob"];
                    job.PositionNeeded = (string)reader["PositionNeeded"];
                    job.CompanyName = (string)reader["CompanyName"];
                    job.Salary = (string)reader["Salary"];
                    job.Address = (string)reader["Address"];
                    job.PostingTime = (string)reader["PostingTime"];
                    job.NumberOfRecruit = (string)reader["NumberOfRecruit"];
                    job.Contact = (string)reader["Contact"];
                    job.DescribeJob= (string)reader["DescribeJob"];
                    //job.NumberCandidate = (int)reader["NumberCandidate"];
                    jobs.Add(job);
                }
                reader.Close();
                connection.Close();
                return jobs;
            }
        }
        public static List<UserAccount> Accounts()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Candidates", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<UserAccount> accounts = new List<UserAccount>();
                while (reader.Read())
                {
                    UserAccount account = new UserAccount();
                    account.Id = (int)reader["Id"];
                    account.Gmail = (string)reader["Gmail"];
                    account.UserName = (string)reader["Name"];
                    account.Password = (string)reader["Password"];
                    account.Picture = (byte[])reader["Picture"];

                    accounts.Add(account);
                }
                reader.Close();
                connection.Close();
                return accounts;
            }
        }

        public static List<Employers> Company()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Employers", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Employers> accounts = new List<Employers>();
                while (reader.Read())
                {
                    Employers account = new Employers();
                    account.Id = (int)reader["Id"];
                    account.Gmail = (string)reader["Gmail"];
                    account.UserName = (string)reader["Name"];
                    account.Password = (string)reader["Password"];
                    account.Picture = (byte[])reader["Picture"];

                    accounts.Add(account);
                }
                reader.Close();
                connection.Close();
                return accounts;
            }
        }
        public static List<Company> ListCompany()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Company", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Company> companies = new List<Company>();
                while (reader.Read())
                {
                    Company company = new Company();
                    company.Id = (int)reader["Id"];
                    company.Gmail = (string)reader["Gmail"];
                    company.Address = (string)reader["Address"];
                    company.Descibe = (string)reader["Descibe"];
                    company.Phone = (string)reader["Phone"];
                    company.Logo = (byte[])reader["logo"];
                    company.CompanySize = (string)reader["CompanySize"];
                    company.Field = (string)reader["Field"];
                    company.Name = (string)reader["Name"];  
                    company.Coverimage = (byte[])reader["coverimage"];
                    company.IdEmployer = (string)reader["IdEmployer"];
                    company.NumberOfJobs = (int)reader["NumberJobs"];
                    companies.Add(company);
                }
                reader.Close();
                connection.Close();
                return companies;
            }
        }
        public static List<JobApplication> Jobapplication()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM JobApplication", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<JobApplication> jobApplications = new List<JobApplication>();
                while (reader.Read())
                {
                    JobApplication jobApplication = new JobApplication();
                    jobApplication.Id = (int)reader["Id"];
                    jobApplication.IdCompany = (int)reader["CompanyId"];
                    jobApplication.IdJob = (int)reader["JobId"];
                    jobApplication.IdUser = (int)reader["UserId"];
                    jobApplication.IdCv = (int)reader["IdCv"];
                    jobApplication.Status = (int)reader["Status"];

                    jobApplications.Add(jobApplication);
                }
                reader.Close();
                connection.Close();
                return jobApplications;
            }
        }
        public static List<CV> Cvs()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM CVs", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<CV> cvs = new List<CV>();
                while (reader.Read())
                {
                    CV cv = new CV();
                    cv.Id = (int)reader["UserId"];
                    cv.IdCv = (int)reader["Id"];
                    cv.Name = (string)reader["Name"];
                    cv.DateOfBirth = (string)reader["DateOfBirth"];
                    cv.WorkExperience = (string)reader["WorkExperience"];
                    cv.EducationAndCertifications = (string)reader["EducationAndCertifications"];
                    cv.ProfessionalSkills = (string)reader["ProfessionalSkills"];
                    cv.Gender = (string)reader["Gender"];
                    cv.Address = (string)reader["Address"];
                    cv.GoalAtWork = (string)reader["GoalsAtWork"];
                    cvs.Add(cv);
                }
                reader.Close();
                connection.Close();
                return cvs;
            }
        }

        public static List<JobLove> jobLoves()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM JobLove", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<JobLove> jobLoves = new List<JobLove>();
                while (reader.Read())
                {
                    JobLove jobLove = new JobLove();
                    jobLove.Id = (int)reader["id"];
                    jobLove.IdCompany = (int)reader["IdCompany"];
                    jobLove.IdJob = (int)reader["IdJob"];
                    jobLove.IdUser = (int)reader["IdUser"];

                    jobLoves.Add(jobLove);
                }
                reader.Close();
                connection.Close();
                return jobLoves;
            }
        }
        public static List<Notice1> Notices1()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Notice1", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Notice1> notices = new List<Notice1>();
                while (reader.Read())
                {
                    Notice1 notice = new Notice1();
                    notice.Id = (int)reader["Id"];
                    notice.IdLogin = (int)reader["IdLogin"];
                    notice.TypeLogin = (string)reader["TypeLogin"];
                    notice.IdSender = (int)reader["IdSender"];
                    notice.IdReceiver = (int)reader["IdReceiver"];
                    notice.IdJob = (int)reader["IdJob"];
                    notice.Type = (string)reader["Type"];
                    notice.TimeNotice = (DateTime)reader["TimeNotice"];
                    notice.StatusCV = (int)reader["StatusCV"];
                    notice.Mess = (string)reader["Mess"];
                    notices.Add(notice);
                }
                reader.Close();
                connection.Close();
                var sortedNotices = notices.OrderByDescending(c => c.TimeNotice).ToList();
                return sortedNotices;
            }
        }
        public static List<Notice1> Messages1()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Notice1", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Notice1> notices = new List<Notice1>();
                while (reader.Read())
                {
                    Notice1 notice = new Notice1();
                    notice.Id = (int)reader["Id"];
                    notice.IdLogin = (int)reader["IdLogin"];
                    notice.TypeLogin = (string)reader["TypeLogin"];
                    notice.IdSender = (int)reader["IdSender"];
                    notice.IdReceiver = (int)reader["IdReceiver"];
                    notice.IdJob = (int)reader["IdJob"];
                    notice.Type = (string)reader["Type"];
                    notice.TimeNotice = (DateTime)reader["TimeNotice"];
                    notice.StatusCV = (int)reader["StatusCV"];
                    notice.Mess = (string)reader["Mess"];
                    notices.Add(notice);
                }
                reader.Close();
                connection.Close();
                var sortedNotices = notices.OrderBy(c => c.TimeNotice).ToList();
                return sortedNotices;
            }
        }
        public static List<Recruitment> Recruitments()
        {
            string connectionString = "Data Source=TonyNyan\\TONYNYAN;Initial Catalog=ManagerJobs;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Recruitment", connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Recruitment> recruitments = new List<Recruitment>();
                while (reader.Read())
                {
                    Recruitment recruitment = new Recruitment();
                    recruitment.Id = (int)reader["UserId"];
                    recruitment.Name = (string)reader["Name"];
                    recruitment.DateOfBirth = (string)reader["DateOfBirth"];
                    recruitment.JobApplication = (string)reader["JobApplication"];
                    recruitment.WorkExperience = (string)reader["WorkExperience"];
                    recruitment.EducationAndCertifications = (string)reader["EducationAndCertifications"];
                    recruitment.ProfessionalSkills = (string)reader["ProfessionalSkills"];
                    recruitment.Gender = (string)reader["Gender"];
                    recruitment.Address = (string)reader["Address"];
                    recruitment.GoalAtWork = (string)reader["GoalsAtWork"];
                    recruitments.Add(recruitment);
                    recruitment.Picture = (byte[])reader["Picture"];
                }
                reader.Close();
                connection.Close();
                return recruitments;
            }
        }
    }
}
