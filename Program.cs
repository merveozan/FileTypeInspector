using MimeDetective;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the file path:");
        string? filePath = Console.ReadLine();

        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("File path cannot be empty.");
            return;
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            var inspector = new ContentInspectorBuilder()
            {
                Definitions = MimeDetective.Definitions.Default.All()
            }.Build();

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var results = inspector.Inspect(stream);

                var resultsByExtension = results.ByFileExtension();
                var resultsByMimeType = results.ByMimeType();

                if (resultsByMimeType.Any())
                {
                    var mimeType = resultsByMimeType.FirstOrDefault()?.MimeType;
                    Console.WriteLine($"The MIME type of the file is: {mimeType}");
                }
                else
                {
                    Console.WriteLine("MIME type not found.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
