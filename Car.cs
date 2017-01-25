using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_practice
{
    class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }

        public Car()
        {
            Console.WriteLine("There are no paramaters yet");
        }

        public static Car Parse(string cr)
        {
            var car = new Car();
            car.Color = cr;

            return car;
        }

        public static Car Parse(string cr, int yr)
        {
            Car car = new Car();
            car.Color = cr;
            car.Year = yr;

            return car;
        }

        public static Car Parse(string cr, int yr, string en)
        {
            var car = new Car();
            car.Color = cr;
            car.Year = yr;
            car.Engine = en;

            return car;
        }

    }

    class Toyota : Car
    {
        public int Miles { get; set; }
        public int NumberOfOwners { get; set; }
        public string Condition { get; set; }
        public int LastOilChange { get; set; }

        public Toyota()
        {
        }

        public Toyota(int mi)
        {
            Miles = mi;
        }

        public Toyota(int mi, int now)
        {
            Miles = mi;
            NumberOfOwners = now;
        }

        public Toyota(int mi, int now, string co)
        {
            Miles = mi;
            NumberOfOwners = now;
            Condition = co;
        }

        public Toyota(int mi, int now, string co, int loc)
        {
            Miles = mi;
            NumberOfOwners = now;
            Condition = co;
            LastOilChange = loc;
        }

    }

    class Avalon : Toyota
    {
        public Avalon(string cr, int yr, bool newc)
        {
            Color = cr;
            Year = yr;
            Engine = "Six litre";
            if (newc == true)
            {
                Miles = 0;
                NumberOfOwners = 0;
                LastOilChange = 0;
                Condition = "New";
            } else if(newc == false)
            {
                this.Used();
            }
           
        }

        public void Used()
        {
            Console.WriteLine("How many miles?");
            Miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many previous owners?");
            NumberOfOwners = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many miles since the last oil change?");
            LastOilChange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is it's current condition?");
            Condition = Console.ReadLine();

        }
    }

}
