using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Parse("6/22/2009 07:00:00 AM");
            //dt.ToString("HH:mm"); // 07:00 // 24 hour clock // hour is always 2 digits


            DateTime utcNow = DateTime.UtcNow;
            //Getting Time of current IP Address, Singapore
            var SGTime = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            var INDTime = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

            DateTime singaporeTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, SGTime);
            DateTime IndianTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, INDTime);

            Console.WriteLine("Time now in India: " + IndianTime.ToString());
            Console.WriteLine("Time now in Singapore: " + singaporeTime.ToString());
           
            Console.WriteLine("Difference between SGT - IST: " + (singaporeTime - IndianTime).ToString());
            Console.ReadLine();
        }
    }
}
