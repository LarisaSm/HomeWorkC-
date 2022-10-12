//Задача 1. Даны две матрицы, количество строк и столбцов 
//которых может быть 3 или 4, заполнены числами от -9 до 9. 
//Выполните умножение матриц.



Random generator = new Random();

int[,] martixA = new int[generator.Next(3, 5), generator.Next(3, 5)];
int[,] martixB = new int[martixA.GetLength(1), generator.Next(3, 5)];


FillPrint.FillPrint.FillArray(martixA, 1, 20);
FillPrint.FillPrint.FillArray(martixB, 1, 20);
System.Console.WriteLine("Матрица А:");
FillPrint.FillPrint.PrintMassive(martixA);
System.Console.WriteLine();
System.Console.WriteLine("Матрица B:");
FillPrint.FillPrint.PrintMassive(martixB);
System.Console.WriteLine();


if (martixA.GetLength(1) != martixB.GetLength(0))
  System.Console.WriteLine("Невозможно провести умножение матриц. Число строк матрицы А не равно числу столбцов матрицы Б");
else
{
  System.Console.WriteLine("Умножение матрицы А на матрицу В:");
  FillPrint.FillPrint.PrintMassive(MultiplicationMatrix(martixA, martixB));
}
System.Console.WriteLine();

int[,] MultiplicationMatrix(int[,] martixA, int[,] martixB)
{
  int[,] multiplication = new int[martixA.GetLength(0), martixB.GetLength(1)];
  for (int i = 0; i < multiplication.GetLength(0); i++)
  {
    for (int j = 0; j < multiplication.GetLength(1); j++)
    {
      for (int k = 0; k < martixA.GetLength(1); k++)
      {
        multiplication[i, j] += martixA[i, k] * martixB[k, j];
      }
    }
  }
  return multiplication;
}