// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int m = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int n = GetUserNumber("Введите количество столбцов: ", "Ошибка ввода");
int minValue = GetUserNumber("Введите минимальное число диапозона: ", "Ошибка ввода");
int maxValue = GetUserNumber("Введите максимальное число диапозона: ", "Ошибка ввода");
int[,] array = GetArray(m, n, minValue, maxValue);

PrintArray(array);
Console.WriteLine();

double[] result = GetAverageColums(array);
PrintResult(result);

double[] GetAverageColums(int[,] array)
{
    double[] result = new double[n];

    for (int j = 0; j < n; j++)
    {
        int Sum = 0;
        for (int i = 0; i < m; i++)
        {
            Sum += array[i, j];
        }
        result[j] = (double)Sum / m;
    }
    return result;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult(double[] result)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result[i]:f1} ");
    }
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}