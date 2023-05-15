using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Officer:Entity
    {
        Random rnd = new Random();
        public Officer(int damage=0,int health=10,string name="Officer",string weapon="LowCal"):base(damage,health,name,weapon)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
            this.WeaponType = weapon;
        }
        public int OfficerAbility()
        {
            int i=rnd.Next(1,5);
            if (i == 2)
            {
                return 30;
            }
            else return 0;
        }

    }
}
