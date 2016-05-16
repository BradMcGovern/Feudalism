/***********************************
/Variables.cs
/"Feudalism" game
/
/Defines variables and methods to be used across forms
/
/Created by Brad McGovern
/
/Last updated May 16, 2016
************************************/


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudalism
{
    class Variables
    {

        private static List<Territory> territoryList = new List<Territory>();
        public static Territory getTerritory(int ter) { return territoryList[ter]; }
        public static void addTerritory(string name, int num)
        {
            Territory newTerritory = new Territory(name, num);
            territoryList.Add(newTerritory);
        }

        private static List<Lord> lordList = new List<Lord>();
        public static Lord getLord(int lord) { return lordList[lord]; }
        public static void addLord(string nam, int ter, int hon, int pio, int gre, int adv, int lav)
        {
            Lord newLord = new Lord(nam, ter, hon, pio, gre, adv, lav);
            lordList.Add(newLord);
        }

        public static int PLAYER_NUMBER = 0; //the lord number of the player; set at the beginning and then never changed
        public static int NUMBER_OF_LORDS = 0;  //the number of lords in the game; set at the beginning and then never changed
        public static readonly int HIGH_THRESHOLD = 90;  //threshold ratings
        public static readonly int MEDIUM_THRESHOLD = 65;
        public static readonly int LOW_THRESHOLD = 25;
        public static string[] stances = { "enemy", "rival", "cool", "neutral", "warm", "friend", "ally" }; //text descriptions for stances

        //method to return a color based on the stat type
        public static Color getColor(int stat, string type)
        {
            int threshold; //what threshold level the stat falls into, used to determine what color is returned

            //set threshold
            if (type == "affinity")
            {
                switch (stat)
                {
                    case -6:
                    case -5:
                        threshold = -3;
                        break;
                    case -4:
                    case -3:
                    case -2:
                        threshold = -2;
                        break;
                    case 2:
                    case 3:
                    case 4:
                        threshold = 2;
                        break;
                    case 5:
                    case 6:
                        threshold = 3;
                        break;
                    case 9:
                        threshold = 9;
                        break;
                    default:
                        threshold = 0;
                        break;
                } //end switch
            }
            else if (type == "stance")
            {
                threshold = stat;
            }
            else {
                if (stat == 999)
                {
                    threshold = 9;
                }
                else if (Math.Abs(stat) > HIGH_THRESHOLD)
                {
                    threshold = 3;
                }
                else if (Math.Abs(stat) > MEDIUM_THRESHOLD)
                {
                    threshold = 2;
                }
                else if (Math.Abs(stat) > LOW_THRESHOLD)
                {
                    threshold = 1;
                }
                else {
                    threshold = 0;
                } //end if..else

                if (stat < 0)
                    threshold *= -1;
            } //end set threshold

            // return color
            switch (threshold)
            {
                case -3:
                    return Color.Red;
                case -2:
                    return Color.FromArgb(255, 128, 128);
                case -1:
                    return Color.FromArgb(255, 192, 192);
                case 1:
                    return Color.FromArgb(192, 255, 192);
                case 2:
                    return Color.FromArgb(128, 255, 128);
                case 3:
                    return Color.Green;
                case 9:
                    return Color.Gold;
                default:
                    return Color.White;
            }
        } //end getColor()

    }

    
}
