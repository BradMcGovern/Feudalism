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

            Application.Run(new Interface());

            

        }

        static void initializeGame()
        {

            using (StreamReader sr = new StreamReader(@"..\..\Territories.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Variables.addTerritory(values[0], int.Parse(values[1]));

                }
            }

        }

    }
}
