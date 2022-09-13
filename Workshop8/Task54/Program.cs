//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет: 
//18 20
//15 18

//Cij​=Ai1 *​ B1j​ + Ai2 * ​B2j​+...+ Ain​ * Bnj​

int[,] MulMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    int firstRow = firstMatrix.GetLength(0);
    int firstColomn = firstMatrix.GetLength(1);
    int secondRow = secondMatrix.GetLength(0);
    int secondolomn = secondMatrix.GetLength(1);
    int[,] resultMatrix = new int[firstRow,secondolomn];
    if (firstColomn ==  secondRow)
    {
        for (int i = 0; i < firstRow; i++)
        {
            for (int j = 0; j < secondolomn; j++)
            {
                resultMatrix[i,j] = 0;
                for (int k=0; k < firstColomn; k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        return resultMatrix;
    }
    else
    {
        Console.WriteLine("Такие матрицы не могут быть умножены");
        return resultMatrix;
    }
}

void PrintArray(int[,] array)
{   
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {   
            Console.Write("| "+array[i,j]+" |");  
        }
        Console.WriteLine();
    }
}

int[,] matrixA = new int[,] 
{
    {3,5,4},
    {6,2,5},
    {3,1,4},
};
int[,] matrixB = new int[,] 
{
    {1,9,5},
    {2,3,6},
    {2,3,7},
};
Console.WriteLine("Умножим матрицу A и B (A * B)");
Console.WriteLine("Матрица А выглядит так: ");
PrintArray(matrixA);
Console.WriteLine("Матрица B выглядит так: ");
PrintArray(matrixB);
int[,] result = MulMatrix(matrixA,matrixB);
Console.WriteLine("Матрица их произведения:");
PrintArray(result);