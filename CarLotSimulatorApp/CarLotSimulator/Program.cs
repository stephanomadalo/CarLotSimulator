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
            

             Car Jeep = new Car();
            lot.CarList.Add(Jeep);
            Jeep.Make = "Jeep";
            Jeep.Model = "Cherokee";
            Jeep.Year = 2000;
            Jeep.EngineNoise = "Rawr";
            Jeep.HonkNoise = "Beep";
            Jeep.IsDriveable = true;

            Jeep.MakeEngineNoise();
            Jeep.MakeHonkNoise();

            Car Ford = new Car() { Year = 2015, Make = "Ford", Model = "Focus", EngineNoise = "wehhhh", HonkNoise = "Bleeep", IsDriveable = true};
            lot.CarList.Add(Ford);
            Ford.MakeEngineNoise();
            Ford.MakeHonkNoise();

            Car Tesla = new Car("Tesla", "Cybertruck", 3030, "Woosh", "Braaapp", false);
            lot.CarList.Add(Tesla);
            Tesla.MakeEngineNoise();
            Tesla.MakeHonkNoise();

            Console.WriteLine("~~~~~~~~~~~~~~~");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            } 

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


        }
    }
}
