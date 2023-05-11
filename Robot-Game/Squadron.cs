using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    
    internal class Squadron:Entity
    {  public int rhp { get; set; }
       public int rdm { get; set; }
       public Squadron(Entity Regular):base(Regular.Damage, Regular.Health,Regular.Name,Regular.WeaponType) 
       {
            this.Damage=7*Regular.Damage;
            this.rhp=Regular.Health;
            this.Health=7*Regular.Health;
            this.rdm=Regular.Damage;
            this.Name=Regular.Name+" Squadron";
            this.WeaponType=Regular.WeaponType;
       }
       public void CheckUnitStrenght()
        {
            if (this.Health != 7 * this.rhp && this.Health % this.rhp == 0) this.Damage -= this.rdm;
        }
        public override void TakeDamage(Robot Rob)
        {
            base.TakeDamage(Rob);
            CheckUnitStrenght();
        }
    }
}
