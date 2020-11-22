using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2challenges
{ 
        public class Greeter
    {
        public string Greeting(string name)
        {
            string greeting = $"Hello{name}";
            return greeting;
        }

        internal void DayTimeGreeting()
        {
            throw new NotImplementedException();
        }

        internal void TimeGreeting()
        {
            throw new NotImplementedException();
        }

        public void Hello()
        {
            string inputName = Greeting("Josh");
            Console.WriteLine(inputName);
        }
        public string Farwell(string name)
        {
            string farwell = $"It was nice to meet you {name}";
            return farwell;
        }

        public void Goodby()
        {
            string inputName = Farwell("Josh");
            Console.WriteLine(inputName);
        }
    }
}
