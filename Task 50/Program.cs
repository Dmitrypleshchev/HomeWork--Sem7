/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int line = ReadInt(" строки в двумерном массиве");
int column = ReadInt(" столбца в двумерном массиве");

int ReadInt(string argument)
{
  Console.WriteLine($"Введите индекс {argument}");
  return int.Parse(Console.ReadLine());
}

int[,] CreateArray (int length1, int length2)
{
  int[,] Array =  new int [length1, length2];
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for( int j = 0; j < Array.GetLength(1); j ++)
    {
      Array[i,j] = new Random().Next(0,10);
    }
  }
  return Array;
}

int [,] numbers = CreateArray(4,4);

void PrintArray (int[,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  { Console.Write("[ ");
    for( int j = 0; j < Array.GetLength(1); j ++)
    {
      Console.Write(Array[i,j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}

if (line < numbers.GetLength(0) && column < numbers.GetLength(1)) 
{
  Console.WriteLine($"Элемент с указанными координатами [{line},{column}] существует в данном массиве");
  Console.WriteLine($"Это число {numbers[line, column]}");
}
else Console.WriteLine($"Числа с координатами [{line},{column}] в массиве нет");

PrintArray(numbers); 



