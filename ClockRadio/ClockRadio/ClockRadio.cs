using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        //Member Varibales
        public int radioStation;
        public bool alarmIsSet;
        public int alarmTime;
        public DateTime time;


        //Constructor
        public ClockRadio()
        {
            time = DateTime.Now;
            radioStation = 0;
            alarmIsSet = false;
            alarmTime = 12;
        }

        //Class Methods
        public void getTime()
        {
            Console.WriteLine("Current Time: " + time);
        }

        public void setTime()
        {
            Console.WriteLine("Change to the hour to: ");
            //string userInput = Console.ReadLine();
            //double newHour = time.Hour;
        }

        public void getHelp()
        {
            Console.WriteLine("Clock Radio Commands:");
            Console.WriteLine("'time' - Gets the current time.");
            Console.WriteLine("'set' - Sets the hour. accepts 1-12 as input.");
            Console.WriteLine("'station' - Gets the current radio station.");
            Console.WriteLine("'change station' - Gets the current radio station.");
        }

        public void getStation()
        {
            Console.WriteLine(radioStation);
        }

        public void setStation()
        {
            string userInput = Console.ReadLine();
            radioStation = int.Parse(userInput);
        }
    }
}
