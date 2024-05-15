using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Employers
    {
        private int id;
        private string userName;
        private string password;
        private string gmail;
        private byte[] picture;
        public Employers() { }
        public string UserName { get { return userName; } set { userName = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Gmail { get { return gmail; } set { gmail = value; } }

        public byte[] Picture { get { return picture; } set { picture = value; } }
    }
}
