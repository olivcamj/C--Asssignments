using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4,value = 1;
            //n is the row and j is the column
            for(int i=2; i<=n; i++)
                //first number in the first row is 1
            {//nested for loop
                //
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(value + " ");
                    value++;
                }
                Console.Write("\n");


            }
            Console.ReadLine();
        }
    }
}
