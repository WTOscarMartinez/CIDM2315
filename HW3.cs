namespace HW3;
class Program
{
    static void Main(string[] args)
    {
        //Q1 Write a C# program that: takes as input a number N, if the number N is a prime number, print “N is prime”, else print “N is non-prime”.

        //Ask for input
        Console.WriteLine("Input an interger:");
        //Read input
        int input = Convert.ToInt16(Console.ReadLine());
        //Default is prime because if its divisible by any number between 2 and <N it becomes not prime.
        string q1Answer = "N is prime"; 

        //exception for 1 and 0
        if(input <= 1)
        {
            q1Answer = "N is non-prime";
        }else
        {
            //For loop will iterate between 2 to < input
            for(int i = 2; i < input; i++) 
            {
                //check if its divisible
                if(input % i == 0)
                {
                    //if divisible the set as non-prime
                    q1Answer = "N is non-prime";
                    break;
                }
            }
        }
        //print answer
        Console.WriteLine(q1Answer);



        //Q2 Write a C# program:- input an integer N - and it prints on screen the following square pattern, where the number of rows and columns is equal to N
        //Ask for input
        Console.WriteLine("Assign an int value to N:");

        //Read input
        input = Convert.ToInt16(Console.ReadLine());
        //For loop will make a new line after the nested loop is finish
        for(int i = 1; i <= input; i++)
        {
            //Nested for loop is iterating from 1 to the input number and will write # each time it iterates.
            for(int x = 1; x <= input; x++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }



        //Q3 Write a C# program - input an integer number N - and it prints on screen the following square pattern, where the number of rows is equal to N
        //Ask for input
        Console.WriteLine("Assign an int value to N:");

        //Read input
        input = Convert.ToInt16(Console.ReadLine());
        //For loop will make a new line after the nested loop is finish
        for(int i = 1; i <= input; i++)
        {
            //Nested for loop is iterating based on the iteration of the first loop.
            for(int x = 1; x <= input; x++)
            {
                //If 2nd loop iteration matches the first loop current iteration. It will fill with * and " " otherwise.
                if(x <= i)
                {
                    //Console write *
                    Console.Write("*");

                }else
                {
                    //Console write " "
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }


        //Q4 Write a C# program - input a number N - and it prints on screen the following square pattern, where the number of rows is equal to N
        //Ask for input
        Console.WriteLine("Assign an int value to N:");

        //Read input
        input = Convert.ToInt16(Console.ReadLine());
        //For loop will make a new line after the nested loop is finish
        for(int i = 1; i <= input; i++)
        {
            //Nested for loop is iterating based on the number of the input.
            for(int x = 1; x <= input; x++)
            {
                //if the 2nd loop iteration is greater than the input minus the current first loop iteration, it will write the cuurent first loop iteration, other wise it will fill it with a space.
                if(x > input - i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

    }
}
