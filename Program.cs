/*Project: Lab 2 Batting Average
 *   Date: 11-13-2017
 * Author: B.Scott
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_batting_average
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //variable declaration
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAverage;

            //prompt user
            Console.WriteLine("---Calculating Batting Average---");
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();
            
            //prompt user for hits
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32 (Console.ReadLine());

            //prompt user for at bats
            Console.WriteLine("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = (double)nHits / nAtBats;

            //display results
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();

        }
    }
}
