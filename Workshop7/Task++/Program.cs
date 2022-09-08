//Задача дополнительная 
//Задайте двумерный массив. Найдите сумму элементов, находящихся ниже главной диагонали 

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


int SumElement(int[,] array)
{   
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    int result = 0;
    
    for (int i = 0, j = 0; j < colomns-1; i++, j++)
    {
        for (int k = i+1; k < row; k++)
        {
            result += array[k,j];
        }
    }
    return result;  
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
int[,] arrayFill = FillArray(row,colomns);
PrintArray(arrayFill);
int sum = SumElement(arrayFill);
Console.WriteLine("Сумма элементов под главной диагональю = "+sum);

