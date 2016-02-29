using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Employee
    {
        private string name;
        private string secondName;
        private string position;
        private int experience;

        public string Name { get { return this.name; } }
        public string SecondName { get { return this.secondName; } }
        public string Position { get { return this.position; } }
        public int Experience { get { return this.experience; } }
        public Employee(string Name, string SecondName, string Position, int Experience)
        {
            this.name = Name;
            this.secondName = SecondName;
            this.position = Position.ToLower();
            this.experience = Experience;
        }
        public double CalculatePayment()
        {
            double payment = 0;
            switch(this.Position)
            {
                case "jun": payment = 500 + 50 * this.experience;
                    break;
                case "mid": payment = 1500 + 100 * this.experience;
                    break;
                case "sin": payment = 2500 + 200 * this.experience;
                    break;
                default: payment = -1.0;
                    break;
            }
            return payment;
        }

        public double CalculateTax()
        {
            return CalculatePayment() * 0.1;
        }
    }
}
