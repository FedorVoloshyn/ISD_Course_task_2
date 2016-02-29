using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class User
    {
        private readonly DateTime fillDate;
        public DateTime FillDate { get { return fillDate; } }

        private string login;
        public string Login { get { return login; } }

        private string name;
        public string Name { get { return name; } }

        private string secondName;
        public string SecondName { get { return secondName; } }

        private string password;
        public string Password { get { return password; } }

        private int age;
        public int Age { get { return age; } }
        public User(DateTime CurrentDayTime, string Login, string Name, string SecondName, string Password, int Age)
        {
            fillDate = CurrentDayTime;
            this.login = Login;
            this.name = Name;
            this.secondName = SecondName;
            this.password = Password;
            this.age = Age;
        }
    }
}
