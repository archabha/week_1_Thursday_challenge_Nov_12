using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2challenges
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.DayTimeGreeting();
            greeter.TimeGreeting();
            greeter.Greeting("Ben");
            greeter.Hello();
            greeter.Farwell("Ben");

            Console.ReadLine();
        }
    }
}
