namespace HW2bonus;
class Program
{
    static void Main(string[] args)
    {
        //This program will take a year as an input and check if it is a leap year
        //Declaring variable
        int year;
        //Asking for input and reading it and converting to an interger.
        Console.WriteLine("Please input a year:");
        year = Convert.ToInt16(Console.ReadLine());

        //Using modulus we can easily find out if the year is divisible by any number by setting it equal to zero.
        //If it shouldn't be divisible by a number, I just set it not equal 0.
        if (year%4 == 0 && year%100 != 0 || year%400 == 0)
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else 
        {
            Console.WriteLine(year + " is not a Leap Year");
        }
    }
}
