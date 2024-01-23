namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
        /*This program will solve this linear line Equation:  Z = 4X^2+3Y,
        when X = 2.5, Y = 3.3, by calculating Z and printing it out.*/

        //Declaring as double type variables and setting x and y constants
        const double Z = 2.5, Y = 3.3;

        //Declaring Z and setting up the equation
        double Z = 4 * X * X + 3 * Y;

        //Printing out results
        Console.WriteLine("X = {0}, Y= {1}\r\nThe value of Z is: {2}", Z,Y,Z);
    }
}