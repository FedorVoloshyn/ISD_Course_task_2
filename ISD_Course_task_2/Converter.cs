using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double UahToUsd(double uah)
        {
            return uah / usd;
        }
        public double UahToEur(double uah)
        {
            return uah / eur;
        }
        public double UahToRub(double uah)
        {
            return uah / rub;
        }
        public double UsdToUah(double usd)
        {
            return this.usd * usd;
        }
        public double EurToUah(double eur)
        {
            return this.eur * eur;
        }
        public double RubToUah(double rub)
        {
            return this.rub * rub;
        }
    }
}
