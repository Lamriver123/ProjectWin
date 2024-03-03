using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class Person
    {
        private string iD, name, email, phoneNumber, password;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
        public Person(string iDValue, string nameValue, string emailValue, string phoneNumberValue, string pass) 
        {
            ID = iDValue;
            Name = nameValue;
            Email = emailValue;
            PhoneNumber = phoneNumberValue;
            Password = pass;
        }
    }
}
