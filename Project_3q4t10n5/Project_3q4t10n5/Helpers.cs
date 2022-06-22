using System.Globalization;

namespace Project_3q4t10n5;

public class Helpers
{
    /*
     * Methode zum Einlesen der Matrix C (csv-Format)
     */
    public double[][] ReadCSV(string path)
    {
        //NumberFormatInfo (zum Parsen von negativen Werten)
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

    /*
     * Schreibt die mitgegeben Matritzen in je ein CSV-File
     * Double-Format 0.00
     */
    public void WriteSolutionCSV(string path, double[][] a, double[][] b)
    {
        //1 File pro Matrix

        //Löschen einer möglichen alten Lösung
        File.Delete($"{path}/A.csv");
        File.Delete($"{path}/B.csv");

        a.Select(x => string.Join(";", x.Select(x => x.ToString("0.00", CultureInfo.InvariantCulture)).ToArray()))
         .ToList()
         .ForEach(x => File.AppendAllText($"{path}/A.csv", $"{x}\n"));

        b.Select(x => string.Join(";", x.Select(x => x.ToString("0.00", CultureInfo.InvariantCulture)).ToArray()))
         .ToList()
         .ForEach(x => File.AppendAllText($"{path}/B.csv", $"{x}\n"));
    }


    /*
     * Ausgeben einer Matrix auf der Konsole
     * Double-Format 0.00
     */
    public void PrintMatrix(double[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j].ToString("0.00", CultureInfo.InvariantCulture)}\t");
            }
            Console.WriteLine();
        }
    }
}
