
Console.Write("Введите размер массива через пробел: ");
int[] sizeArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();



int[,] numbers = new int[sizeArray[0], sizeArray[1]];
FillPrint.FillPrint.FillArray(numbers);
FillPrint.FillPrint.PrintMassive(numbers);
System.Console.WriteLine();
FillPrint.FillPrint.PrintMassive(AverageArray(numbers));
System.Console.WriteLine();



double[] AverageArray(int[,] array)
{
  double[] average = new double[array.GetLength(1)];
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      average[j] += array[i, j];
    }
    average[j] = Math.Round(average[j] / array.GetLength(0), 2);
  }
  return average;
}