int size = 5;
double[] numbers = new double[size];
FillArray(numbers);
double min = FindMin(numbers);
double max = FindMax(numbers);
Console.Write($"В массиве ");
PrintArray(numbers);
Console.Write($" разница между максимальным и минимальным элементами -> {DiffMinMaxInArray(min, max)}\n");


double DiffMinMaxInArray(double min, double max)
{
  return Math.Round(max - min, 3);
}


double FindMax(double[] arr)
{
  double max = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
  }
  return max;
}

double FindMin(double[] arr)
{
  double min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min) min = arr[i];
  }
  return min;
}



void FillArray(double[] array)
{
  Random randGeneration = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(randGeneration.NextDouble() * 20, 2);
  }
}


void PrintArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i != array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}

