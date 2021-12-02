using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot lot = new CarLot();
            
            
            //Standard Initialization
            var isuzu = new Car();
            lot.CarList.Add(isuzu);
            isuzu.Year = 1999;
            isuzu.Model = "Rodeo";
            isuzu.Make = "Isuzu";
            isuzu.EngineNoise = "Wonkk Wonkk";
            isuzu.HonkNoise = "kibbles n bits, kibbles n bits";
            isuzu.IsDriveable = true;
            isuzu.MakeEngineNoise();
            isuzu.MakeHonkNoise();

            //Object Initializer Syntax
            var toyota = new Car() { Year = 2022, Model = "Corola", Make = "Toyota", EngineNoise = "Wommm Wommm", HonkNoise = "Riiiiipit, Riiiiipit", IsDriveable = true };
            lot.CarList.Add(toyota);
            //toyota.Year = 2022;
            //toyota.Model = "Corola";
            //toyota.Make = "Toyota";
            //toyota.EngineNoise = "Wommmm Wommmm";
            //toyota.HonkNoise = "Riiiiipit, Riiiiipit";
            //toyota.IsDriveable = true;
            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();

            //Constructor Initialization
            var cadillac = new Car(2022, "Escalade", "Cadillac", "neroom neroom", "WACHI WACHI", true);
            lot.CarList.Add(cadillac);
            //cadillac.Year = 2022;
            //cadillac.Model = "Escalade";
            //cadillac.Make = "Cadillac";
            //cadillac.EngineNoise = "neroom, neroom";
            //cadillac.HonkNoise = "WACHI WACHI";
            //cadillac.IsDriveable = true;
            cadillac.MakeEngineNoise();
            cadillac.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
            

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
