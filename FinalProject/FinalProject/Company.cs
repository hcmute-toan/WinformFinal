using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Company
    {

        private int id;
        private string name;
        private string gmail;
        private string phone;
        private string field;
        private string address;
        private string companySize;
        private string descibe;
        private byte[] logo;
        private byte[] coverimage;
        private string idEmployer;
        private int numberOfJobs;
        public Company() { }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Gmail { get { return gmail; } set { gmail = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Field { get { return field; } set { field = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string CompanySize { get { return companySize; } set { companySize = value; } }
        public string Descibe { get { return descibe; } set { descibe = value; } }
        public byte[] Logo { get { return logo; } set { logo = value; } }
        public byte[] Coverimage { get { return coverimage; } set { coverimage = value; } }
        public string IdEmployer { get { return idEmployer; } set { idEmployer = value; } }
        public int NumberOfJobs {  get { return numberOfJobs; }    set { numberOfJobs = value; } }
    }
}
