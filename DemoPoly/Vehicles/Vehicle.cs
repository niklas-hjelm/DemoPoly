namespace DemoPoly.Vehicles
{
    // En abstrakt klass går INTE att instansiera (alltså skapa objekt utav)
    public abstract class Vehicle : IMakeNoise
    {
        public int TopSpeed { get; set; }

        //Ger gemensamt beteende för alla barnklasser(subtyper) som GÅR att ändra
        public virtual void MakeSound()
        {
            Console.WriteLine("Vehicle goes *VROOM*");
        }

        //Ger gemensamt beteende för alla barnklasser(subtyper) som INTE kan ändras
        public void PrintTopSpeed()
        {
            Console.WriteLine(TopSpeed);
        }

        //Tvingar alla barnklasser(subtyper) att implementera beteendet
        public abstract void PrintInfo();
    }
}
