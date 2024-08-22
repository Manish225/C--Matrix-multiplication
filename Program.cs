using MatrixMultiplication;


Matrix matrixA = new Matrix(4, 4);

matrixA.mat[0, 0] = 1;
matrixA.mat[0, 1] = 1;
matrixA.mat[0, 2] = 1;
matrixA.mat[0, 3] = 0;
matrixA.mat[1, 0] = 2;
matrixA.mat[1, 1] = 2;
matrixA.mat[1, 2] = 2;
matrixA.mat[1, 3] = 0;
matrixA.mat[2, 0] = 3;
matrixA.mat[2, 1] = 3;
matrixA.mat[2, 2] = 3;
matrixA.mat[2, 3] = 0;
matrixA.mat[3, 0] = 0;
matrixA.mat[3, 1] = 0;
matrixA.mat[3, 2] = 0;
matrixA.mat[3, 3] = 0;

Matrix matrixB = new Matrix(4, 4);
matrixB.mat[0, 0] = 1;
matrixB.mat[0, 1] = 1;
matrixB.mat[0, 2] = 1;
matrixB.mat[0, 3] = 0;
matrixB.mat[1, 0] = 2;
matrixB.mat[1, 1] = 2;
matrixB.mat[1, 2] = 2;
matrixB.mat[1, 3] = 0;
matrixB.mat[2, 0] = 3;
matrixB.mat[2, 1] = 3;
matrixB.mat[2, 2] = 3;
matrixB.mat[2, 3] = 0;
matrixB.mat[3, 0] = 0;
matrixB.mat[3, 1] = 0;
matrixB.mat[3, 2] = 0;
matrixB.mat[3, 3] = 0;


Matrix matrixC = matrixA * matrixB;

for(int i = 0; i < matrixC.mat.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.mat.GetLength(0); j++)
    {
        Console.Write(matrixC.mat[i, j]+ " ");
    }
    Console.WriteLine();
}
Console.ReadLine();





