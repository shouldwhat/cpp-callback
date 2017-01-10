using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCallback
{
    public class AddUserEventArgs
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string phone { get; set; }

        public AddUserEventArgs(string name, string sex, string age, string phone)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.phone = phone;
        }
    }
}
