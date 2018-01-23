using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,opt;
            Console.WriteLine("A menu driven program for a simple calculator:");
 
            System.Console.WriteLine("Enter your first integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are your options:");
            Console.Write("1. Addition.\n2. Subtraction. \n3. Multiplication. \n4. Division. \n5. Exit\n");
            Console.Write("\n");
            Console.WriteLine("Input your choice:");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("The Addition of {0} and {1} is: {2}.", num1, num2, add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("The Subtraction of {0} and {1} is: {2}.", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of {0} and {1} is: {2}.", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Division of {0} and {1} is: {2}.", num1, num2, num1 / num2);
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
             
            }
           
            Console.ReadLine();
        }

        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
