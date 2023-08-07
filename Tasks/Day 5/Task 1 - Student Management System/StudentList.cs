using System.Runtime.CompilerServices;
using System.Text.Json;

public interface IHasRollNo
{
    int RollNo { get; }
    string Name { get; }
}


public class StudentList<T> where T : Student
{
    private List<T> Students = new List<T>();
    private string filePath = "students.json";

    public StudentList()
    {
        LoadFromJsonFile();
    }

    public void Add(T student)
    {
        Students.Add(student);
        System.Console.WriteLine("Student added!!");
        SaveToJsonFile();
    }

    public T SearchById(int id)
    {
        IEnumerable<T> search = Students;

        var result = from student in search where student.RollNo.Equals(id) select student;

        return result.FirstOrDefault();
    }

    public T SearchByName(string name)
    {
        IEnumerable<T> search = Students;

        var result = from student in search
                     where student.Name.Equals(name)
                     select student;

        return result.FirstOrDefault();
    }

    public void LoadFromJsonFile()
    {
        string jsonData = File.ReadAllText(filePath);
        Students.Clear();
        Students.AddRange(JsonSerializer.Deserialize<List<T>>(jsonData));
    }

    public void SaveToJsonFile()
    {
        string jsonData = JsonSerializer.Serialize(Students);
        File.WriteAllText(filePath, jsonData);
    }

    public void DisplayAll()
    {
        foreach (var student in Students)
        {
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("Display All");
            System.Console.WriteLine("===============================");
            student.DisplayInfo();
        }
    }
}