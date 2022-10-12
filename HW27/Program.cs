Random generator = new Random();

int[,] numbers = new int[generator.Next(4, 8), generator.Next(4, 8)];

FillPrint.FillPrint.FillArray(numbers);
FillPrint.FillPrint.PrintMassive(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с наибольшей суммой элементов = {FindMaxRow(numbers) + 1}");

int FindMaxRow(int[,] matrix)
{
  int maxSum = 0;
  int maxIndexI = 0;
  int sum;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum = sum + matrix[i, j];
    }
    if (sum > maxSum)
    {
      maxSum = sum;
      maxIndexI = i;
    }
  }
  return maxIndexI;
}
