// See https://aka.ms/new-console-template for more information
using Robot_Game;

Robot robot = new Robot();
robot.Initialise();
robot.Intensity.Kill();
CivilianPopulation cv=new CivilianPopulation();
robot.AddTarget(cv);
while (cv.IsAlive())
{
    robot.AttackCurrentTarget();
}
Console.ReadKey();