//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] FillArray(int row, int colomns)
{
    int[,] array = new int[row,colomns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

int[,] SortRow(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    int[] arrayRow = new int[colomns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            arrayRow[j] = array[i,j];
        }
        Array.Sort(arrayRow);
        Array.Reverse(arrayRow);
        for (int j = 0; j < colomns; j++)
        {
            array[i,j] = arrayRow[j];
        }

    }
    return array;
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

Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] fullArray = FillArray(row,colomns);
Console.WriteLine("Исходный массив");
PrintArray(fullArray);
int[,] sortArray = SortRow(fullArray);
Console.WriteLine("Отсортированный массив");
PrintArray(sortArray);