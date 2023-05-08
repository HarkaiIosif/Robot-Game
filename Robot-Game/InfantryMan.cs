using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    internal class InfantryMan:Entity
    {   
        public InfantryMan(int damage=1,int health=10,string name="Infantry",string weapon = "LowCal") : base(damage, health, name, weapon)
        {
            
        }
    }
}
