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

            Food("Jay ", " pizza");
            Food("Becky ", " ice cream");

            RetCalc(24);

            double hoursWorkedWeekly = 42.3d;
            double hourlyWage = 12.50d;

            Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorkedWeekly, hourlyWage));


            //int answer = Add(numOne, numTwo);
            //Console.WriteLine("The sum of your two numbers is " + answer); 

            //RobotWarning("Jay Miller");
            //Useless();

            //string myBirthMonth = "April";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);
            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);


            //}
            ////method header-
            ////access modifier, return type, method name(in pascal Case)(first letter cap), parentheses
            ////public static int Add(int firstNumber, int secondNumber)
            //{
            //method body-
            //ac complete method(header and body) is called method declaration

            //int sum = firstNumber + secondNumber;
            //return sum;
            //the return takes whatever value is determined by using this method..
            //..and sends that value back to wherever i call my method
        }
        //if you have a method that does NOT have a return value, you would use the keyword void
        //when void we dont need to use return

        //public static void RobotWarning(string name)
        //{
        //    Console.WriteLine("Danger, " + name + "!!");
        //}

        //public static void Useless()
        //{
        //    Console.WriteLine("stuff");
        //}

        //public static string Vehicle(string birthMonth)
        //{
        //    string vehicleFortune;
        //    if(birthMonth.ToUpper() == "APRIL" || birthMonth.ToUpper() == "OCTOBER")
        //    {
        //        vehicleFortune = "Hoverboard";
        //    }
        //    else
        //    {
        //        vehicleFortune = "SUV";
        //    }
        //    return vehicleFortune;
        //}
        //create a method called favoritme food
        //it should take two string parameters. one representing a name, the other representing a food
        //the return type should be void

        public static void Food(string name, string favFood)
        {
            Console.WriteLine(name + "likes" + favFood);
        }
        ////Create a method called RetirementCalculator
        //It should take an int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires using 65 as the age of retirement.
        //The return type should be void
        //Once it calculates the user's retirement age it should print
        //"The user will retire in X years" where x represents the value that was calculated
        public static void RetCalc(int userAge)
        {
            int retYrs = 65 - userAge;
            Console.WriteLine("You will retire in " + retYrs + " years.");
        }
        //wage calculator
        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //this method should calculate the monthly wage
            double monthlyWage = (hoursWorkedWeekly* 52 * hourlyWage) / 12;
            return monthlyWage;
        }
        
    
       
    }
}
