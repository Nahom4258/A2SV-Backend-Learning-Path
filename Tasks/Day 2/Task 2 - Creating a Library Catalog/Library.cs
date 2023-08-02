public class Library
{
    private string Name { set; get; }
    private string Address { set; get; }
    private List<Book> books = new List<Book>();
    private List<MediaItem> mediaItems = new List<MediaItem>();

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        System.Console.WriteLine("Book added!!");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        System.Console.WriteLine("Book removed!!");
    }

    public void AddMediaItem(MediaItem mediaItem)
    {
        mediaItems.Add(mediaItem);
        System.Console.WriteLine("Media Item added!!");
    }

    public void RemoveMediaItem(MediaItem mediaItem)
    {
        mediaItems.Remove(mediaItem);
        System.Console.WriteLine("Media Item removed!!");
    }

    public void PrintCatalog()
    {
        System.Console.WriteLine("**************************************");
        System.Console.WriteLine($"Books Catalog ({books.Count})");
        System.Console.WriteLine("**************************************");

        foreach (Book book in books)
        {
            book.DisplayData();
        }
        System.Console.WriteLine();

        System.Console.WriteLine("**************************************");
        System.Console.WriteLine($"Media Item Catalog ({mediaItems.Count} items)");
        System.Console.WriteLine("**************************************");

        foreach (MediaItem mediaItem in mediaItems)
        {
            mediaItem.DisplayData();
        }
        System.Console.WriteLine();
    }
}