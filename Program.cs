using System;

namespace DontForgetToStoreIt08172020
{
    class Program
    {
        static void Main(String[] args)
        {
            int meaningOfLifeAndEverything = 42;
            double pi = 3.14159;
            String cheese, color;

            Console.WriteLine("Give me pi to at least 5 decimals: ");
            pi = Convert.ToDouble(Console.ReadLine());

            // We've got Convert.ToDouble down but meaningOfLifeAndEverything is an INT
            // So we'll have to use Convert.ToInt32
            Console.WriteLine("What is the meaning of life, the universe, and everything? ");
            meaningOfLifeAndEverything = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite kind of cheese? ");
            cheese = Console.ReadLine();

            Console.WriteLine("Do you like the color Red or Blue more? ");
            color = Console.ReadLine();

            //Console.WriteLine("Ooh, " + color + " " + cheese +" sounds delicious!");
            //Console.WriteLine("The circumference of life is " +( 2 * pi * meaningOfeLifeAndEverything));
        }
    }
}