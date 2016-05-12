using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudalism
{
    class Lord
    {
        public Lord()
        { }

        public Lord(string nam, int ter, int hon, int pio, int gre, int adv, int lav)
        {
            name = nam;
            territory = ter;
            honorable = hon;
            pious = pio;
            gregarious = gre;
            adventurous = adv;
            lavish = lav;
        }

        public string getName() { return name; }
        public int getTerritory() { return territory; }
        public int getHonorable() { return honorable; }
        public int getPious() { return pious; }
        public int getGregarious() { return gregarious; }
        public int getAdventurous() { return adventurous; }
        public int getLavish() { return lavish; }

        public void addAffinity(int affinity) { affinities.Add(affinity); }
        public int getAffinity(int otherLord) { return affinities[otherLord]; }
        

        private string name;
        private int territory;
        private int honorable;
        private int pious;
        private int gregarious;
        private int adventurous;
        private int lavish;
        private List<int> affinities = new List<int>();



    }
}
