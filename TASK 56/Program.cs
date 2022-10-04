// Задача 56.
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = GetNumbers("Введите m: ");
int n = GetNumbers("Введите n: ");
int range = GetNumbers("Введите диапазон чисел в массиве: от 0 до ");

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[m, n];
CreateArray(array);
OutputArray(array);

// Переберём элементы в массиве в каждой строке.
// Найдём сумму элементов в каждой строке. 
// Строку с наименьшей суммой запишем в отдельную переменную и выведём её на печать.
int TotalSumRow = SumRowElements(array, 0);
int minSumRow = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRowElements(array, i);
    if (TotalSumRow > tempSumRow)
    {
        TotalSumRow = tempSumRow;
        minSumRow = i;
    }
}

Console.WriteLine("");
Console.WriteLine($"{minSumRow + 1} - строкa с наименьшей суммой элементов ");

int SumRowElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int GetNumbers(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
}
