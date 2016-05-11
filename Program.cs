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

            using (StreamReader sr = new StreamReader(@"..\..\Territories.csv"))
            {
                var header = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Variables.addTerritory(values[1], int.Parse(values[2]));

                }
            }

            using (StreamReader sr = new StreamReader(@"..\..\Lords.csv"))
            {
                var header = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Variables.addLord(values[1], int.Parse(values[2]), 0, 0, 0, 0, 0);

                }
            }

        }

    }
}
