//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//Значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[,] ReadInputCoeff() // Метод записи чисел с консоли в двухмерный массив
{
    int[,] CoeffFunction = new int[2, 2];
    int rows = CoeffFunction.GetLength(0);
    int columns = CoeffFunction.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j == 0)
            {
                Console.WriteLine("Введите коэффициент b{0}:", i+1);
                CoeffFunction[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Введите коэффициент k{0}:", i+1);
                CoeffFunction[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return CoeffFunction;
}

void CheckPointIntersection (int[,] array)   // Метод определения точки пересечения двух линий
{
    double b1 = array[0,0];
    double k1 = array[0,1];
    double b2 = array[1,0];
    double k2 = array[1,1];
    double[] arrayPoint = new double[2];
    if (k1 == k2 || b1 == b2)
    {
        Console.WriteLine("Прямые не имею точки пересечения. Они параллельны!");
    }
    else 
    {
        double x = (b2-b1)/(k1-k2);
        double y = (k1*x) + b1;
        arrayPoint[0] = x;
        arrayPoint[1] = y;
        Console.WriteLine("Прямые пересекаются в точке : [{0}]",string.Join(", ",arrayPoint));
    }
}

Console.WriteLine("Проверим пересекаются ли прямые y = k1 * x + b1 и y = k2 * x + b2");
int[,] CoeffFunctions = ReadInputCoeff();
CheckPointIntersection(CoeffFunctions);