using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Rectagle
    {
        private double size1;
        private double size2;
        public double Area { get { return AreaCalculator(); } }
        public double Perimetr { get { return PerimeterCalculator(); } }
        public Rectagle(double size1, double size2)
        {
            this.size1 = size1;
            this.size2 = size2;
        }

        private double AreaCalculator()
        {
            return this.size1 * this.size2;
        }

        private double PerimeterCalculator()
        {
            return 2.0 * (this.size1 + this.size2);
        }
    }
}
