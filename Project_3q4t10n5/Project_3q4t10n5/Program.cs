namespace Project_3q4t10n5;

public class Program
{
    private readonly static string _file_path = "Files/";
    private readonly static Helpers _helpers =  new Helpers();
    private readonly static MatrixCalculator _matrixCalculator = new MatrixCalculator();

    public static void Main(string[] args)
    {
        var currentExample = "Example.csv";

        Console.WriteLine("Starting Project_3q4t10n5 \n");
        Console.WriteLine($"Using Example {_file_path}{currentExample} \n");

        var matrix = _helpers.ReadCSV($"{_file_path}{currentExample}");

        _matrixCalculator.SolveMatrixMatrixMultiplication(matrix, out double[][] a, out double[][] b);

        Console.WriteLine("Solution\n");
        Console.WriteLine("Matrix C (Source)");
        _helpers.PrintMatrix(matrix);
        Console.WriteLine("\nMatrix A");
        _helpers.PrintMatrix(a);
        Console.WriteLine("\nMatrix B");
        _helpers.PrintMatrix(b);

        Console.ReadKey();
    }
}