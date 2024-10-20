using static System.Formats.Asn1.AsnWriter;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What design pattern is being shown. -- Strategy design pattern
            //What type(behavioral, creational, structural) the design pattern fits in. -- behavioral design pattern
            //Examples of why it might be needed(for example, the Singleton pattern stops an object from being instantiated multiple times or the
                //Observer pattern is used to change messaging to a push model instead of a poll model). -- As displayed below, this is useful
                //when the user has options for how the results are displayed
            //A Link to the UML diagram you used or an example of the UML. -- https://refactoring.guru/design-patterns/strategy I used refactoring
                //guru to search over the options of design patterns, but in all honesty your description after class made way more sense than any
                //of the diagrams and is what I based my structure off of.
            //Your code example(does not need to be a complete project, just an implementation of the pattern. -- I did not create an error proof 
                //program, but honestly it is much easier to test that my code works properly if I can run it with changable values.
            //I found the strategy design pattern very useful for the way I used it, and can see that it can be implemented similarly in many contexts,
            //potentially game damage calculations depending on the weapon equiped, or dice calculations based on which types of dice are being rolled

            int initial_value_1;
            int initial_value_2;
            ConsoleKeyInfo selection;
            Iresult result_type = new Fraction();


            while (true)
            {
                Console.Clear();
                Console.Write("Please type a value to be divided : ");
                initial_value_1 = int.Parse(Console.ReadLine());
                Console.Write("What should " + initial_value_1 + " be divided by? : ");
                initial_value_2 = int.Parse(Console.ReadLine());
                Console.Write("Calculate as (R)emainder, (D)ecimal, or (F)raction? : ");
                do
                {
                    selection = Console.ReadKey();
                } while(selection.Key != ConsoleKey.R && selection.Key != ConsoleKey.D && selection.Key != ConsoleKey.F);
                Console.WriteLine("\n");
                if(selection.Key == ConsoleKey.R)
                {
                    result_type = new Remainder();
                }
                else if (selection.Key == ConsoleKey.D)
                {
                    result_type = new Decimal();
                }
                else if (selection.Key == ConsoleKey.F)
                {
                    result_type = new Fraction();
                }
                Strategy question = new Strategy(initial_value_1, initial_value_2, result_type);
                Console.WriteLine("Press any key to start from the beginning...");
                Console.ReadKey();
            }
        }
    }
}
