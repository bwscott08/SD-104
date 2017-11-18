using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPrevious = 1, nsecondPrevious = 0, nCurrent = 0, nuserPick;

            //user's pick
            Console.WriteLine("Which Fibonacci number would you like to see? ");
            nuserPick = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < nuserPick; n++)
            {

                nCurrent = nPrevious + nsecondPrevious;
                nsecondPrevious = nPrevious;
                nPrevious = nCurrent;
                

            }
            Console.WriteLine("Ok, your Fibonacci calculation is " + nsecondPrevious);
            Console.ReadLine();
        } 
    }
}
