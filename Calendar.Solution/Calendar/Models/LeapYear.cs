using System;

namespace Calendar
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0) {
        return true;
      } else if (year % 100 == 0) {
        return false;
      } else {
      return year % 4 == 0;
      }
    }
  }
}







// class LeapYear
// {
//   static void Main()
//   {
//     Console.WriteLine("What year were you born in?");
//     string stringBirthYear = Console.ReadLine();
//     int birthYear = int.Parse(stringBirthYear);

//     Console.WriteLine("You were alive during these leap years:");
//     for (int year = birthYear; year <= 2020; year ++)
//     {
//       if (year % 4 == 0)
//       {
//         Console.WriteLine(year);
//       }
//     }
//   }
// }