//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;

//namespace FinalProject
//{
//    public class JobsDAO
//    {
//        public JobsDAO() { }
//        DBConnection dbconection = new DBConnection();
//        public DataTable Load(string name)
//        {
//            return dbconection.Load("Jobs");
//        }
//        public void Them(Jobs job)
//        {
//            string SQL = string.Format("INSERT INTO Jobs (NameJob,PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", job.NameJob, job.PositionNeeded, job.CompanyName, job.Salary, job.Address, job.PostingTime, job.NumberOfRecruit);
//            dbconection.Excude(SQL);
//        }
//        public void Sua(Jobs job)
//        {
//            string SQL = string.Format("UPDATE Jobs SET PositionNeeded = '{0}',Salary='{1}', Address = '{2}' , PostingTime = '{3}', NumberOfRecruit = '{4}' WHERE NameJob = '{5}' AND CompanyName ='{6}'", job.PositionNeeded, job.Salary, job.Address, job.PostingTime, job.NumberOfRecruit, job.NameJob, job.CompanyName);
//            dbconection.Excude(SQL);
//        }
//        public void Xoa(Jobs job)
//        {
//            string SQL = string.Format("DELETE FROM Jobs WHERE NameJob = '{0}' AND CompanyName ='{1}'", job.NameJob, job.CompanyName);
//            dbconection.Excude(SQL);
//        }
//    }
//}
