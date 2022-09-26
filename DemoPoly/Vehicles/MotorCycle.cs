namespace DemoPoly.Vehicles
{
    // MotorCycle ärver av Vehicle
    public class MotorCycle : Vehicle
    {
        // Property unik för MotorCycle
        public string HandlebarStyle { get; set; }

        //Förändring av ett beteende definierat i en förälderklass
        public override void MakeSound()
        {
            Console.WriteLine("Motorcycle goes *BLUBBLUB*");
        }

        // Implementation av en abstrakt metod som är definierad i en förlälderklass
        public override void PrintInfo()
        {
            Console.WriteLine($"Motorcycle has a {HandlebarStyle} handlebar");
        }
    }
}
