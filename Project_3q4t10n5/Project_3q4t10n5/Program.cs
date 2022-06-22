namespace Project_3q4t10n5;

public class Program
{
    private readonly static string FILE_PATH = "Files/";
    private readonly static string SOLUTION_FILES_PATH = "Files/Solutions";

    private readonly static Helpers _helpers =  new Helpers();
    private readonly static MatrixCalculator _matrixCalculator = new MatrixCalculator();

    /*
     * Zentrale Methode Main
     */
    public static void Main(string[] args)
    {
        var currentExample = "Example.csv";

        Console.WriteLine("Starting Project_3q4t10n5 \n");
        Console.WriteLine($"Using Example {FILE_PATH}{currentExample} \n");

        //Einlesen der Matrix C
        var matrix = _helpers.ReadCSV($"{FILE_PATH}{currentExample}");

        //Gültigkeitsprüfung (quadratisch, Mindestgröße 2)
        if(matrix.Length < 2 || matrix.Length != matrix[0].Length)
        {
            Console.WriteLine("Invalid Matrix Length/Format!");
            Console.ReadKey();
            return;
        }

        //Lösen der Multiplikation
        _matrixCalculator.SolveMatrixMultiplication(matrix, out double[][] a, out double[][] b);

        //Ausgabe der Lösung auf der Konsole
        Console.WriteLine("Solution \n");

        Console.WriteLine("Matrix C (Source) \n");
        _helpers.PrintMatrix(matrix);

        Console.WriteLine("\nMatrix A\n");
        _helpers.PrintMatrix(a);

        Console.WriteLine("\nMatrix B\n");
        _helpers.PrintMatrix(b);

        //Schreiben der Lösung in CSV-Files
        _helpers.WriteSolutionCSV(SOLUTION_FILES_PATH, a, b);

        Console.ReadKey();
    }
}