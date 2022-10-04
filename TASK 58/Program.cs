// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Определение. Произведением двух матриц А и В называется матрица С,
// элемент которой, находящийся на пересечении i-й строки и j-го столбца,
// равен сумме произведений элементов i-й строки матрицы А
// на соответствующие (по порядку) элементы j-го столбца матрицы В.

int m = GetNumbers("Введите число строк 1-й матрицы: ");
int n = GetNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = GetNumbers("Введите число столбцов 2-й матрицы: ");
int range = GetNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateNewArray(firstMartrix);
Console.WriteLine();
Console.WriteLine($"Первая матрица:");
OutputArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateNewArray(secondMartrix);
Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
OutputArray(secondMartrix);

int[,] finalMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, finalMatrix);
Console.WriteLine();
Console.WriteLine($"Результат умножения первой и второй матриц:");
OutputArray(finalMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] finalMatrix)
{
  for (int i = 0; i < finalMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < finalMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      finalMatrix[i,j] = sum;
    }
  }
}

int GetNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

void CreateNewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void OutputArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
