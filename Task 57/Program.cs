// Составить частотный словарь элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();

int[,] array = GetArray(3, 3, 0, 10);
int[] res = RepeatElements(array);

PrintArray(array);
PrintArray1(res);

int[] RepeatElements(int[,] arr)
{
    int[] RepeatTable = new int[10];
    // int sum = 0;
    for (int i = 0; i < RepeatTable.Length; i++)
    {
        int sum = 0;
        foreach(int var in arr)
        {
            if (i == var)
            {
                sum++;
            }
            RepeatTable[i] = sum;
        }
    }
    return RepeatTable;
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

void PrintArray1(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.WriteLine($"Цифра {i} выводится {inArray[i]} раз");
    }
}
