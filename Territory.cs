/***********************************
/Territory.cs
/"Feudalism" game
/
/Defines the Territory class
/
/Created by Brad McGovern
/
/Last updated May 16, 2016
************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudalism
{
    class Territory
    {
        public Territory()
            { }
        public Territory(string terName, int lordNum)
        {
            name = terName;
            lordNumber = lordNum;
        }

        public string getName() { return name; }
        public int getLordNumber() { return lordNumber; }
        //public void Setname(string val) { name = val; }
        /**
        public int Getnumber() { return number; }
        public void Setnumber(int val) { number = val; }
        public int Getwealth() { return wealth; }
        public void Setwealth(int val) { wealth = val; }
        public int Getpopulation() { return population; }
        public void Setpopulation(int val) { population = val; }
        public int GetfightingStrength() { return fightingStrength; }
        public void SetfightingStrength(int val) { fightingStrength = val; }
        
        public void SetlordNumber(int val) { lordNumber = val; }
        **/

        private string name;
        private int lordNumber;
        /**
        private int number;
        private int wealth;
        private int population;
        private int fightingStrength;
        
    **/
    }
}
