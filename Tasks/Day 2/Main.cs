class Main
{
    public static void TaskExecutions()
    {
        // Day 2 - Task 1 execution
        Circle circle = new Circle("Circle", 35);
        Rectangle rectangle = new Rectangle("Rectangle", 4, 7);
        Rectangle square = new Rectangle("Sqare", 5);
        Triangle triangle = new Triangle("Triangle", 8, 2);

        circle.PrintShapeArea();
        rectangle.PrintShapeArea();
        square.PrintShapeArea();
        triangle.PrintShapeArea();

        // Day 2 - Task 2 execution
        Library abrehot = new Library("Abrehot", "4 Kilo");
        // add books
        abrehot.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 1925));
        abrehot.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", 1960));
        abrehot.AddBook(new Book("1984", "George Orwell", "9780451524935", 1949));

        // add media items
        abrehot.AddMediaItem(new MediaItem("Inception", "DVD", 154));
        abrehot.AddMediaItem(new MediaItem("Thriller", "CD", 42));
        abrehot.AddMediaItem(new MediaItem("Planet Earth II", "DVD", 300));

        abrehot.PrintCatalog();
    }
}