/* Project: Homework1
      Date: 11-14-2017
    Author: Byron Scott
   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int nfulltimeincome;
            int nparttimeincome;
            int nmultiplied;
            Double dbldivided;
            int nadded;
            int nsubtracted;

            //user input
            Console.Write("How much do you make from your full-time job per month? ");
            nfulltimeincome=Convert.ToInt32(Console.ReadLine());
            Console.Write("How much do you make from your part-time job per month? ");
            nparttimeincome =Convert.ToInt32(Console.ReadLine());

            //calculations
            nmultiplied = nfulltimeincome * nparttimeincome;
            dbldivided = (double)nfulltimeincome / nparttimeincome;
            nadded = nfulltimeincome + nparttimeincome;
            nsubtracted = nfulltimeincome - nparttimeincome;

            //Results
            Console.Write("If you multiply your two sources of income together you would make " + "$" + nmultiplied + " per month! Press enter to see more results.");
            Console.ReadLine();

            Console.Write("If you divided your full-time income by your part-time income you would make " + "$" + dbldivided + " per month! Press enter to see more results.");
            Console.ReadLine();

            Console.Write("If you added your two sources of income together you would make " + "$" + nadded + " per month! Press enter to see more results.");
            Console.ReadLine();

            Console.Write("If you subtracted your part-time income from your full-time you would make " + "$" + nsubtracted + " per month! Let's hope this never happens!");
            Console.ReadLine();

        }
    }
}
