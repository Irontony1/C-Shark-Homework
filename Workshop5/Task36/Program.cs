//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] FillArray(int[] array, int min, int max) // Метод заполнения одномерного массива случайными целыми числами и указанного диапазона [min,max)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;

}

int SumOddInArray(int[] array)
{
    int result = 0;
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {   
        if ( array[i]%2 != 0 ) result += array[i];
    }

    return result;

}

int[] nullArray = new int[10];
int[] fullArray = FillArray( nullArray, 1, 10);
Console.WriteLine("[{0}]", String.Join(", ", fullArray));
Console.WriteLine(SumOddInArray(fullArray));