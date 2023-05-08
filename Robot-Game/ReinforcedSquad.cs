using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{   
    internal class ReinforcedSquad
    {
      public List<Entity> Soldiers { get; set; }
      public ReinforcedSquad(Entity RegSquad,Entity Support) 
        {
            Soldiers = new List<Entity>
            {
                RegSquad,
                Support
            };
        }
    }
}
