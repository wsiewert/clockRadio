using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            ClockRadio defaultClock = new ClockRadio();
            Console.WriteLine("'Help' for a list of commands");
            Console.WriteLine(defaultClock.time);

            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Enter 'Exit' to quit the program.");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "time":
                        defaultClock.getTime();
                        break;
                    case "set":
                        defaultClock.getTime();
                        break;
                    case "help":
                        defaultClock.getHelp();
                        break;
                    case "station":
                        defaultClock.getStation();
                        break;
                    case "change station":
                        defaultClock.setStation();
                        break;
                    default:
                        break;
                }
            } while (userInput != "exit");
        }
    }
}
