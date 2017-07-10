using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods-do stuff, tend to belong to/interact with an object
            //they end with (), and they come built in
            //readline(),writeline(), split(), Reverse(), sort()
            //methods are a tool used for us to create reusable pieces of code
            //methods are a way of us collecting a series of instructions..
            //...and then call them when we need them
            //methods are always part of a class.methods are always children classes
            // a method will never be created inside of another method or member of the class
            //methods are frequently called inside other class or method

            //Console.WriteLine("Hello, please enter the first number to be added.");
            //int numOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numTwo = int.Parse(Console.ReadLine());


            //int answer = Add(numOne, numTwo);
            //Console.WriteLine("The sum of your two numbers is " + answer); 

            //RobotWarning("Jay Miller");
            //Useless();

            string myBirthMonth = "April";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);
            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);


        }
        //method header-
        //access modifier, return type, method name(in pascal Case)(first letter cap), parentheses
        public static int Add(int firstNumber, int secondNumber)
        {
            //method body-
            //ac complete method(header and body) is called method declaration

            int sum = firstNumber + secondNumber;
            return sum;
            //the return takes whatever value is determined by using this method..
            //..and sends that value back to wherever i call my method
        }
        //if you have a method that does NOT have a return value, you would use the keyword void
        //when void we dont need to use return

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static void Useless()
        {
            Console.WriteLine("stuff");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if(birthMonth.ToUpper() == "APRIL" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }
    }
}
