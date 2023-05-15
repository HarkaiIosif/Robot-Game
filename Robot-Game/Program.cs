// See https://aka.ms/new-console-template for more information
using Robot_Game;

Robot robot = new Robot();
robot.Initialise();
robot.Intensity.Kill();
Planet planet = new Planet();
planet.Earth();
robot.AddTarget(planet);
while (robot.Targets.Count>0)
{
    robot.AttackCurrentTarget();
}

Console.ReadKey();