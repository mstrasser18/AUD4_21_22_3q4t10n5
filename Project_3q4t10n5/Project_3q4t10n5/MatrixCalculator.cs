using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3q4t10n5;

public class MatrixCalculator
{
    public void SolveMatrixMatrixMultiplication(double[][] c, out double[][] a, out double[][] b)
    {
        CreateTemplateMatrices(c.Length, out a, out b);

        //Hartcoded for 3x3 Matrices

    }

    private void CreateTemplateMatrices(int size, out double[][] a, out double[][] b)
    {
        a = new double[size][];

        for(int i = 0; i < a.Length; i++)
        {
            a[i] = new double[size];
            for(int j = 0; j < a[i].Length; j++)
            {
                //Diagonals constant value 1
                if(i == j) a[i][j] = 1;
            }
        }

        b = new double[size][];

        for(int i = 0; i < b.Length; i++)
        {
            b[i] = new double[size];
        } 
    }
}
