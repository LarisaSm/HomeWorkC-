int size = 5;
int[] numbers = new int[size];
FillArray(numbers);

Console.Write($"В массиве ");
PrintArray(numbers);
Console.Write($"четных чисел {CountOfEven(numbers)}\n");


int CountOfEven(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

void FillArray(int[] array)
{
  Random randGeneration = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = randGeneration.Next(100, 1000);
  }
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