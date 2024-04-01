using System.Collections.Generic;

namespace Homework9.cs;
class Program
{
    static void Main(string[] args)
    {
        //creating student objects
        Student alice = new Student(111,"Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333,"Cathy");
        Student david = new Student(444,"david");
        //creating dictionary to store grades and the name of the students
        Dictionary<string,double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);

        //Checking if Tom doesn't exists, if not add him.
        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }
        //Using average method to get average and then printing it.
        Console.WriteLine($"The average GPA is: {gradebook.Values.Average()}");
        
        //iterating on the gradebook
        foreach(var stuGrd in gradebook){
            //checking who has a higher grade than the average
            if(stuGrd.Value > gradebook.Values.Average()){
                //iterating list of students in studentlist
                foreach(var student in Student.studentList){
                    //checking if the student matches the student in the gradebook
                    if(student.GetStudentName() == stuGrd.Key){
                        //print info method to print student info
                        student.PrintInfo();
                    }
                }
            }
        }
    }
}

class Student {
    private int studentID;
    private string studentName;

    public void PrintInfo() {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> studentList = new List<Student>();

    public Student(int StudentID, string StudentName) {
        this.studentID = StudentID;
        this.studentName = StudentName;

        studentList.Add(this);
    }
    //Added Getstudentname method, just to be able to access information from outside
    public string GetStudentName(){
        return studentName;
    }
}
