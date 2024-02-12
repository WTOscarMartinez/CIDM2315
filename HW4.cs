namespace HW4;
class Program
{
    static void Main(string[] args)
    {
        /*Q1 (4 points): Write a C# method that: - takes as input 2 numbers - and returns the largest one 
        - call this method in Main() and print the result.*/

        //Calling method
        Larger();

        /*Q2(6 points):  Write a C# method - take as an integer number N and a shape (left or right) 
        - if the shape is left and N = 5, print values of N and shape, and a left-side triangle with 5 rows*/

        //I'll be making a method that takes parameters, just to switch it up.
        //Asking and taking input
        Console.WriteLine("This program will now take a number and a type of triangle.\n\rInput a number:");
        int N = Convert.ToInt16(Console.ReadLine());
        //Asking and taking input
        Console.WriteLine("left or right:");
        string? Shape = Console.ReadLine();
        /*Calling method to take parameters N and a shape type. 
        I added the to lower function, so as long as 
        you enter the right letters it won't freak out too much.*/
        NumShape(N, Shape?.ToLower());
    }

    static void Larger()
    {
        //Asking for inputs and taking them.
        Console.WriteLine("This program will take two numbers and it will choose the larger number.\n\rInput a number:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input another number:");
        int b = Convert.ToInt16(Console.ReadLine());
        
        //It will compare a and b and output larger number on the console.
        if(a < b)
        {
            Console.WriteLine($"a = {a}; b = {b}\n\rThe largest number is: {b}\n\r");
        }else
        {
            Console.WriteLine($"a = {a}; b = {b}\n\rThe largest number is: {a}\n\r");
        }
    }

    static void NumShape(int N, string? Shape) 
    {
        /*If the shape is left it will output to the console a 
        left triangle composed and scaled of the number inputed*/
        if(Shape == "left")
        {
            //First loop will iterate and writeline based on the inputed number.
            for(int i = 1; i <= N; i++)
            {
                //Second loop will iterate and run through the same if statement, based on the number inputed
                for(int j = 1; j <= N; j++){
                    /*if the second loop is less or equal than the first 
                    loop iteration it will write the input the number otherwise it will place a space*/
                    if(j <= i) 
                    {
                        Console.Write(N);
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        else if(Shape == "right")
        {
            //First loop will iterate and writeline based on the inputed number.
            for(int i = 1; i <= N; i++)
            {
                //Starting from the input number we can use it in a if statement 
                for(int j = N; j >= 1; j--)
                {
                    /*if the second loop iteration is less or equal than the first
                    loop iteration it will write the input the number otherwise it will place a space*/
                    if(j <= i) 
                    {
                        Console.Write(N);
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        else{
            Console.WriteLine("Something went wrong. Rerun the program");
        }
    }
}
