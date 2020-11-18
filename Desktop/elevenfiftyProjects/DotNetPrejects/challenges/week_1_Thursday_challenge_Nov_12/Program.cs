using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace week_1_Thursday_challenge_Nov_12
{
    class Program
    {
        static void Main(string[] args) { }
    }
     
    [TestClass]
   public class week1

    {
        [TestMethod]
        
        public void superchal()

      {
        string name = "supercalifragilisticexpialidocious";
        foreach (char letter in name)
        {
            Console.WriteLine(letter);
        }

      }


    [TestMethod]
    public void IfiChal()
    {
        string name = "supercalifragilisticexpialidocious";
        foreach (char letter in name) 
            if (letter == 'i')
        {
           
            Console.WriteLine('i');
        }

        else
            {
                Console.WriteLine( "Not an i");
            }

        
        
            
        
    }

    }

}
