using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class CivilianPopulation:Entity
    {   
        public CivilianPopulation(int damage=0,int health=7000000,string name="civilians",string weapon="LowCal") : base(damage,health,name,weapon)
        {
         
        }
    }
}
