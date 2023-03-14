using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reiztechHomework
{
    class Program1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input hours:");
            int hours;
            while ((int.TryParse(Console.ReadLine(), out hours) == false) || (hours > 12) || (hours == 0))
            {
                Console.WriteLine("Enter a number more than 0 but less than 12 please.");
            }
            Console.WriteLine("Input minutes:");
            int mins;
            while ((int.TryParse(Console.ReadLine(), out mins) == false) || (mins > 60) || (mins == 0))
            {
                Console.WriteLine("Enter a number more than 0 but less than 60 please.");
            }
            float hourDegrees = CalculateHoursDegrees(hours, mins);
            float minsDegrees = CalculateMinuteDegrees(mins);
            float totalDegrees = Math.Abs(hourDegrees - minsDegrees);
            Console.WriteLine($"The lesser angle in degrees between the hours arrow and the minutes arrow is {(totalDegrees)}");
        }
        static float CalculateHoursDegrees(float i, float j)
        {
            float hVal = i,  mVal = j, addVal, totalDegrees;
            addVal = (mVal / 60) * 30; // this line will determine how much closer the hour hand is to the next hour depending on the minutes rather than set directly in the set hour
            totalDegrees = ((hVal * 30) + addVal);
            return totalDegrees;
        }
        static float CalculateMinuteDegrees(float i)
        {
            float val = i;
            return val * 6;
        }
    }
}
