//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] FillArray(int[] array, int min, int max) // Метод заполнения одномерного массива случайными целыми числами и указанного диапазона [min,max)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;

}

Tuple<int,int> FindMinAndMaxInArray(int[] array) // Метод поиска в массиве максимального и минимального числа
{   
    int size = array.Length;
    Array.Sort(array);
    int max = array[size-1];
    int min = array[0];
    return new Tuple<int, int>(min, max);
}

int[] nullArray = new int[10];
int[] fullArray = FillArray( nullArray, 1, 100);
Console.WriteLine("[{0}]",string.Join(", ",fullArray));
var minMax = FindMinAndMaxInArray(fullArray);
Console.WriteLine("Максимальное число массива: " + minMax.Item2);
Console.WriteLine("Минимальное число массива: " + minMax.Item1);
Console.WriteLine("Их разница: " + (minMax.Item2 - minMax.Item1));