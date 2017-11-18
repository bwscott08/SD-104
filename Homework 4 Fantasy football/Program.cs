using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_Fantasy_football
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double npassingYds, npassingTds, nInterceptions, nrushingYds, nrushingTds, nreceivingYds, nreceivingTds, nTotal;

            //promt user for statistics
            Console.Write("Enter the amount of passing yards your QB threw this week: ");
            npassingYds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of passing touchdowns your QB threw this week: ");
            npassingTds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of Interception your QB threw this week: ");
            nInterceptions = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of rushing yards received by all players: ");
            nrushingYds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of rushing touchdowns received by all players: ");
            nrushingTds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of receiving yards received by all players: ");
            nreceivingYds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the amount of receiving touchdowns received by all players: ");
            nreceivingTds = Convert.ToInt32(Console.ReadLine());

            //Calculations
            nTotal = npassingYds / 25;
            nTotal += npassingTds * 6;
            nTotal += nrushingTds * 6;
            nTotal += nrushingYds / 10;
            nTotal += nreceivingYds / 10;
            nTotal += nreceivingTds * 6;
            nTotal -= nInterceptions * 2;

            //print results
            Console.Write("Your fantasy football total for the week is " + nTotal);
            Console.ReadLine();
            




        }
    }
}
