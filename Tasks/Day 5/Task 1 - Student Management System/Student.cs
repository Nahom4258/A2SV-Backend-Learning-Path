public class Student : IHasRollNo
{
    public string Name { get; set; }
    private int Age { get; set; }
    public int RollNo { get; set; }
    private double Grade { get; set; }

    public Student(string name, int age, int rollNo, double grade)
    {
        Name = name;
        Age = age;
        RollNo = rollNo;
        Grade = grade;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Name: {this.Name}");
        System.Console.WriteLine($"Age: {this.Age}");
        System.Console.WriteLine($"RollNo: {this.RollNo}");
        System.Console.WriteLine($"Grade: {this.Grade}");
        System.Console.WriteLine();
    }
}