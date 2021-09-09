using System;

namespace Assignment00
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            LeapYear ly = new LeapYear();

            Console.WriteLine("Enter year:");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                ly.UI(year);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter a valid year in numbers only");
                Console.WriteLine("Try Again");
                Main(new string[0]);
            }
        }

        public void UI(int year){
                if (year >= 1582){
                    bool leap = IsLeapYear(year);
                    if(leap){
                        Console.WriteLine("Leap year: yay");
                    } else {
                        Console.WriteLine("Leap year: nay");
                    }
                } else {
                    Console.WriteLine("Please enter year 1582 or above");
                    Console.WriteLine("Try Again");
                    Main(new string[0]);
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