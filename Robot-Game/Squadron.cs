using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    
    internal class Squadron:Entity
    {
       public Squadron(Entity Regular):base(Regular.Damage, Regular.Health,Regular.Name,Regular.WeaponType) 
       {
            this.Damage=7*Regular.Damage;
            this.Health=7*Regular.Health;
            this.Name=Regular.Name+" Squadron";
            this.WeaponType=Regular.WeaponType;
       }
    }
}
