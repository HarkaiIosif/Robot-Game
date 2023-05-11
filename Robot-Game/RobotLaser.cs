using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    public  class RobotLaserIntensity
    {   public int LaserDamage { get; set; }
        public int StunDuration { get; set; }
        public RobotLaserIntensity() { }
        public void Kill()
        {
            this.LaserDamage = 5;
            this.StunDuration = 0;
        }
        public void Stun()
        {
            this.LaserDamage = 0;
            this.StunDuration = 2;
        }
        public void Off()
        {
            this.LaserDamage = 0;
            this.StunDuration = 0;
        }
        
        
    }
}
