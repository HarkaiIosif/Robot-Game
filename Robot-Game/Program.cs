// See https://aka.ms/new-console-template for more information
using Robot_Game;

Robot robot = new Robot();
robot.Initialise();
robot.Intensity.Kill();
ReinforcedSquad Rangers337th=new ReinforcedSquad(new Squadron(new InfantryMan()), new ATTeam());
robot.AddTarget(Rangers337th.Soldiers);
while (robot.Targets.Count>0)
{
    robot.AttackCurrentTarget();
}

Console.ReadKey();