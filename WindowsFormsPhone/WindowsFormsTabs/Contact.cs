using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTabs
{
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mobile { get; set; }
        public string Home { get; set; }

        public Contact() { }

        public Contact(string name, string surname, string mobile, string home)
        {
            this.Name = name;
            this.Surname = surname;
            this.Mobile = mobile;
            this.Home = home;
        }
    }
}
