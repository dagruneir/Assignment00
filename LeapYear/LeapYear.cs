using System;

namespace Assignment00
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = Int32.Parse(Console.ReadLine());
            LeapYear ly = new LeapYear();
            bool leap = ly.IsLeapYear(year);
            if (leap){
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
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