using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    enum ProgrammerPosition
    {
        Junior,
        Middle,
        Senior
    }
    class Employee
    {
        private string name;
        private string secondName;
        private ProgrammerPosition position;
        private int experience;

        public string Name { get { return this.name; } }
        public string SecondName { get { return this.secondName; } }
        public ProgrammerPosition Position { get { return this.position; } }
        public int Experience { get { return this.experience; } }
        public Employee(string Name, string SecondName, ProgrammerPosition Position, int Experience)
        {
            this.name = Name;
            this.secondName = SecondName;
            this.position = Position;
            this.experience = Experience;
        }
        public double CalculatePayment()
        {
            double payment = 0;
            switch(this.Position)
            {
                case ProgrammerPosition.Junior: payment = 500 + 50 * this.experience;
                    break;
                case ProgrammerPosition.Middle: payment = 1500 + 100 * this.experience;
                    break;
                case ProgrammerPosition.Senior: payment = 2500 + 200 * this.experience;
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
