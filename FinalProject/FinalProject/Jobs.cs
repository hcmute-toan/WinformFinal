using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Jobs
    {
        private int id;
        private int companyId;
        private string positionNeeded;
        private string companyName;
        private string salary;
        private string nameJob;
        private string address;
        private string postingTime;
        private string contact;
        private string numberOfRecruit;
        private string describeJob;
        private int numberCandidate;
        //mo ta cong viec, mo ta cong ty, mo ta dai ngo, ....de sau lam
        public Jobs() 
        { }
        public string Contact { get { return contact; } set { contact = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int CompanyId { get { return companyId; } set { companyId = value; } }
        public string NameJob { get { return nameJob; } set { nameJob = value; } }
        public string PositionNeeded { get { return positionNeeded; } set { positionNeeded = value; } }
        public string CompanyName { get { return companyName; } set { companyName = value; } }
        public string Salary { get { return salary; } set { salary = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string PostingTime { get { return postingTime; } set { postingTime = value; } }
        public string NumberOfRecruit { get { return numberOfRecruit; } set { numberOfRecruit = value; } }
        public string DescribeJob { get { return describeJob; } set { describeJob = value; } }
        public int NumberCandidate { get { return numberCandidate; } set { numberCandidate = value; } }
    }
}
