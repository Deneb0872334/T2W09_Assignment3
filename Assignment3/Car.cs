using System;
namespace Class_Demo_tutorial
{
    public class Car
    {
        /*
		  - maxSpeed
		  - speed
		  - name
		  - type
		  - tankSize
		 */
        // following the concept of OOP - encapsulation and data hiding
        private int maxSpeed = 300;
        private int speed; // back field for Speed property
        private readonly string name;
        private Type type;
        private double tankSize;

        // the constructor is supposed to be public to be accessed from outside of the class
        private Car(int maxSpeed, int speed, string name, Type type, double tankSize)
        {
            this.maxSpeed = maxSpeed;
            this.speed = speed;
            this.name = name;
            this.type = type;
            this.tankSize = tankSize;
            this.CarColor = Color.BLACK;
            GasAmount = tankSize;
        }

        // delegating the construction of the instance to the other constructor
        public Car(int speed, string name, Type type = Type.Automatic) : this(200, speed, name, type, 70)
        { }

        //public Car(int speed, string name, int maxSpeed = 300, string type = "Automatic") { }

        public Car(string name) : this(0, name) { }

        public Car(int maxSpeed, int speed, string name, Type type) : this(maxSpeed, speed, name, type, 70) { }


        // no-arg constructor will set every field to their default values
        public Car()
        {
            Console.WriteLine(
                $"The car below is created:\n" +
                $"Max Speed: {maxSpeed}\n" +
                $"Speed: {speed}\n" +
                $"Name: {name}\n" +
                $"Type: {type}\n" +
                $"Tank Size: {tankSize}\n\n"
            );
        }

        /*
		 * C# style getters and setters
		 */

        // Properties
        // Property is just a member of a class which is similar to the field
        // but it has a block of code for calculation
        // field: stored property
        // property: => computed property
        public string Name
        {
            get { return name; }
        }

        public Type CarType
        {
            get { return type; }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
        }

        public int Speed
        {
            get { return speed; }
            private set
            {
                speed = (value <= maxSpeed) ? value : maxSpeed;
                if (speed < 0) speed = 0;
            }
        }

        public double TankSize
        {
            get { return tankSize; }
        }

        public Color CarColor { get; set; }
        public double GasAmount { get; private set; }

        // programming interface
        public void Accelerate(int speed)
        {
            Speed += speed;
            GasAmount -= speed * 0.5;
        }

        public void ReduceSpeed(int value)
        {
            Speed -= value;
        }


        /*
		 * Java style getters and setters
		 */

        // getters - accessors
        //public string Name()
        //{
        //	return this.name;
        //}

        //public int Speed()
        //{
        //	return speed;
        //}

        //public int MaxSpeed()
        //{
        //	return maxSpeed;
        //}

        //public string Type()
        //{
        //	return type;
        //}


        // setters - mutators
        //public void Speed(int speed)
        //{
        //	this.speed = speed;
        //}

        //public void Name(string name)
        //{
        //	this.name = name;
        //}

        // to create a new type as an enumerated type
        public enum Type { Automatic, Manual }
        public enum FillType { GasFilled, Electric, Hybrid }
        public enum Color { RED, YELLOW, BLUE, WHITE, BLACK }
    }
}