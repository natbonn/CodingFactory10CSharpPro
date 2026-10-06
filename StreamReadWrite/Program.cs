using System.Text;

namespace StreamReadWrite;

internal class Program
{
    static void Main(string[] args)
    {
        string inputPath = @"C:\tmp\file.txt";
        string outputPath = @"C:\tmp\file-out.txt";

        try
        {
            using StreamReader reader = new(inputPath);
            using StreamWriter writer = new(outputPath);

            CopyTextBuffer(reader, writer);
            CopyBinaryFile(@"C:\tmp\logo.jpg", @"C:\tmp\logo-out.jpg");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Access denied to file");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
    }

    // with buffer - faster
    public static void CopyTextBuffer(TextReader input, TextWriter output)
    {
        char[] buffer = new char[4096];
        int charsRead;

        while ((charsRead = input.Read(buffer, 0, buffer.Length)) > 0)
        {
            output.Write(buffer, 0, charsRead);
        }
    }

    public static void CopyBinaryFile(string sourcePath, string destinationPath)
    {
        byte[] buffer = new byte[4096];

        using FileStream sourceStream = new(sourcePath, FileMode.Open);        // default open
        using FileStream destinationStream = new(destinationPath, FileMode.Create);  // υπάρχει και .Append προσθέτει στο τέλος

        int bytesRead;

        // while = όσο υπάρχουν data
        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
        {
            destinationStream.Write(buffer, 0, bytesRead);
        }
    }
}
