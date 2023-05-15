// See https://aka.ms/new-console-template for more information
using Robot_Game;

public class Robot
{ public int RobotHealth { get; set; }
    Random rnd=new Random();
    public List<Entity> Targets { get; }
    public Entity CurrentTarget { get; set; }
    public RobotLaserIntensity Intensity { get; set; }
    public IonShields Shields { get; set; }
    public Robot()
    {
        this.RobotHealth = 500;
        this.Intensity = new RobotLaserIntensity();
        this.Intensity.Stun();
        this.Targets = new List<Entity>();
        this.Shields=new IonShields();
    }
    public void Initialise()
    {
        Console.WriteLine("Welcome operator please input your password");   
        string password = "12345";
        string t;
        do
        {
            t = Console.ReadLine();
            if (t != password) Console.WriteLine("Wrong password please try again");
        } while (t != password);
        Console.WriteLine("Robot Initialised");
    }
    public void AddTarget(Entity entity)
    {
        Targets.Add(entity);
        CurrentTarget = Targets[0];
    }
    public void AddTarget(List<Entity> targets)
    {
        foreach (Entity target in targets) Targets.Add(target);
        CurrentTarget= Targets[0];
    }
    public void AddTarget(Planet planet)
    {
        foreach (Platoon platoon in planet.Combatants) AddTarget(platoon.Soldiers);
        foreach (Entity entity in planet.NonCombatants) AddTarget(entity);
    }
    public void AttackCurrentTarget()
    {
        if (CurrentTarget == null) SwitchToNextTarget();
        if (CurrentTarget != null)
        {
            if (CurrentTarget.IsAlive())
            {   CurrentTarget.TakeDamage(this);
                Console.WriteLine($"The robot has attacked the {CurrentTarget.Name} dealing {this.Intensity.LaserDamage} damage leaving the enemy with {CurrentTarget.Health} health left");
                this.IncomingDamage(CurrentTarget);
            }
            else SwitchToNextTarget();
        }
        int i = rnd.Next(1, 3);
        if (i == 2) this.Shields.ShieldRepair();
    }
    public void SwitchToNextTarget()
    {
        if(Targets.Count>=1)Targets.RemoveAt(0);
        if (Targets.Count == 0)
        {
            Console.WriteLine("All targets eliminated , filling out mission report and deactivating robot");
            this.Deactivate();
        }
        else
        {
            CurrentTarget = Targets[0];
        }
    }
    public void IncomingDamage(Entity entity)
    {
        string t=entity.WeaponType;
        switch (t)
        {
            case "LowCal":
                {
                    this.RobotHealth-=this.Shields.LowCaliberDamageTaken(entity.Damage);
                    Console.WriteLine($"We took {this.Shields.LowCaliberDamageTaken(entity.Damage)} damage, leaving us with {this.RobotHealth} health and {this.Shields.CurrentCharges} shield charges left");
                    break;
                }
            case "HighCal":
                {
                    this.RobotHealth-=this.Shields.HighCaliberDamageTaken(entity.Damage);
                    Console.WriteLine($"We took {this.Shields.HighCaliberDamageTaken(entity.Damage)} damage, leaving us with {this.RobotHealth} health and {this.Shields.CurrentCharges} shield charges left");
                    break;
                }
            case "Ions" :
                {
                    this.RobotHealth-=this.Shields.IonDamageTaken(entity.Damage);
                    Console.WriteLine($"We took {this.Shields.IonDamageTaken(entity.Damage)} damage, leaving us with {this.RobotHealth} health and {this.Shields.CurrentCharges} shield charges left");
                    break;
                }
        }
    }
    public void IncomingDamage(Officer officer)
    {
        this.RobotHealth -= officer.OfficerAbility();
    }
    public void Deactivate()
    {
        this.RobotHealth = 0;
        this.Intensity.Off();
        Targets.Clear();
        CurrentTarget = null;
        Console.WriteLine("Robot Deactivated");
    }
}