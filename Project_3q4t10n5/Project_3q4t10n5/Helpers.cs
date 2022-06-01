using System.Globalization;

namespace Project_3q4t10n5;

public class Helpers
{
    public double[][] ReadCSV(string path)
    {
        var fmt = new NumberFormatInfo();
        fmt.NegativeSign = "−";

        var lines = File.ReadAllLines(path);
        double[][] result = new double[lines.Length][];

        for(int i = 0; i < lines.Length; i++)
        {
            var cols = lines[i].Split(';');
            result[i] = new double[cols.Length];

            for(var j = 0; j < cols.Length; j++)
            {
                result[i][j] = double.Parse(cols[j], fmt);
            }
        }

        return result;
    }

    public void PrintMatrix(double[][] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"  {matrix[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
