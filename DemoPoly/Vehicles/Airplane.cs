using System.Runtime.Serialization;

namespace DemoPoly.Vehicles;

//Airplane ärver av den abstrakta klassen Vehicle och implementerar interfacet IFly
public class Airplane : Vehicle, IFly
{
    public bool JetEngine { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"This Airplane has a jet engine: {JetEngine}");
    }

    public void Fly()
    {
        Console.WriteLine($"Airplane is shoving itself through the atmosphere");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"*VZOOOOM*");
    }
    
}