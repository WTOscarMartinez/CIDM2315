namespace HW5;
class Program
{
    static void Main(string[] args)
    {
        /*
        Q1 (2 points): Write a C# method that:
        - get 2 integers as inputs from the keyboard
        - and returns the largest one
        - call this method in Main() and print the result.
        */
        //Ask for input
        //Declare variables
        Console.Write("Q1: Give me two numbers and I will give return you the larger one.\n\rEnter the first interger: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the 2nd interger: ");
        int b = Convert.ToInt16(Console.ReadLine()); 
        
        //Calling the larger method with the inputs included as parameters and setting it equal to a variable named results.
        int results = Larger(a,b);

        //Printing out results.
        Console.WriteLine("a = {0}; b = {1}\n\rThe largest number is: {2}",a,b,results);

        /*
        Q2 (3 points): Write a C# method:
        - get 4 integers as inputs from the keyboard
        - and returns the largest one
        - call this method in Main() and print the result.
        */

        //I'll be reusing previous methods and variables.
        //Asking for inputs and setting inputs
        Console.Write("Q2: Want me to do it with four numbers instead.\n\rEnter the first interger: ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the 2nd interger: ");
        b = Convert.ToInt16(Console.ReadLine()); 
        //Declaring new variables and asking for inputs.
        Console.Write("Enter the 3rd interger: ");
        int c = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the 4th interger: ");
        int d = Convert.ToInt16(Console.ReadLine());

        //Calling and setting the method equal to results.
        results = LargerFour(a,b,c,d);

        //Printing out results.
        Console.WriteLine("a = {0}; b = {1}; c = {2}; d = {3};\n\rThe largest number is: {4}",a,b,c,d,results);
        
        //Q3 (5 points): Please implement the following methods to design an account-creating process:
        
        //Calling a method that will ask for specific information to create an account for the user.
        createAccount();
    }

    //This method takes in parameters inputs from inputs asked from the user and it will decide which number is bigger.
    static int Larger(int x, int y){
        //Compare if a is less than b.
        if(x < y){
            //If true, then b is larger so, return b.
            return y;
        }else{
            //If false, then a is larger so, return a.
            return x;
        }
    }

    //This method will reuse the Larger method to find the larger number out of the four inputs.
    static int LargerFour(int a, int b, int c, int d){
        /*Using the Larger method as way to set a tourney like solution.
        A Larger call is made for a and b to compare first, to see which is larger.
        Then, a Larger call for c and d is done to see which is larger out those two.
        The winners are then put within another Larger call to compare for a final showdown, to see who is really larger.*/
        return Larger(Larger(a,b),Larger(c,d));
    }

    /*This method will ask to enter a username, password, password again, and birthyear. It will use the birth year to call for a
    method that checks the age of the user.
    */
    static void createAccount(){
        //asking for input and setting it to a new variable.
        Console.Write("Q3: Let's create an account for you.\n\rEnter a username: ");
        string? username = Console.ReadLine();
        Console.Write("Enter a password: ");
        string? password = Console.ReadLine();
        Console.Write("Enter a password again: ");
        string? passwordAgain = Console.ReadLine();
        Console.Write("Enter a birthyear: ");
        int birthyear = Convert.ToInt16(Console.ReadLine());

        //If the person is 18 or older, it will find this by Calling for the checkAge method with the parameter input for birth year to see if it returns true or false.
        if(checkAge(birthyear)){
            //Check if passwords match.
            if(password == passwordAgain){
                Console.WriteLine("Account is created successfully");
            }else {
                //If false, call createAccount again.
                Console.WriteLine("Wrong password. Start over");
                createAccount();
            }
        }else{
            //If false then, calls the createAccount method again.
            Console.WriteLine("Could not create an account, not old enough or invalid input. Try Again.");
            createAccount();
        }

    }
    //This method will check if person is over the age of 18.
    static bool checkAge(int birth_year){
        //declare age and set it equal to the current year minus birthyear.
        int age = DateTime.Now.Year - birth_year;
        //Check if the user is 18 or older, then return true if true.
        if(age >=18){
            return true;
        }else{
            return false;
        }
    }
}
