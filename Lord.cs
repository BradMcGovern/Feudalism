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

        public void addOpinion(int opinion) { opinions.Add(opinion); }
        public void changeOpinion(int opinion, int otherLord) { opinions[otherLord] = opinion; }
        public int getOpinion(int otherLord) { return opinions[otherLord]; }

        public void addRelationship(int relationship) { relationships.Add(relationship); }
        public void changeRelationship(int relationship, int otherLord) { relationships[otherLord] = relationship; }
        public int getRelationship(int otherLord) { return relationships[otherLord]; }

        public void addStance(int stance) { stances.Add(stance); }
        public void changeStance(int stance, int otherLord) { stances[otherLord] = stance; }
        public int getStance(int otherLord) { return stances[otherLord]; }

        private string name;
        private int territory;
        private int honorable;
        private int pious;
        private int gregarious;
        private int adventurous;
        private int lavish;
        private List<int> affinities = new List<int>();
        private List<int> opinions = new List<int>();
        private List<int> relationships = new List<int>();
        private List<int> stances = new List<int>();



    }
}
