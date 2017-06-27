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
        public float radioStation;
        public bool alarmIsSet;
        public int alarmTime;
        public DateTime time;
        public DateTime initialComputerTime;
        public DateTime userSetTime;


        //Constructor
        public ClockRadio()
        {
            time = new DateTime(1994, 7, 7, 0, 0, 0, 000);
            userSetTime = new DateTime(1994, 7, 7, 0, 0, 0, 000);
            initialComputerTime = DateTime.Now;
            radioStation = 0;
            alarmIsSet = false;
            alarmTime = 12;
        }

        //Class Methods
        public DateTime GetTime()
        {
            time = userSetTime;
            time = time + (DateTime.Now - initialComputerTime);
            Console.WriteLine("Current Time: " + time);
            return time;
        }

        public void SetHour()
        {
            int hours = GetTime().Hour;
            Console.WriteLine("current hour:");
            Console.WriteLine(hours);
            Console.WriteLine("please select an hour 0 - 23");

            string userInput = Console.ReadLine();

            userSetTime = userSetTime.AddHours(-hours);
            userSetTime = userSetTime.AddHours(int.Parse(userInput));
        } 

        public void GetHelp()
        {
            Console.WriteLine("clock radio commands:");
            Console.WriteLine("'time' - gets the current time.");
            Console.WriteLine("'set hour' - sets the hour. accepts 1-12 as input.");
            Console.WriteLine("'station' - gets the current radio station.");
            Console.WriteLine("'change station' - gets the current radio station.");
        }

        public void GetStation()
        {
            Console.WriteLine(radioStation);
        }

        public void SetStation()
        {
            string userInput = Console.ReadLine();
            radioStation = float.Parse(userInput);
        }
    }
}
