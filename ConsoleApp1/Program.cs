using System;

namespace Deliverable;
class MainClass
{
    public static void Main(string[] args)
    {
        string Yes;
        do
        {
            Console.WriteLine();

            Console.WriteLine("How many people are we making PB & J Sandwhiches for? ");

            Console.WriteLine();

            int people = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("You need: ");

            Console.WriteLine();

            decimal slicesofbread = 2 * people;

            decimal tablesspoonsofpeanutbutter = 2 * people;

            decimal teasspoonsofjelly = 4 * people;

            Console.WriteLine(slicesofbread + " slices of bread ");

            Console.WriteLine();

            Console.WriteLine(tablesspoonsofpeanutbutter + " tablespoons of peanut butter ");

            Console.WriteLine();

            Console.WriteLine(teasspoonsofjelly + " teaspoons of jelly ");

            Console.WriteLine();

            Console.WriteLine(" Which is... ");

            Console.WriteLine();

            decimal loavessneed = Math.Round(slicesofbread / 28, MidpointRounding.AwayFromZero) + 1;

            decimal pbjarsneeded = Math.Round(tablesspoonsofpeanutbutter / 32, MidpointRounding.AwayFromZero) + 1;

            decimal jellyjarsneeded = Math.Round(teasspoonsofjelly / 48, MidpointRounding.AwayFromZero) + 1;

            if (slicesofbread >= 2 && slicesofbread <= 28)
            {
                Console.WriteLine("1 loaf of bread");
            }
            else
            {
                Console.WriteLine(loavessneed + " loaves of bread");
            }

            if (tablesspoonsofpeanutbutter >= 2 && tablesspoonsofpeanutbutter <= 32)
            {
                Console.WriteLine("1 Jar of Peanut Butter");
            }
            else
            {
                Console.WriteLine(pbjarsneeded + " Jars of Peanut Butter");
            }

            if (teasspoonsofjelly >= 4 && teasspoonsofjelly <= 48)
            {
                Console.WriteLine("1 Jar of Jelly");
            }
            else
            {
                Console.WriteLine(pbjarsneeded + " Jars of Jelly");
            }
            Console.WriteLine();

            Console.WriteLine("Would you like to restart? Enter Yes or Y to continue, or enter any other key to exit. ");

            Console.WriteLine();

            Yes = Console.ReadLine();    
        }
        while (Yes == "Y" || Yes == "Yes");

        Console.WriteLine();

        Console.WriteLine("Goodbye");
        
    }
}