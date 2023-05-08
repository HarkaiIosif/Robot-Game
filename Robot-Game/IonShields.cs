using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    internal class IonShields
    {   public int TotalCharges { get; set; }
        public int CurrentCharges { get; set; } 
        public IonShields() 
        {
            this.TotalCharges = 10;
            this.CurrentCharges = 10;
        }
        public int LowCaliberDamageTaken(int IncomingDamage)
        {   
            if(this.CurrentCharges>0)  IncomingDamage /= 2;
            return IncomingDamage;
        }
        public int HighCaliberChargesTaken(int IncomingDamage)
        {
            if (this.CurrentCharges > 0) 
            { 
                IncomingDamage = 0;
                this.CurrentCharges--;
            }
            return IncomingDamage;
        }
        public int IonDamageTaken(int IncomingDamage)
        {
            if (this.CurrentCharges >= 3) this.CurrentCharges = 0;
            else this.CurrentCharges -= 3;
            return IncomingDamage;
        }
        public void ShieldRepair()
        {
            if (this.CurrentCharges < this.TotalCharges) this.CurrentCharges++;
        }
        public void OverChargedRepair()
        {
            if (this.CurrentCharges < this.TotalCharges - 2) this.CurrentCharges += 2;
            else this.CurrentCharges = this.TotalCharges;
        }

    }
}
