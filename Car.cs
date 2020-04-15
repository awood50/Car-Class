/*Name: Andrew Wood
 *Date: 2/5/19
 *Purpose: Car class in order to calculate acceleration and braking
 * 
 * 
 */
using System;
using static System.Console;
namespace CarClass
{
    public class Car
    {
        public int year_model; //public variable for the year model for the car
        public string make; //public variable for the make of the car
        public int speed; //public variable to hold the speed of the car

        public void SetMake(string carMake, int carModel) //method to set the attributes of the car and set the speed to 0
        {
            year_model = carModel;
            make = carMake;
            speed = 0;
        }

        public int Accelerate() //Accelerate method that increases the speed and returns the value
        {
            speed = speed + 5; //adds 5 to the speed
            return speed; //returns speed value
        }

        public int Brake()//Brake method that decreases the speed of the car
        {
            return speed = speed - 5; //Returns the value of the speed subtracted by 5
        }

        public int current_speed() //Method that gets the speed of the car
        { 
            return speed; //returns the speed of the car 
        }
    }
}
