using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWord_Manager
{
    public class Records
    {
        string address;
        string mail;
        string encpass;

        public Records(string address, string mail, string encpass)
        {
            this.address = address;
            this.mail = mail;
            this.encpass = encpass;
        }

        public Records()
        {

        }

        public Records(string address, string mail)
        {
            this.address = address;
            this.mail = mail;
        }

        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Encpass { get => encpass; set => encpass = value; }

        
    }
}
