class Task1
{
    public void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter number of subjects: ");
        string temp_num = Console.ReadLine();
        int subjects;
        Dictionary<string, int> marks = new Dictionary<string, int>();

        if (int.TryParse(temp_num, out subjects))
        {
            for (int i = 0; i < subjects; ++i)
            {
                System.Console.WriteLine($"Subject #{i + 1} name: ");
                string subjectName = Console.ReadLine();

                System.Console.WriteLine($"Subject #{i + 1} score: ");
                int subjectScore = int.Parse(Console.ReadLine());

                if (subjectScore >= 0 && subjectScore <= 100)
                {
                    marks.Add(subjectName, subjectScore);
                }
                else
                {
                    Console.WriteLine("Invalid grade. You'll be graded 0!!!!!!!!!!!!");
                    marks.Add(subjectName, 0);
                }

            }
        }
        else
        {
            System.Console.WriteLine("Invalid value entered!!");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("------------------");
        System.Console.WriteLine("Score Summary");
        System.Console.WriteLine("------------------");

        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine($"Taken subjects: {subjects}");
        System.Console.WriteLine();

        System.Console.WriteLine("------------------");
        System.Console.WriteLine("Subjects");
        System.Console.WriteLine("------------------");

        foreach (var key in marks.Keys)
        {
            System.Console.WriteLine($"{key}: {marks[key]}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine($"AVERAGE: {Average(marks)}");

        float Average(Dictionary<string, int> marks)
        {
            float sum = 0;

            foreach (var key in marks.Keys)
            {
                sum += marks[key];
            }

            return sum / marks.Count;
        }
    }
}