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


    }

    
}
