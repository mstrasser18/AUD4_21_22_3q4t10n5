namespace Project_3q4t10n5;

public class Program
{
    private readonly static string FILE_PATH = "Files/";
    private readonly static string SOLUTION_FILES_PATH = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Files/Solutions";
    private readonly static Helpers _helpers =  new Helpers();
    private readonly static MatrixCalculator _matrixCalculator = new MatrixCalculator();

    public static void Main(string[] args)
    {
        var currentExample = "Example.csv";

        Console.WriteLine("Starting Project_3q4t10n5 \n");
        Console.WriteLine($"Using Example {FILE_PATH}{currentExample} \n");

        //Read CSV
        var matrix = _helpers.ReadCSV($"{FILE_PATH}{currentExample}");

        //Solve Multiplication
        _matrixCalculator.SolveMatrixMultiplication(matrix, out double[][] a, out double[][] b);

        //Console Output
        Console.WriteLine("Solution\n");
        Console.WriteLine("Matrix C (Source)");
        _helpers.PrintMatrix(matrix);
        Console.WriteLine("\nMatrix A");
        _helpers.PrintMatrix(a);
        Console.WriteLine("\nMatrix B");
        _helpers.PrintMatrix(b);

        //Write CSV
        _helpers.WriteSolutionCSV(SOLUTION_FILES_PATH, a, b);

        Console.ReadKey();
    }
}