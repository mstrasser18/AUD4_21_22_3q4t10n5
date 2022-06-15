using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3q4t10n5;

public class MatrixCalculator
{
    public void SolveMatrixMultiplication(double[][] c, out double[][] a, out double[][] b)
    {
        CreateTemplateMatrices(c.Length, out a, out b);

        if(c.Length != c[1].Length || c.Length < 2)
        {
            Console.WriteLine("Invalid Matrix Length/Format!");
            return;
        }

        //Hartcoded for 3x3 Matrices
        Solve3x3MatricesHardcoded(c, a, b);
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
