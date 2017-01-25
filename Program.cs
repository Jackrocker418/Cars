using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_practice
{
   
    class Program
    {
        public string YN = "n";

        static void Main(string[] args)
        {
            var car = new Car();
            car.Year = 1945;
            car.Color = "Yellow";
            car.Engine = "One litre";
            var carTwo = Car.Parse("green", 5491, "Two Litre");
            var toyota = new Toyota(55000, 5, "Excellent", 555);
            var toyotaTwo = new Toyota();
            toyota.Color = "Red";
            toyota.Engine = "Three Litre";
            toyota.Year = 2010;
            var avalon = new Avalon("Purple", 2020, true);
            var myCar = new Avalon("White", 3030, false);
            Console.WriteLine("Dump to memory?");
            string YN = Console.ReadLine();
            if (YN == "N" || YN =="n" || YN == "no" || YN == "No" || YN == "NO")
            {
                Console.ReadKey();
            } else if ( YN == "Y" || YN == "y" || YN == "yes" || YN == "Yes" || YN == "YES")
            {
                DumpToMemory();
            }
            Console.ReadKey();

        }

        public static void DumpToMemory()
        {
            var sw = new StreamWriter(@"C:\Users\A-A-Ron\Documents\Jack\udemy practice\Records.txt");
            foreach(Car cr in )
            {

            }
        }
    }
}
