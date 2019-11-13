using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes variables
            string color;
            string wordEst;
            string bodyPartPlural;
            string anAnimal;
            string noun;
            string nounPlural;
            int a;
            int b;
            int c;

            //Asks for color, waits for response
            Console.WriteLine("What is your favorite color >>> ");
            color = Console.ReadLine();

            //Asks for -est word, waits for response
            Console.WriteLine("Enter a word ending in -est >>> ");
            wordEst = Console.ReadLine();

            //Asks for plural body part, waits for response
            Console.WriteLine("Enter a plural body part >>> ");
            bodyPartPlural = Console.ReadLine();

            //Asks for animal, waits for response
            Console.WriteLine("Enter your favorite type of animal >>> ");
            anAnimal = Console.ReadLine();

            Console.WriteLine("Enter a singular noun >>> ");
            noun = Console.ReadLine();
            Console.WriteLine("Enter a plural noun >>> ");
            nounPlural = Console.ReadLine();

            //Asks for two numbers, waits for response
            Console.WriteLine("Enter a number >>> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another, smaller number >>> ");
            b = Convert.ToInt32(Console.ReadLine());

            //Subtracts b from a in order to get c
            c = a - b;

            //Writes out story
            Console.WriteLine("The {0} Dragon is the " +
            "{1} Dragon of all. It managed to cause {2} {3} to burst within a month " + 
            "as well as the farmer's favorite {4}. " + 
            "It completely destroyed the {5}, in addition to the king's {6}." +
            "It was completely unstoppable. There was no hope."
            , color, wordEst, c, bodyPartPlural, anAnimal, noun, nounPlural);
            
        }
    }
}
