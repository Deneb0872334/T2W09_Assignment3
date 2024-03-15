using System.Xml.Linq;

namespace Assignment3
{
    class OOP
    {
        public static void Main(string[] args)
        {
            // new keyword is for creating a new instance of the class
            Car testCar = new Car();

            Car bmw = new Car("BMW");
            bmw.CarColor = Car.Color.BLUE;
            // Speed property is private set
            //bmw.Speed = 30;
            PrintCarDetails(bmw);
            bmw.Accelerate(30);
            bmw.ReduceSpeed(40);
            PrintCarDetails(bmw);

            Car porsche = new Car(350, 0, "Porsche", Car.Type.Manual);
            PrintCarDetails(porsche);

            //Car errorProneCar = new Car(speed: 100, name: "test", type: "Hello");
            //PrintCarDetails(errorProneCar);

        }


        private static void PrintCarDetails(Car car)
        {
            Console.WriteLine(
                $"The car below is created:\n" +
                $"Max Speed: {car.MaxSpeed}\n" +
                $"Speed: {car.Speed}\n" +
                $"Name: {car.Name}\n" +
                $"Type: {car.CarType}\n" +
                $"Gas Amout: {car.GasAmount}\n" +
                $"Tank Size: {car.TankSize}\n\n"
            );
        }
    }
}