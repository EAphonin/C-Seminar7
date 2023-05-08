// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int n = GetUserNumber("Введите количество столбцов: ", "Ошибка ввода");
double[,] array = GetArray(m, n, 0, 1);

PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}