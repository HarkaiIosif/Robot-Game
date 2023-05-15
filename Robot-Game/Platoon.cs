using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{   
    public class Platoon
    {   public string name { get; set; } 
        public Officer Officer { get; set; }
        public Squadron Squad1 { get; set; }
        public Squadron Squad2 { get; set; }
        public Squadron Squad3 { get; set; }
        public Entity HeavySupport { get; set; }
        public List<Entity> Soldiers { get; set; }
        public Platoon(string name,Squadron squadron1, Squadron squadron2, Squadron squadron3, Entity heavySupport)
        {
            this.name = name;
            Officer = new Officer();
            this.Officer.Name = "Leftenant of " + this.name;
            this.Squad1 = squadron1;
            this.Squad2 = squadron2;
            this.Squad3 = squadron3;
            this.HeavySupport = heavySupport;
            Soldiers = new List<Entity>
            {
               Squad1, Squad2, Squad3,heavySupport,Officer
            };
            
        }
    }
}
