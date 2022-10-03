// Напишите программу, которая меняет местами 
// первую и последнюю строки двумерного массива.

//Размерность массива: количество строк.
int n = 0;

//Размерность массива: количество столбцов. 
int m = 0;

Console.Write("Введите количество столбцов (M): ");
// Пишем структуру, которая защитит нашу программу от поломки
// в случае ввода пользователем строки, а не числа.
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    m = numberM;
}

Console.Write("Введите количество строк (N): ");
// Пишем структуру, которая защитит нашу программу от поломки
// в случае ввода пользователем строки, а не числа.
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    n = numberN;
}

// Задаём двумерный массив.
int[,] array = new int[n, m];

// Заполняем его рандомными числами.
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

// Выводим массив на печать.
Console.WriteLine("");
Console.WriteLine("Инициирован двумерный массив: ");
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}


// Меняем элементы первой строки на элементы последней строки
// через временную переменную.
for (int i = 0; i < array.GetLength(1); i = i + 1)
{
    int temp = array [0, i];
    array [0, i] = array [array.GetLength(0) - 1, i];
    array [array.GetLength(0) - 1, i] = temp;
}
Console.WriteLine();

for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
