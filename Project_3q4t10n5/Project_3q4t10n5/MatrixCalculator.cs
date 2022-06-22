namespace Project_3q4t10n5;

public class MatrixCalculator
{
    /*
     * Methode zum Lösen der umgekehrten Matrixmultiplikation (dynamisch)
     */
    public void SolveMatrixMultiplication(double[][] c, out double[][] a, out double[][] b)
    {
        //Lösungsmatritzen erstellen
        CreateEmptySolutionMatrices(c.Length, out a, out b);

        //Dynamische Lösung (siehe Erkenntnisse unten)
        for (int i = 0; i < c.Length; i++)
        {
            for(int j = 0; j < c[i].Length; j++)
            {
                //Unterhalb der Diagonale = a-Wert
                if(i > j)
                {
                    a[i][j] = (c[i][j] - a[i][0] * b[0][j]) / b[j][j];
                }
                //Über der Diagonale = b-Wert
                if(i < j)
                {
                    b[i][j] = c[i][j] - (a[i][0] * b[0][j]);
                }
                //Diagonalen = b-Wert, a-Diagonale = 1 (bereits generiert)
                if (i == j)
                {
                    double sumOfAB = 0.0;

                    for(int x = 0; x < i ; x++)
                    {
                        sumOfAB += a[i][x] * b[x][i];
                    }

                    b[i][j] = c[i][j] - sumOfAB;
                }
            }
        }
    }

    /*
     * Erstellt Lösungs-Template-Matritzen für a und b mit der angegebenen Größe
     * Fügt die Diagonale A = 1 ein
     * Defaultwerte für A oberhalb der Diagonale und B unterhalb nicht zu berücksichtigen (double default = 0.0)
     */
    private void CreateEmptySolutionMatrices(int size, out double[][] a, out double[][] b)
    {
        a = new double[size][];

        for(int i = 0; i < a.Length; i++)
        {
            a[i] = new double[size];
            for(int j = 0; j < a[i].Length; j++)
            {
                //A-Diagonale = 1
                if(i == j) a[i][j] = 1;
            }
        }

        b = new double[size][];

        for(int i = 0; i < b.Length; i++)
        {
            b[i] = new double[size];
        }
    }


    /*
     * Methode zum Lösen von 3x3 Matritzen (hardcoded)
     * 
     * ERKENNTNISSE
     * 
     * - Für jedes c gibt es eine durchzuführende Rechenoperation
     * - Matrix C zeilenweise durchiterieren
     *      - zuerst a (unter der Diagonale)
     *      - dann b (über der Diagonale / b-Diagonale selbst)
     *      
     */
    private void Solve3x3MatricesHardcoded(double[][] c, in double[][] a, in double[][] b)
    {
        //b11
        b[0][0] = c[0][0];
        //b12
        b[0][1] = c[0][1];
        //b13
        b[0][2] = c[0][2];

        //a21
        a[1][0] = c[1][0] / b[0][0];
        //b22
        b[1][1] = c[1][1] - (a[1][0]*b[0][1]);
        //b23
        b[1][2] = c[1][2] - (a[1][0]*b[0][2]);

        //a31
        a[2][0] = c[2][0]/b[0][0];
        //a32
        a[2][1] = (c[2][1]-a[2][0]*b[0][1]) / b[1][1];
        //b33
        b[2][2] = c[2][2] - a[2][0] * b[0][2] - a[2][1] * b[1][2];   
    }
}
