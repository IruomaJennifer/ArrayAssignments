// See https://aka.ms/new-console-template for more information

//4D Array
int[,,,] my4DArray = new int[2, 3, 4, 5] 
{
    {
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}},
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}},
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}}
    },
    {
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}},
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}},
        {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}}
    }
};


//3X3 Matrices

Console.WriteLine("PROGRAM FOR MATRIX OPERATIONS");

double[,] matrixA = new double[3, 3];
double[,] matrixB = new double[3, 3];
double[,] matrixSum = new double[3, 3];
double[,] matrixDiff = new double[3, 3];
double[,] matrixProduct = new double[3, 3];

Console.WriteLine("Input Values for Matrix A");

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        Console.WriteLine($"Enter a value for element [{i},{j}] of matrix A");
        matrixA[i, j] = double.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Input Values for Matrix B");

for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        Console.WriteLine($"Enter a value for element [{i},{j}] of matrix B");
        matrixB[i, j] = double.Parse(Console.ReadLine());
    }
}

//Matrix Addition
for (int i = 0; i < matrixSum.GetLength(0); i++)
{
    for (int j = 0; j < matrixSum.GetLength(1); j++)
    {
        matrixSum[i, j] = matrixA[i, j] + matrixB[i, j];
    }
}

Console.WriteLine();
Console.WriteLine("The sum of the matrices is :");
Console.WriteLine();
for (int i = 0; i < matrixSum.GetLength(0); i++)
{
    for (int j = 0; j < matrixSum.GetLength(1); j++)
    {
        Console.Write(" " + matrixSum[i, j]);
    }
    Console.WriteLine();
}

//Matrix Subtraction
for (int i = 0; i < matrixDiff.GetLength(0); i++)
{
    for (int j = 0; j < matrixDiff.GetLength(1); j++)
    {
        matrixDiff[i, j] = matrixA[i, j] - matrixB[i, j];
    }
}

Console.WriteLine();
Console.WriteLine("The difference of the matrices is :");
Console.WriteLine();
for (int i = 0; i < matrixDiff.GetLength(0); i++)
{
    for (int j = 0; j < matrixDiff.GetLength(1); j++)
    {
        Console.Write(" " + matrixDiff[i, j]);
    }
    Console.WriteLine();
}

//Matrix Multiplication
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(0); j++)
    {
        for (int k = 0; k < matrixA.GetLength(0); k++)
        {
            matrixProduct[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
Console.WriteLine();
Console.WriteLine("The product of the matrices is :");
Console.WriteLine();
for (int i = 0; i < matrixProduct.GetLength(0); i++)
{
    for (int j = 0; j < matrixProduct.GetLength(1); j++)
    {
        Console.Write(" " + matrixProduct[i, j]);
    }
    Console.WriteLine();
}

//Determinant of a 3x3 matrix
var compareDeterminants= DeterminantOf3x3(matrixA)>DeterminantOf3x3(matrixB);
if (compareDeterminants)
{
    Console.WriteLine();
    Console.WriteLine("Determinant of Matrix A is greater than the Determinant of Matrix B");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Determinant of Matrix B is greater than the Determinant of Matrix A");
}


double DeterminantOf3x3(double[,] matrixA)
{
   var det = matrixA[0, 0] * (matrixA[1, 1] * matrixA[2, 2] - matrixA[1, 2] * matrixA[2, 1])
        - matrixA[0, 1] * (matrixA[1, 0] * matrixA[2, 2] - matrixA[1, 2] * matrixA[2, 0])
        + matrixA[0, 2] * (matrixA[1, 0] * matrixA[2, 1] - matrixA[1, 1] * matrixA[2, 0]);
    return det;
}