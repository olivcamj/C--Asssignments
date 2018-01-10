using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExmple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number (1 for Mon -7 for Sun)");
            //int.Parse(Console.ReadLine()) it means you are converting user input value(which is a string) in to a integer.
           int daynumber = int.Parse(Console.ReadLine());
            //when  number is chosen it wil lead to a day, numbers 1-7 are associated with a daynumber
            //chosing a number besides the ones specified will lead to the default case being used

            switch (daynumber)
            {
                case 1:
                    {
                        Console.WriteLine("Mon");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tues");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wedn");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thur");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Fri");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sat");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sun");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input.Try Again.");
                        break;
                    }
                    
            }
            //below there is a readline don't forget to add this!
            Console.ReadLine();
        }
    }
}
