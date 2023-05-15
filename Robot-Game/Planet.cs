using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Game
{
    public  class Planet
    {  
        public List<Entity> NonCombatants { get; set; }
        public List<Platoon> Combatants { get; set; }
        public Planet()
        {
            
        }
        public void Earth()
        {
            Squadron Rangers337th = new Squadron(new InfantryMan());
            Squadron Rangers332th = new Squadron(new InfantryMan());
            Squadron Rangers331th = new Squadron(new InfantryMan());
            ATTeam Sapper1Heavy = new ATTeam();
            Platoon Sapper1 = new Platoon("1st Sapper", Rangers331th, Rangers332th, Rangers337th, Sapper1Heavy);
            Squadron RegularInfantry=new Squadron(new InfantryMan());
            ATTeam ConscriptedAT=new ATTeam();
            Platoon Conscript1 = new Platoon("Regular Conscrips", RegularInfantry, RegularInfantry, RegularInfantry, ConscriptedAT);
            CivilianPopulation civies = new CivilianPopulation();
            NonCombatants = new List<Entity>
            {
                civies
            };
            Combatants = new List<Platoon>()
            {
                Sapper1,Conscript1
            };
           
        }
    }
}
