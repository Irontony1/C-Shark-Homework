//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindMinSumRow(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    int[] sumRowArray = new int[colomns];
    for(int rowIndex = 0; rowIndex < row; rowIndex++)
    {   
        for (int i = 0; i < colomns; i++) 
        {
            sumRowArray[rowIndex] +=  array[rowIndex,i];
        }
    }
    int min = sumRowArray[0];
    int k = 0;
    for (int i = 0; i < row; i++) 
    {   
        if(sumRowArray[i]<min) 
        {
            min = sumRowArray[i];
            k = i;
        }

    }
    Console.WriteLine($"Наименьшая сумма элементов в {k} строке");
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

Console.WriteLine("Введите число строк и столбцов: ");
int row = Convert.ToInt32(Console.ReadLine());
int colomns = row;
int[,] fullArray = FillArray(row,colomns);
Console.WriteLine("Исходный массив");
PrintArray(fullArray);
FindMinSumRow(fullArray);