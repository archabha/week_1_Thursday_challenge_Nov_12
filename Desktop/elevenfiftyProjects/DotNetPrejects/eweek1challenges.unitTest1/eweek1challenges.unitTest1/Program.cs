using System;

namespace eweek1challenges.unitTest1
{
   [TestClass]
}
public class UnitTest1
{
    [TestMethod]
    public void NameAndAge()
    {
        string firstName = "Chabha";
        string lastName = "Arkoub";
        int age = 36;
        Console.WriteLine(age + 7);
        Console.WriteLine(age - 7);
        Console.WriteLine(age * 7);
        Console.WriteLine(age / 7);
        Console.WriteLine(age % 7);
    }
    [TestMethod]
    public void Array()
    {
        string[] movie = { "The New Mutants", "Last Three Days", "Alone", "Fatman" };
    }
    [TestMethod]
    public void CreatingAListOfDates()
    {
        Liste<DateTime> ListeOfDates = new Liste<DateTime>();
        DateTime today = DateTime.Today;
        ListeOfDates.Add(today);
        ListeOfDates.Add(new DateTime(2020, 08, 29));
        ListeOfDates.Add(new DateTime(2020, 03, 19));
        ListeOfDates.Add(new DateTime(2020, 01, 08));
    }
    [TestMethod]
    public void HowMuchSleepDidYouGet()
    {
        console.Writeline("How many hours of sleep did you get????");
        int hours = 4;
        if(hours >= 10)
        {
            Console.WriteLine("wow, that's a lot of sleep");
        }
        else if(hours >=8 && hours < 10)
        {
            Console.WriteLine("you should be well rested");
        }
        else if (hours > 4 && hours < 8)
        {
            Console.WriteLine("Bummer");
        }
        else
        {
            Console.WriteLine("oh man get some sleep");
        }
    }
    [TestMethod]
    public void HowHasYourDayBeen()
    {
        string userDay -"okay";
        switch(userDay)
        {
            case "Great":
                Console.WriteLine("Glad you are having a great day");
                break;
            case "Good":
                Console.WriteLine("it is a day to be good on");
                break;
            case " okay":
                Console.WriteLine("Hoppfully it will get better from here");
                break;
            case " Bad":
                Console.WriteLine("There is always tomorrow");
                break;
            case ":(":
                Console.WriteLine("I guess this is us now");
                break;
            default:
                Console.WriteLine("Please enter something above");
                break;
        }
    }
    [TestMethod]
    public void supercalifragilisticexpialidocious()
    {
        string name = "supercalifragilisticexpialidocious";
        foreach (char letter in name)
        {
            if (letter == 'i')
            {

                Console.WriteLine(letter);
            }

            else
            {
                Console.WriteLine("Not an i");
            }
        }
    }





}
