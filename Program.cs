StudentList<Student> studentList = new StudentList<Student>();

studentList.Add(new Student("Nahom", 23, 1, 10));
studentList.Add(new Student("Jack", 234, 17, 10));
studentList.Add(new Student("Kevin", 23543, 14, 10));

System.Console.WriteLine($"Search by Name: ");
studentList.SearchByName("Nahom").DisplayInfo();

System.Console.WriteLine($"Search by ID: ");
studentList.SearchById(17).DisplayInfo();

studentList.DisplayAll();