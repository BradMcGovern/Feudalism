/***********************************
/Program.cs
/"Feudalism" game
/
/Main program driver for game
/
/Created by Brad McGovern
/
/Last updated May 11, 2016
************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feudalism
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            initializeGame();

            Application.Run(new StartScreen());

            Application.Run(new Interface());

            

        }

        static void initializeGame()
        {
            int[] statArray = { -2, -1, 0, 1, 2 };
            int holdNumber;
            Random rnd = new Random();

            //read territories from file and create territory list
            using (StreamReader sr = new StreamReader(@"..\..\Territories.csv"))
            {
                var header = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Variables.addTerritory(values[1], int.Parse(values[2]));

                }
            } //end create territory list

            //read lords from file, assign random stats, and create lord list
            using (StreamReader sr = new StreamReader(@"..\..\Lords.csv"))
            {
                var header = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    //shuffle stat array to produce random stats for lord
                    for (int index = 0; index < 5; index++)
                    {
                        int shuffle = rnd.Next(5);
                        holdNumber = statArray[shuffle];
                        statArray[shuffle] = statArray[index];
                        statArray[index] = holdNumber;
                    }

                    Variables.addLord(values[1], int.Parse(values[2]), statArray[0], statArray[1], statArray[2], statArray[3], statArray[4]);
                    Variables.numberOfLords += 1;
                }
            } //end create lord list

            
            //set affinities between lords
            int affinity = 0;

            for (int index1 = 0; index1 < Variables.numberOfLords; index1++)
            {
                for (int index2 = 0; index2 < Variables.numberOfLords; index2++)
                {
                    if (index1 == index2) 
                    {
                        affinity = 10;
                    } else if (index1 < index2) {
                        affinity = 0;
                        affinity += calculateAffinity(Variables.getLord(index1).getHonorable(), Variables.getLord(index2).getHonorable());
                        affinity += calculateAffinity(Variables.getLord(index1).getPious(), Variables.getLord(index2).getPious());
                        affinity += calculateAffinity(Variables.getLord(index1).getGregarious(), Variables.getLord(index2).getGregarious());
                        affinity += calculateAffinity(Variables.getLord(index1).getAdventurous(), Variables.getLord(index2).getAdventurous());
                        affinity += calculateAffinity(Variables.getLord(index1).getLavish(), Variables.getLord(index2).getLavish());                    
                    } else {
                        affinity = Variables.getLord(index2).getAffinity(index1);
                    }

                    Variables.getLord(index1).addAffinity(affinity);
                }
    
            } //end set affinity
            

        } //end intializeGame()

        static int calculateAffinity(int firstLordStat, int secondLordStat)
        {
            int affinity = firstLordStat * secondLordStat;
            if (Math.Abs(affinity) > 1)
                affinity /= 2;
            return affinity;
        }

    } //end class Program
}
