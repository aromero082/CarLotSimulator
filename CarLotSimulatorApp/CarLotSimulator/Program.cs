using System;

namespace CarLotSimulator
{
    class Program
    {
        private static string vroom;
        private static string beep;
        private static object lot;
        private static object lotCars;

        public static object Year { get; private set; }
        public static object Model { get; private set; }
        public static string EngineNoise { get; private set; }
        public static string HonkNoise { get; private set; }
        public static bool IsDriveable { get; private set; }
        public static object Make { get; private set; }
        public static string Nissan { get; private set; }
        public static string Rougue { get; private set; }

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
            //Instantiation 1
            var aaronsCar = new Car();
            aaronsCar.Make = "Toyota";
            aaronsCar.Model = "Tundra";
            aaronsCar.Year = 2015;
            aaronsCar.EngineNoise = "vroooom";
            aaronsCar.HonkNoise = "boom boom";
            aaronsCar.IsDriveable = true;

            //Instantiation 2
            var ashleyscar = new Car();
            {
                Year = 2015;
                Make = "Honda";
                Model = "Civic";
                EngineNoise = "vreem";
                HonkNoise = "beep beep";
                IsDriveable = true;
              
            }
            //Instantiation 3
           
            var navysCar = new Car(2016, Nissan, Rougue, vroom, beep, true);

            //Call the methods
            aaronsCar.MakeEngineNoise();
            ashleyscar.MakeEngineNoise();
            navysCar.MakeEngineNoise();
     

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            foreach (var car in lot.Car) 
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model {car.Model}");
            }
        }
    }
}
