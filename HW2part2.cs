namespace HW2part2;
class Program
{
    static void Main(string[] args)
    {
        /*This program will ask the user for three numbers and print the smallest value.
        Declaring variables.*/
        int num1,num2,num3;

        /*Taking input and assining it to a variable, in the order in which it got input.
        Converting it to interger*/
        Console.WriteLine("Please input the first num:");
        num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num:");
        num3 = Convert.ToInt16(Console.ReadLine());

        //Finding smallest value using nested if statements
        if(num1<num2){
            if(num1<num3){
                Console.WriteLine($"The smallest Value: {num1}");
            }else {
                Console.WriteLine($"The smallest Value: {num3}");
            }
        }else{
            if(num2<num3){
                Console.WriteLine($"The smallest Value: {num2}");
            }else {
                Console.WriteLine($"The smallest Value: {num3}");
            }
        }
    }
}
