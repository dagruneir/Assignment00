using System;

namespace Assignment00
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYear ly = new LeapYear();
            bool leap = ly.IsLeapYear(year);
            if (leap){
                Console.WriteLine("Leap year: yay");
            } else {
                Console.WriteLine("Leap year: nay");
            }
        }

        public bool IsLeapYear(int year)
        {
            if (year%4 == 0)
            {
                if(year%100 == 0)
                {
                    if(year%400 ==0)
                    {
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    return true;
                }
            } else {
                return false;
            }
        }
    }

}