using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Address
    {
        public int index { set; get; }
        public string country { set; get; }
        public string city { set; get; }
        public string street { set; get; }
        public int house { set; get; }
        public int apartament { set; get; }

        public Address(int index, string country, string city, string street, int house, int apartament)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartament = apartament;
        }
    }
}
