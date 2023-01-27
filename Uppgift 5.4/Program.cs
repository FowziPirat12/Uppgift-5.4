using System;
namespace Uppgift_5._4
{
    class program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[] { "Alem", "Adam", "Messi", "Ronaldo", "maradona" };
            Array.Sort(namn);
            Console.WriteLine(namn[0]);
        }
    }
}