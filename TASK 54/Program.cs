// Задача 54.
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Инициализируем ввод двумерного массива.
int m = GetNumbers("Введите количество строк m: ");
int n = GetNumbers("Введите количество столбцов n: ");
int range = GetNumbers("Введите диапазон чисел в массиве: от 0 до ");

// Инициализируем создание нового двумерного массива, 
// который будет заполнен рандомными числами в нашем диапазоне.
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

// При помощи метода проводим сортировку элементов
// в каждой строке. Наибольший элемент идёт влево.
// Замену производим через временную переменную.
void SortRowElements(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int GetNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

void OutputArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " "); // При выводе массивов, делаем между 
    }                                   // элементами пробел.      
    Console.WriteLine();
  }
}

int[,] array = new int[m, n];
CreateArray(array);
OutputArray(array);

// Выведем на печать поочердно исходный массив и отсортированный. 
Console.WriteLine("");
Console.WriteLine($"Отсортированный массив: ");
SortRowElements(array);
OutputArray(array);
