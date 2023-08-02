public class Book {
    private string Title {get; set;}
    private string Author {get; set;}
    private string ISBN {get; set;}
    private int PublicationYear {get; set;}

    public Book (string title, string author, string isbn, int year) {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
    }

    public void DisplayData() {
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Author: {Author}");
        System.Console.WriteLine($"ISBN: {ISBN}");
        System.Console.WriteLine($"Publication Year: {PublicationYear}");
        System.Console.WriteLine();
    }
}