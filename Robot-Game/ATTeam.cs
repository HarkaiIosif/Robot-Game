using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    internal class ATTeam:Entity
    {  
        public ATTeam(int damage=5,int health=15,string name="AT-Team",string weapon="HighCal"):base(damage,health,name,weapon)
        {
            
        }
    }
}
