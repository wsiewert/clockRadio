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
            Console.WriteLine(defaultClock.time);
            Console.WriteLine("'Help' for a list of commands");

            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Enter 'Exit' or 'Help'");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "time":
                        defaultClock.GetTime();
                        break;
                    case "set hour":
                        defaultClock.SetHour();
                        break;
                    case "help":
                        defaultClock.GetHelp();
                        break;
                    case "station":
                        defaultClock.GetStation();
                        break;
                    case "change station":
                        defaultClock.SetStation();
                        break;
                    default:
                        break;
                }
            } while (userInput != "exit");
        }
    }
}
