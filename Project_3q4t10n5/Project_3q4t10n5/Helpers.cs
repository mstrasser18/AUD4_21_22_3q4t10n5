namespace Project_3q4t10n5;

public class Helpers
{
    public double[][] ReadCSV(string path)
    {
        var lines = File.ReadAllLines(path);
        double[][] result = new double[lines.Length][];

        for(int i = 0; i < lines.Length; i++)
        {
            var cols = lines[i].Split(';');
            result[i] = new double[cols.Length];

            for(var j = 0; j < cols.Length; j++)
            {
                result[i][j] = Convert.ToDouble(cols[j]);
            }
        }

        return result;
    }

    public void PrintMatrix(double[][] matrix)
    {
        Console.WriteLine(matrix);
    }
}
