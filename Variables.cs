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


    }

    
}
