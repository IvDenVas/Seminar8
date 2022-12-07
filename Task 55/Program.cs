// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
//  если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
int rows = UserInput("Введите количество строк: ", "Ошибка ввода!");
int columns = UserInput("Введите количество столбцов: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, -50, 50);

PrintArray(array);
Console.WriteLine();
int[,] res = Metod(array);
PrintArray(res);




int UserInput (string message, string message1)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > 0)
            return num;
        Console.WriteLine(message1);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] Metod(int[,] inArray)
{
    int[,] revers = new int[inArray.GetLongLength(1), inArray.GetLength(0)];
    for (int i = 0; i < revers.GetLength(0); i++)
    {
        for (int j = 0; j < revers.GetLength(1); j++)
        {
            revers[i,j] = inArray[j,i];
        }
       
    }
    return revers;
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
