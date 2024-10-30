using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public void SetTime(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = 0;
            NormalizeTime(); 
        }
        public void SetTime(int totalSeconds)
        {
            seconds = totalSeconds;
            NormalizeTime(); 
        }
        private void NormalizeTime()
        {
            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds %= 60;
            }

            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }

            hours %= 24;
        }
        public void DisplayTime()
        {
            Console.WriteLine($"Time: {hours}:{minutes}:{seconds}");
        }
    }
}
