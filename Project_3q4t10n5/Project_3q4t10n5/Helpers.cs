using System.Globalization;
using System.Text;

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

    public void WriteSolutionCSV(string path, double[][] a, double[][] b)           //TODO: Double point, save files in project root
    {
        //1 File per Matrix

        //Overwrite old Solution
        File.WriteAllText($"{path}/A.csv", "");
        File.WriteAllText($"{path}/B.csv", "");

        a.Select(x => string.Join(";", x))
         .ToList()
         .ForEach(x => File.AppendAllText($"{path}/A.csv", $"{x}\n"));

        b.Select(x => string.Join(";", x))
         .ToList()
         .ForEach(x => File.AppendAllText($"{path}/B.csv", $"{x}\n"));
    }

    public void PrintMatrix(double[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{Math.Round(matrix[i][j], 2)}\t");
            }
            Console.WriteLine();
        }
    }
}
