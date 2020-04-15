/*Name: Andrew Wood
 *Date: 2/22/19
 *Purpose: Simulates car traveling speeds by running instances of Car class
 * 
 */

using System;
using static System.Console;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();//creates a new instance of a car from the Car class


            car.SetMake("Honda", 2014); //calls the SetMake method in order to create the make of the car

            WriteLine("Begnning speed of the car: " + car.current_speed());//Prints the starting speed of the car, calls the current_speed method to display the speed of the car

            for(int i = 0; i < 5; i++)//I created a for loop instead of having to call each method five times individually. Seemed easier so I hope that is okay 
            {
                WriteLine("Acceleration in progress."); //Prints a message to show acceleration
                car.Accelerate(); //Calls the acceleration method from Car class
                WriteLine("Current speed of the car: " + car.current_speed()); //Prints the current speed of the car

            } 


            for(int j = 0; j < 5; j++)//for loop that makes the car brake five times
            {
                WriteLine("Braking in progress.");//Shows that the car is braking
                car.Brake();//Calls the brake method from the car class to slow the car down
                WriteLine("Current speed of the car: " + car.current_speed()); //Prints the current speed of the car
            } 



            WriteLine("End of program"); //Just a message to show the completion of the program
        }
    }
}
