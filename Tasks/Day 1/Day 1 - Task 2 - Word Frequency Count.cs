class Task2
{
    public static void Main()
    {
        System.Console.Write("Enter a string: ");

        string userInput = Console.ReadLine();
        string noPunctuation = "";

        foreach (char c in userInput)
        {
            if (char.IsLetter(c))
            {
                noPunctuation += char.ToLower(c);
            }
            else if (c.Equals(' '))
            {
                noPunctuation += ' ';
            }
        }

        Dictionary<string, int> counter = new Dictionary<string, int>();

        foreach (string word in noPunctuation.Split(" "))
        {
            // System.Console.WriteLine($"word: {word} and {word.Equals("")}");
            if (!counter.ContainsKey(word) && !word.Equals(""))
            {
                counter[word] = 1;
            }
            else if (counter.ContainsKey(word) && !word.Equals(""))
            {
                counter[word] += 1;
            }
        }

        System.Console.WriteLine("----------------");
        System.Console.WriteLine("Word Frequency");
        System.Console.WriteLine("----------------");

        foreach (string key in counter.Keys)
        {
            System.Console.WriteLine($"{key}: {counter[key]}");
        }
    }
}