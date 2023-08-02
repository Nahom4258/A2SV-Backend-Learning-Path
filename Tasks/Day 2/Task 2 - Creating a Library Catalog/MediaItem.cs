public class MediaItem {
    private string Title {get; set;}
    private string MediaType {get; set;}
    private int Duration {get; set;}

    public MediaItem (string title, string mediaType, int duration) {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }

    public void DisplayData() {
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"MediaType: {MediaType}");
        System.Console.WriteLine($"Publication Year: {Duration}");
        System.Console.WriteLine();
    }
}