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
            Random randomNumber = new Random();

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
                        int shuffle = randomNumber.Next(5);
                        holdNumber = statArray[shuffle];
                        statArray[shuffle] = statArray[index];
                        statArray[index] = holdNumber;
                    }

                    Variables.addLord(values[1], int.Parse(values[2]), statArray[0], statArray[1], statArray[2], statArray[3], statArray[4]);
                    Variables.NUMBER_OF_LORDS += 1;
                }
            } //end create lord list

            
            //set inital relations between lords
            int affinity = 0;
            int opinion;
            int relationship;
            int stance;

            //loop through all lords to set affinity and opinion
            for (int lord1 = 0; lord1 < Variables.NUMBER_OF_LORDS; lord1++)
            {
                //for each lord, loop through all the lords to set relations
                for (int lord2 = 0; lord2 < Variables.NUMBER_OF_LORDS; lord2++)
                {
                    if (lord1 == lord2)
                    {
                        affinity = 9;
                        opinion = 999;
                    }
                    else if (lord1 < lord2)
                    {  //lord2 hasn't had relations calculated yet
                        //set affinity
                        affinity = 0;
                        affinity += calculateAffinity(Variables.getLord(lord1).getHonorable(), Variables.getLord(lord2).getHonorable());
                        affinity += calculateAffinity(Variables.getLord(lord1).getPious(), Variables.getLord(lord2).getPious());
                        affinity += calculateAffinity(Variables.getLord(lord1).getGregarious(), Variables.getLord(lord2).getGregarious());
                        affinity += calculateAffinity(Variables.getLord(lord1).getAdventurous(), Variables.getLord(lord2).getAdventurous());
                        affinity += calculateAffinity(Variables.getLord(lord1).getLavish(), Variables.getLord(lord2).getLavish());

                        //set opinion
                        opinion = (affinity * 10) + (randomNumber.Next(50) - 25);

                    }
                    else {  //lord2 has already had relations calculated
                        //affinity will be the same
                        affinity = Variables.getLord(lord2).getAffinity(lord1);

                        //need to calculate separate opinion
                        opinion = (affinity * 10) + (randomNumber.Next(50) - 25);
                    }

                    Variables.getLord(lord1).addAffinity(affinity);
                    Variables.getLord(lord1).addOpinion(opinion);
                } //end inner loop
            } //end outer loop

            //now loop again to set relationship and stance
            for (int lord1 = 0; lord1 < Variables.NUMBER_OF_LORDS; lord1++)
            {
                for (int lord2 = 0; lord2 < Variables.NUMBER_OF_LORDS; lord2++)
                {
                    if (lord1 == lord2) {
                        relationship = 999;
                        stance = 9;
                    } else if (lord1 < lord2) {  
                        //set relationship and make sure falls between 100 and -100
                        relationship = ((Variables.getLord(lord1).getOpinion(lord2) + Variables.getLord(lord2).getOpinion(lord1)) / 2) + (randomNumber.Next(50) - 25);
                        relationship = Math.Min(Math.Max(relationship, -100), 100);

                        //set stance
                        if (Math.Abs(relationship) > Variables.HIGH_THRESHOLD)
                        {
                            stance = 3;
                        }
                        else if (Math.Abs(relationship) > Variables.MEDIUM_THRESHOLD)
                        {
                            stance = 2;
                        }
                        else if (Math.Abs(relationship) > Variables.LOW_THRESHOLD)
                        {
                            stance = 1;
                        }
                        else {
                            stance = 0;
                        }
                        if (relationship < 0)
                            stance *= -1;
                    } else {  
                        //relationship and stance will be the same
                        relationship = Variables.getLord(lord2).getRelationship(lord1);
                        stance = Variables.getLord(lord2).getStance(lord1);
                    }

                    Variables.getLord(lord1).addRelationship(relationship);
                    Variables.getLord(lord1).addStance(stance);
                }


            } //end set relations
            

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
