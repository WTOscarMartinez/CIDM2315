namespace HW2part1;
class Program
{
    static void Main(string[] args)
    {
        /*This program will ask and take a letter grade input and output its corresponding GPA point
        Declaring var and setting it equal to read user input.
        included null check(?) and ToLower method to make the input easier.*/
        Console.WriteLine("Please input letter grade:");
        string? letterGrade = Console.ReadLine()?.ToLower();

        /*Now that the input can take any case letters, I'll make the switch case.
        The switch case will take a letter grade, find the matching condition and make it output 
        the GPA point on console and default other wise*/
        switch (letterGrade) {
            case "a":
                Console.WriteLine("GPA point: 4");
                break;
            case "b":
                Console.WriteLine("GPA point: 3");
                break;
            case "c":
                Console.WriteLine("GPA point: 2");
                break;
            case "d":
                Console.WriteLine("GPA point: 1");
                break;
            case "f":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
    }
}
