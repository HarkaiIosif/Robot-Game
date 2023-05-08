﻿// See https://aka.ms/new-console-template for more information
using Robot_Game;

internal class Robot
{ public int RobotHealth { get; set; }

    public List<Entity> Targets { get; }
    public Entity CurrentTarget { get; set; }
    public RobotLaserIntensity Intensity { get; set; }
    public Robot()
    {
        this.RobotHealth = 500;
        this.Intensity = new RobotLaserIntensity();
        Intensity.Stun();
        Targets = new List<Entity>();
    }
    public void Initialise()
    {
        Console.WriteLine("Welcome operator please input your password");
        string t = Console.ReadLine();
        string password = "1234";
        if (t == password)
        {
            this.RobotHealth = 500;
            Console.WriteLine("Logged in , robot activated");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }
    }
    public void AddTarget(Entity entity)
    {
        if (!Targets.Contains(entity)) Targets.Add(entity);
        CurrentTarget = Targets[0];
    }
    public void AttackCurrentTarget()
    {
        if (CurrentTarget == null) SwitchToNextTarget();
        if (CurrentTarget != null)
        {
            CurrentTarget.Health -= this.Intensity.LaserDamage;
            this.RobotHealth -= CurrentTarget.Damage;
            Console.WriteLine($"The robot has attacked the {CurrentTarget.Name} dealing {this.Intensity.LaserDamage} damage leaving the enemy with {CurrentTarget.Health} left");   
            if (CurrentTarget.IsAlive() == false)
            {
                SwitchToNextTarget();
            }
        }

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
    public void Deactivate()
    {
        this.RobotHealth = 0;
        this.Intensity.Off();
        Targets.Clear();
        CurrentTarget = null;
        Console.WriteLine("Robot Deactivated");
    }
}