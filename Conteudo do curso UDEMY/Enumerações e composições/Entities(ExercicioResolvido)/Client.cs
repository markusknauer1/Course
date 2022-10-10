using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }


        public Client()
        {

        }

        public Client(string name, string mail, DateTime birthDate)
        {
            Name = name;
            Mail = mail;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Mail;
        }
    }
}
