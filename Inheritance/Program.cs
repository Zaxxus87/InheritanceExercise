using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.Age = 5;
            myBird.CanFly = true;
            myBird.Diet = "herb";
            myBird.FeatherColor = "black";
            myBird.Flightspeed = 3.0;
            myBird.Size = 2;
            myBird.Weight = 6.6;
            myBird.Wingspan = 4.5;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile myLizard = new Reptile();
            myLizard.Age = 6;
            myLizard.Diet = "carn";
            myLizard.Size = 4;
            myLizard.Weight = 18.3;
            myLizard.GroundSpeed = 24.5;
            myLizard.HasTail = true;
            myLizard.ScaleColor = "green";
            myLizard.ColdBlooded = false;

            Animal[] test = new Animal[2];
            test[0] = myBird;
            test[1] = myLizard;

            foreach(Animal a in test)
            {
                Console.WriteLine($"Age: {a.Age}  Weight: {a.Weight}");
                Console.WriteLine($"Size: {a.Size}  Eats: {a.Diet}");
            }

            Console.WriteLine("Bird");
            Console.WriteLine($"Flight Speed= {myBird.Flightspeed}");
            Console.WriteLine($"Feather Color= {myBird.FeatherColor}");
            Console.WriteLine($"Wing Span= {myBird.Wingspan}");
            Console.WriteLine($"Flys= {myBird.CanFly}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }   
        
    }
}
