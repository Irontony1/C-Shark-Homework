//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArray(int[] array, int min, int max) // Метод заполнения одномерного массива случайными целыми числами и указанного диапазона [min,max)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;

}

int FindEven(int[] array) // Метод для подсчета кол-ва четных чисел в массиве
{   
    int count = 0;

    foreach (int i in array)
    {
        if (i%2 == 0) count ++;
    }
    return count;
}

int[] nullArray = new int[10];
int[] fullArray = FillArray( nullArray, 100, 1000);
Console.WriteLine("[{0}]", String.Join(", ", fullArray));
Console.WriteLine(FindEven(fullArray));