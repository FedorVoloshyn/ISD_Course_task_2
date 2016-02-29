using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article; 
        private int quantity;        
        public string Provider { get { return provider; } } 
        public string Customer { get { return customer; } }
        public int Account { get { return account; } }
        public string Article { get { return this.article; } set { this.article = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }

        public Invoice(int Account, string Customer, string Provider)
        {
            this.account = Account;
            this.customer = Customer;
            this.provider = Provider;
            this.article = "";
            this.quantity = 0;
        }
        public double CalculateSumm()
        {
            if (quantity > 0)
            {
                int summ = 0;
                string currentArticle = this.article.ToLower();
                switch (currentArticle)
                {
                    case "banana": summ = 10;
                        break;
                    case "apple": summ = 5;
                        break;
                    case "peanapple": summ = 12;
                        break;
                    default: summ = 0;
                        break;
                }
                return summ * this.quantity;
            }
            else
                return -1;
        }
        public double CalculateSummWithNDS()
        {
            return Convert.ToDouble(CalculateSumm()) * 1.2;
        }
    }
}
