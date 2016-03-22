using System;
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

            string[] terNames = { "Connacht", "Munster" };

            for (int i = 0; i < 2; i++)
            {
                Variables.addTerritory(terNames[i], i);
            }


        }

    }
}
