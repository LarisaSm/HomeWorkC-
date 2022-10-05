int size = 5;
int[] numbers = new int[size];
FillArray(numbers);

Console.Write($"В массиве ");
PrintArray(numbers);
Console.Write($" сумма элементов, стоящих на нечётных позициях -> {SummOnOddIndex(numbers)}\n");

int SummOnOddIndex(int[] arr)
{
  int summ = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 != 0)
    {
      summ = summ + arr[i];
    }
  }
  return summ;
}


void PrintArray(int[] array)
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



void FillArray(int[] array)
{
  Random randGeneration = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = randGeneration.Next(0, 20);
  }
}

