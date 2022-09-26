// Polymorfi - Polymorphism

using DemoPoly;
using DemoPoly.Animals;
using DemoPoly.Vehicles;

//Instansiera Car och lägg i en variabel med namnet car
var car = new Car();
//Instansiera MotorCycle och lägg i en variabel med namnet mc
var mc = new MotorCycle();

// Insansiera en Lista som kan innehålla objekt av typen Vehicle och
// lägg i en variabel med namnet vehicles
var vehicles = new List<Vehicle>();

//Lägg till referenser till objekten car och mc i listan vehicles
vehicles.Add(car);
vehicles.Add(mc);

//Tilldela värden på TopSpeed och NumberOfDoors på objektet car
car.TopSpeed = 200;
car.NumberOfDoors = 4;

//Tilldela värden på TopSpeed och HandlebarStyle på objektet mc
mc.TopSpeed = 200;
mc.HandlebarStyle = "Normal";


// Iterera över listan vehicles och anropa alla gemensamma metoder 
foreach (var v in vehicles)
{
    v.MakeSound();
    v.PrintTopSpeed();
    v.PrintInfo();

    // Om objektet v är av typen Car, hämta referensen som den typen och lägg i variabel vCar
    if (v is Car vCar)
    {
        Console.WriteLine("This is a car!");
    }
    // Om objektet v är av typen MotorCycle, hämta referensen som den typen och lägg i variabel vMc
    else if (v is MotorCycle vMc)
    {
        Console.WriteLine("This is a motorcycle!");
    }
}

var zoe = new Dog();
var wanda = new Fish();

var animals = new List<Animal>();

animals.Add(zoe);
animals.Add(wanda);


var noiseMakers = new List<IMakeNoise>();

noiseMakers.AddRange(vehicles);
noiseMakers.AddRange(animals);

foreach (var noiseMaker in noiseMakers)
{
    noiseMaker.MakeSound();
}