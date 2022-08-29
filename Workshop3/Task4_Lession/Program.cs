//4 задание Б 
//Найти сумму и произведение 2 рандомизированных массива (все значения должны быть случайными) 
//Обязательное условие оба массива одинаковы по размеру иначе упадете в ошибку ))

void FillArray(int[] array, string number)
{   
    int size = array.Length;
    for (int i = 0; i < size; i++ )
    {
        array[i] = new Random().Next(1,10);
        if (i == 0)
            Console.Write(number + " массив выглядит так [ " + array[i] + " , ");
        else if (i >= 1 && i <= size-2)
            Console.Write( array[i] + " , ");
        else if (i == size-1)
            Console.Write( array[i] + " ]");
    }
    Console.WriteLine();
    
}

void SumArray(int[] arrayA, int[] arrayB)
{
    int sizeA = arrayA.Length;
    int sizeB = arrayB.Length;
    int[] sumArray = new int[sizeA];
    if (sizeA == sizeB)
    {
        for ( int i = 0; i < sizeA; i++)
        {
            sumArray[i] = arrayA[i] + arrayB[i];
            if (i == 0)
                Console.Write("Сумма массивов выглядит так [ " + sumArray[i] + " , ");
            else if (i >= 1 && i <= sizeA-2)
                Console.Write( sumArray[i] + " , ");
            else if (i == sizeA-1)
                Console.Write( sumArray[i] + " ]");
        }
    }
    else
        Console.WriteLine("Массивы имеют разный размер");
    
    Console.WriteLine();
}

void MulArray(int[] arrayA, int[] arrayB)
{
    int sizeA = arrayA.Length;
    int sizeB = arrayB.Length;
    int[] mulArray = new int[sizeA];
    if (sizeA == sizeB)
    {
        for ( int i = 0; i < sizeA; i++)
        {
            mulArray[i] = arrayA[i] * arrayB[i];
                if (i == 0)
            Console.Write("Произведение массивов выглядит так [ " + mulArray[i] + " , ");
                else if (i >= 1 && i <= sizeA-2)
            Console.Write( mulArray[i] + " , ");
                else if (i == sizeA-1)
            Console.Write( mulArray[i] + " ]");
        }
    }
    else
        Console.WriteLine("Массивы имеют разный размер");
    Console.WriteLine();
}

Console.WriteLine("Здравствуйте, попробуем сложить два массива");
int[] arrayA = new int[5];
int[] arrayB = new int[5];
FillArray(arrayA, "Первый");
FillArray(arrayB, "Второй");
SumArray(arrayA,arrayB);
MulArray(arrayA,arrayB);