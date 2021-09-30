using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int theVoid;
            double heatDeath;
            int theAnswer;
            DateTime today = DateTime.Today;


            // What happens when you divide by zero? Not much
            Console.WriteLine("Which number can you divide by zero?");
            theAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another??");
            theVoid = Convert.ToInt32(Console.ReadLine());
            heatDeath = theAnswer / theVoid;
            Console.WriteLine("Updated Today {0}", today);
            Console.WriteLine("You can't D/0 {0} by {1}, because the answer would be {2}", theAnswer, theVoid, heatDeath);

        }
    }
}
