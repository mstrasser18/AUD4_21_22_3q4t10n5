namespace Project_3q4t10n5;

public class Program
{
    private static string _file_path = "Files/";
    private static Helpers _helpers =  new Helpers();

    public static void Main(string[] args)
    {
        var currentExample = "Example.csv";

        Console.WriteLine("Starting Project_3q4t10n5 \n");
        Console.WriteLine($"Using Example Files/{currentExample}");

        var matrix = _helpers.ReadCSV($"Files/{currentExample}");
        _helpers.PrintMatrix(matrix);


        Console.ReadKey();
    }
}