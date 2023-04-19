/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

 double[,] CreateArray (int Lenght1, int Lenght2)
{
  double[,] Array =  new double[Lenght1, Lenght2];
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for( int j = 0; j < Array.GetLength(1); j ++)
    {
      Array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
    }
  }
  return Array;
}

void PrintArray (double[,] Array)
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

PrintArray(CreateArray(4,4)); 

