namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        //Creating 2 customer objects, that will take in provided values.
        Customer cust1 = new Customer(cus_id: 110,cus_name: "Alice",cus_age: 28);
        Customer cust2 = new Customer(cus_id: 111,cus_name: "Bob",cus_age: 30);
        //Calling the PrintCusInfo method within the class object that will print out values.
        cust1.PrintCusInfo();
        cust2.PrintCusInfo();
        //Calling the ChangeId method to change the cus_id int variable.
        cust1.ChangeId(220);
        cust2.ChangeId(221);
        //Printing again
        cust1.PrintCusInfo();
        cust2.PrintCusInfo();
        //Calling the CompareAge method to compare cust1 and cust2 age. The oldest will be printed out.
        cust1.CompareAge(cust2);
    }
}
//Creating Customer class
class Customer
{
    //Creating variables for id, name, and age
    private int cus_id;
    public string cus_name;
    public int cus_age;
    //Constructor that will initialize the variables using values passthrough the parameter.
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    //Method that will change the current id with the passthrough new id .
    public void ChangeId(int new_id){
        cus_id = new_id;
    }
    //Method that will print the current variables values.
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    //Method that uses an if statement to compare this object with the passthrough object and it will print out the oldest.
    public void CompareAge(Customer objCustomer){
        if(this.cus_age < objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }else{
            Console.WriteLine($"{this.cus_name} is older.");
        }
    }
}