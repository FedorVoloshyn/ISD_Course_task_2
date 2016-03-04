using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while (chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Task 2. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("Enter number of exercise or '0' to exit: ");
                chosen_exersise = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: ExerciseOne();
                        break;
                    case 2: ExerciseTwo();
                        break;
                    case 3: ExerciseThree();
                        break;
                    case 4: ExerciseFour();
                        break;
                    case 5: ExerciseFive();
                        break;
                    case 6: ExerciseSix();
                        break;
                    case 7: ExerciseSeven();
                        break;
                    case 8: ExerciseEight();
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void ExerciseOne()
        {
            Address MyHomeAdress = new Address(49066, "Ukraine", "Dnipropetrovsk", "Kislovodska", 33, 2);
            Console.WriteLine("My home adress is: ");
            Console.WriteLine(MyHomeAdress.index);
            Console.WriteLine(MyHomeAdress.country);
            Console.WriteLine(MyHomeAdress.city);
            Console.WriteLine("{0} {1}/{2}", MyHomeAdress.street, MyHomeAdress.house, MyHomeAdress.apartament);
        }
        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter size 1: ");
            double size1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter size 2: ");
            double size2 = double.Parse(Console.ReadLine());
            Rectagle MyRect = new Rectagle(size1, size2);
            Console.WriteLine("Currnet rectangle`s area = {0}", MyRect.Area);
            Console.WriteLine("Currnet rectangle`s perimetr = {0}", MyRect.Perimetr);
        }
        public static void ExerciseThree()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter content: ");
            string content = Console.ReadLine();
            Book ThisIsBook = new Book(title, author, content);
            ThisIsBook.Show();
        }
        public static void ExerciseFour()
        {
            Figure Square = new Figure(new Point(1, 1, "A"), new Point(1, -1, "B"), new Point(-1, 1, "C"), new Point(-1, -1, "D"));
            Console.WriteLine("Figure {0}.", Square.GetName());
            Square.PerimeterCalculator();
        }
        public static void ExerciseFive()
        {
            User Me = new User(DateTime.Now, "G-Gurda", "Nikita", "Gigurda", "MyPassword", 50);
            Console.WriteLine("Create date/time: {0}", Me.FillDate.ToString());
            Console.WriteLine("Login/Password: {0} {1}", Me.Login, Me.Password);
            Console.WriteLine("Name: {0} {1}", Me.Name, Me.SecondName);
            Console.WriteLine("Age: {0}", Me.Age);
        }
        public static void ExerciseSix()
        {
            Converter convert = new Converter(8, 10, 0.25);
            int summ;
            Console.WriteLine("Choose option: ");
            Console.WriteLine("1. UAH -> Currency.");
            Console.WriteLine("2. Currency -> UAH.");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1: Console.WriteLine("Enter summ: ");
                    summ = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} UAH = {1} USD", summ, convert.UahToUsd(summ));
                    Console.WriteLine("{0} UAH = {1} EUR", summ, convert.UahToEur(summ));
                    Console.WriteLine("{0} UAH = {1} RUB", summ, convert.UahToRub(summ));
                    break;
                case 2: Console.WriteLine("Enter summ: ");
                    summ = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} USD = {1} UAH", summ, convert.UsdToUah(summ));
                    Console.WriteLine("{0} EUR = {1} UAH", summ, convert.EurToUah(summ));
                    Console.WriteLine("{0} RUB = {1} UAH", summ, convert.RubToUah(summ));
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
        }
        public static void ExerciseSeven()
        {
            Employee Fedya = new Employee("Fedor", "Voloshyn", ProgrammerPosition.Junior, 0);
            Console.WriteLine("{0} {1}, {2}-developer.", Fedya.Name, Fedya.SecondName, Fedya.Position);
            Console.WriteLine("Payment: ${0}\nTax: ${1}", Fedya.CalculatePayment(), Fedya.CalculateTax());
        }
        public static void ExerciseEight()
        {
            Invoice buy = new Invoice(1488, "Fedya", "Petya");
            buy.Article = "Apple";
            buy.Quantity = 10;
            Console.WriteLine("----Invoice----");
            Console.WriteLine("{0} x {1} = {2} ({3} with NDS)", buy.Article, buy.Quantity, buy.CalculateSumm(), buy.CalculateSummWithNDS());
            Console.WriteLine("Customer: {0}\nProvider: {1}", buy.Customer, buy.Provider);
        }
    }
}
