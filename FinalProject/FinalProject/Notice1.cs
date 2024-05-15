using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Notice1
    {
        public Notice1() { }
        private int id;
        private int idLogin;
        private string typeLogin;
        private int idSender;
        private int idReceiver;
        private int idJob;
        private string type;
        private DateTime timeNotice;
        private int statusCV;
        private string mess;
        public int Id { get { return id; } set { id = value; } }
        public int IdLogin { get { return idLogin; } set { idLogin = value; } }
        public string Type { get { return type; } set { type = value; } }
        public DateTime TimeNotice { get { return timeNotice; } set { timeNotice = value; } }
        public int StatusCV { get { return statusCV; } set { statusCV = value; } }
        public string TypeLogin { get { return typeLogin; } set { typeLogin = value; } }
        public int IdSender { get { return idSender; } set { idSender = value; } }
        public int IdReceiver { get { return idReceiver; } set { idReceiver = value; } }
        public int IdJob { get { return idJob; } set { idJob = value; } }
        public string Mess { get { return mess; } set { mess = value; } }
    }
}
