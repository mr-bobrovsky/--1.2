using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Лаба_1._2
{
    public class Enemy
    {
        [JsonInclude]
        string name;
        [JsonInclude]
        string iconname;
        [JsonInclude]
        int baselife;
        [JsonInclude]
        double lifemodifier;
        [JsonInclude]
        int basegold;
        [JsonInclude]
        double goldmodifier;
        [JsonInclude]
        double spawnchance;
        public Enemy(string name, string iconname, int baselife, double lifemodifier, int basegold, double goldmodifier, double spawnchance) 
        {
            this.name = name;
            this.iconname = iconname;
            this.baselife = baselife;
            this.lifemodifier = lifemodifier;
            this.basegold = basegold;
            this.goldmodifier = goldmodifier;
            this.spawnchance = spawnchance;
        }
        public string Name() { return name; }
        public string IconName() { return iconname; }
        public int BaseLife() { return baselife; }
        public double LifeModifier() { return lifemodifier; }
        public int BaseGold() { return basegold; }
        public double GoldModifier() { return goldmodifier; }
        public double SpawnChance() { return spawnchance; }
    }
}
