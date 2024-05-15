using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class JobApplication
    {
        private int _id;
        private int idJob;
        private int idCompany;
        private int idUser;
        private int _Status;
        private int idCv;

        public JobApplication()
        { }
        public int Id { get { return _id; } set { _id = value; } }
        public int IdJob { get { return idJob; } set { idJob = value; } }
        public int IdCompany { get { return idCompany; } set { idCompany = value; } }
        public int IdUser { get { return idUser; } set { idUser = value; } }
        public int Status { get { return _Status; } set { _Status = value; } }
        public int IdCv { get { return idCv; } set { idCv = value; } }
    }
}
