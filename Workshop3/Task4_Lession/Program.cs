//4 задание Б 
//Найти сумму и произведение 2 рандомизированных массива (все значения должны быть случайными) 
//Обязательное условие оба массива одинаковы по размеру иначе упадете в ошибку ))

Console.WriteLine("Здравствуйте, попробуем сложить два массива");
int[] arrayA = new int[5];
int[] arrayB = new int[5];
Console.Write(FillArray(arrayA, "Первый"));

void FillArray(int[] array, string number)
{   
    int len = array.Length;
    int index = 0;
    while (index<len+1)
    {
        array[index] = new Random().Next(1,10);
        if (index == 0)
            Console.WriteLine(number+" массив выглядит так [ "+index+" , ");
        else if (index >= 1 && index >= len-1)
            Console.WriteLine(index+" , ");
        else if (index == len)
            Console.WriteLine(index+" ]");
        index++;
    }
    
}

int[] SumArray(int[] arrayA, int[] arrayB)
{
    int lenA = arrayA.Length;
    int lenB = arrayB.Length;
    int[] sumarray = new int[lenA];
    if (lenA ==lenB)
    {
        int index = 0;
        while (index<lenA+1)
        {
            sumarray[index] = arrayA[index] + arrayB[index];
            index++;
        }
        return sumarray;
    }
    else
    {
        Console.WriteLine("Массивы имеют разный размер");
        return arrayA;
    }
}

int[] MulArray(int[] arrayA, int[] arrayB)
{
    int lenA = arrayA.Length;
    int lenB = arrayB.Length;
    int[] mularray = new int[lenA];
    if (lenA ==lenB)
    {
        int index = 0;
        while (index<lenA+1)
        {
            mularray[index] = arrayA[index] * arrayB[index];
            index++;
        }
        return mularray;
    }
    else
    {
        Console.WriteLine("Массивы имеют разный размер");
        return arrayA;
    }
}