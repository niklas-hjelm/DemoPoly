// Polymorfi - Polymorphism

using System.Text.Json;
using DemoPoly;
using DemoPoly.Animals;
using DemoPoly.Vehicles;

//Instansiera Car och lägg i en variabel med namnet car
var car = new Car();
//Instansiera MotorCycle och lägg i en variabel med namnet mc
var mc = new MotorCycle();

var plane = new Airplane();

// Insansiera en Lista som kan innehålla objekt av typen Vehicle och
// lägg i en variabel med namnet vehicles
var vehicles = new List<Vehicle>();

//Lägg till referenser till objekten car och mc i listan vehicles
vehicles.Add(car);
vehicles.Add(mc);
vehicles.Add(plane);


//Tilldela värden på TopSpeed och NumberOfDoors på objektet car
car.TopSpeed = 200;
car.NumberOfDoors = 4;

//Tilldela värden på TopSpeed och HandlebarStyle på objektet mc
mc.TopSpeed = 200;
mc.HandlebarStyle = "Normal";

plane.TopSpeed = 1000;
plane.JetEngine = true;

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

// Instansiera en Dog, en Fish och en Bird
var zoe = new Dog();
var wanda = new Fish();
var orville = new Bird();

//Instansiera en lista som kan hålla i objekt av typen Animal.
var animals = new List<Animal>();

//Lägg till objekten av typerna Dog, Fish, Bird i listan (detta för att alla de är subtyper av Animal)
animals.Add(zoe);
animals.Add(wanda);
animals.Add(orville);

//Instansiera en lista som kan hålla i objekt av typer som implementerar IMakeNoise.
var noiseMakers = new List<IMakeNoise>();

//Eftersom både Vehicle och Animal implementerar IMakeNoise så kan båda de typerna läggas till i denna listan
noiseMakers.AddRange(vehicles);
noiseMakers.AddRange(animals);

//Iterera över listan noiseMakers och anropa den metoden som finns definierad i IMakeNoise
foreach (var noiseMaker in noiseMakers)
{
    noiseMaker.MakeSound();
}

//Instansiera en lista som kan hålla i objekt av typer som implementerar IFly.
var flyers = new List<IFly>();

//Eftersom både Airplane och Bird implementerar IFly så kan båda de typerna läggas till i denna listan
flyers.Add(orville);
flyers.Add(plane);

//Iterera över listan flyers och anropa den metoden som finns definierad i IFly
foreach (var flyer in flyers)
{
    flyer.Fly();
}