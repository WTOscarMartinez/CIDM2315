namespace Homework6;
//Creating the Professor class, based on the provided UML class diagram for Professor.
class Professor 
{
    public string? profName;
    public string? classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        //Setting salary to the amount provided through the parameter
        salary = salary_amount;
    }
    public double GetSalary(){
        //This will return the set private salary value.
        return salary;
    }
    //This method will print the property values in the console.
    public void PrintInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {GetSalary()}");
       
    }
}
//Creating the Student class, based on the provided UML class diagram for Student.
class Student
{
    public string? studentName;
    public string? classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        //Setting studentGrade to the grade provided through the parameter
        studentGrade = newGrade;
    }
    public double GetGrade(){
        //This will return the set private student grade.
        return studentGrade;
    }
    //This method will print the property values in the console.
    public void PrintInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {GetGrade()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating a new instance of the professor object class naming it prof1, and setting up its properties.
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000);
        //creating a new instance of the professor object class naming it prof2, and setting up its properties.
        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof2.SetSalary(8000);
        //creating a new instance of the student object class naming it stud1, and setting up its properties.
        Student stud1 = new Student();
        stud1.studentName = "Lisa";
        stud1.classEnroll = "Java";
        stud1.SetGrade(90);
        //creating a new instance of the student object class naming it prof1, and setting up its properties.
        Student stud2 = new Student();
        stud2.studentName = "Tom";
        stud2.classEnroll = "Math";
        stud2.SetGrade(80);
        //using the PrintInfo method I created for each class to print results.
        prof1.PrintInfo();
        prof2.PrintInfo();
        stud1.PrintInfo();
        stud2.PrintInfo();
        //Calling the properties of the objects I was able to use them in text and calculate the difference of the professors and the total of the students.
        Console.WriteLine($"The salary difference between {prof1.profName} and {prof2.profName} is: {prof1.GetSalary() - prof2.GetSalary()}");
        Console.WriteLine($"The total grade of {stud1.studentName} and {stud2.studentName} is: {stud1.GetGrade() + stud2.GetGrade()}");
    }
}