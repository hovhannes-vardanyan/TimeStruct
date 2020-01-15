using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(new DateTime(year: 2020, month: 1, day: 25, hour: 10, minute: 35, second: 50));
            Time t2 = new Time(new DateTime(year: 2020, month: 1, day: 25, hour: 8, minute: 45, second: 50));

            Console.WriteLine($"TimeOne {t1}");
            Console.WriteLine($"TimeTwo {t2}");
            Console.WriteLine("Operatiors");
            Time t3 = t1 + t2;
            Console.WriteLine($"TimeOne + TimeTwo {t3}");
            Time t4 = t1 - t2;
            Console.WriteLine($"TimeOne - TimeTwo {t4}");

            Console.WriteLine("Casting");
            //implicit  int -> Time
            int temp = 55556546;
            Time t5 = temp;
            Console.WriteLine(t5);
            // explicit Time -> int
            int a = (int)t5;
            Console.WriteLine(a);


            
            Console.ReadKey();
        }
    }
}
