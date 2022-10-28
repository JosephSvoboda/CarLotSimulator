using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE!
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE!
            //The methods should take one string parameter: the respective noise property - DONE!


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.Year = 2022;
            car1.Make = "Dodge";
            car1.Model = "Charger";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Trumpet";
            car1.IsDrivable = true;

            car2.Year = 2021;
            car2.Make = "Dodge";
            car2.Model = "Ram 1500";
            car2.EngineNoise = "Clank";
            car2.HonkNoise = "Beep";
            car2.IsDrivable = false;

            car3.Year = 2020;
            car3.Make = "Dodge";
            car3.Model = "Gladiator";
            car3.EngineNoise = "Swoooosh";
            car3.HonkNoise = "Boop";
            car3.IsDrivable = true;

            car1.MakeEngineNoise("");
            car1.MakeHonkNoise("");

            car2.MakeEngineNoise("");
            car2.MakeHonkNoise("");

            car3.MakeEngineNoise("");
            car3.MakeHonkNoise("");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car car4 = new Car()
            {
                Year = 1994,
                Make = "Dodge"
            };

            var dodge = new Car(2020, "Dodge", "Challenger", "Vroom", "Boop", true);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
