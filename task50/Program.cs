// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве.
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] array = GetArray(5, 5, 0, 100);
PrintArray(array);

int row = GetUserNumber("Введите индекс строки: ", "Ошибка ввода");
int column = GetUserNumber("Введите индекс столбца: ", "Ошибка ввода");

PresenceElement(array, row, column);

void PresenceElement(int[,] array, int row, int column)
{
    if (row <= 4 && column <= 4)
        Console.WriteLine(array[row, column]);

    else
        Console.WriteLine("Данного элемента нет");
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
int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}