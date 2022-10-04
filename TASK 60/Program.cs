// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int x = GetNumbers("Введите X: ");
int y = GetNumbers("Введите Y: ");
int z = GetNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3Dimension = new int[x, y, z];
CreateNewArray(array3Dimension);
OutputArray(array3Dimension);

int GetNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

void OutputArray (int[,,] array3Dimension)
{
  for (int i = 0; i < array3Dimension.GetLength(0); i++)
  {
    for (int j = 0; j < array3Dimension.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3Dimension.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3Dimension[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateNewArray(int[,,] array3Dimension)
{
  int[] temp = new int[array3Dimension.GetLength(0) * array3Dimension.GetLength(1) * array3Dimension.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3Dimension.GetLength(0); x++)
  {
    for (int y = 0; y < array3Dimension.GetLength(1); y++)
    {
      for (int z = 0; z < array3Dimension.GetLength(2); z++)
      {
        array3Dimension[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
