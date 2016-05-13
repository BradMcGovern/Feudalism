using System;
using System.Collections.Generic;
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

        public static int PLAYER_NUMBER = 0;
        public static int NUMBER_OF_LORDS = 0;
        public static readonly int HIGH_THRESHOLD = 90;
        public static readonly int MEDIUM_THRESHOLD = 65;
        public static readonly int LOW_THRESHOLD = 25;

    }

    
}
