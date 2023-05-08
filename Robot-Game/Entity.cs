using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    public abstract class Entity
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }    
        public bool IsAlive()
        {
            if(Health > 0) return true;
            else return false;
        }
        public Entity(int damage, int health,string name) 
        {
            this.Health = health;
            this.Damage = damage;
            this.Name = name;   
        }
    }
}
