Console.Write("Введите элементы(цифры или  буквы) через запятую: ");
string[] elements = Console.ReadLine()!.Split(",").ToArray(); ;

int[] result = Find(elements);
Console.Write("В наборе элементов: ");
PrintArray(elements);

Console.Write($"\n количество элементов самой длинной последовательности - {result[0]} ,"
             + $" \n элемент этой последовательности - {elements[result[1]]}, "
             + $"\n номер элемента, который является началом последовательности - {result[1]} \n");


int[] Find(string[] str)
{
  int size = str.Length;
  int count = 0;
  int[,] result = new int[size, 2];
  int countResult = 0;
  //0 - количество элементов самой длиной последовательности
  //1 - номер элемента, который является ее началом
  for (int i = 1; i < str.Length; i++)
  {
    if (str[i] == str[i - 1])
    {
      if (count == 0) result[countResult, 1] = i - 1;
      count++;
      result[countResult, 0] = count + 1;
    }
    else
    {
      count = 0;
      countResult++;
    }
  }
  int maxIndex = FindMax(result);
  int[] resultResult = { result[maxIndex, 0], result[maxIndex, 1] };
  return resultResult;
}

int FindMax(int[,] arr)
{
  int max = arr[0, 0];
  int maxIndex = 0;
  int rows = arr.GetUpperBound(0) + 1;
  for (int i = 1; i < rows; i++)
  {
    if (arr[i, 0] > max)
    {
      max = arr[i, 0]; maxIndex = i;
    }
  }
  return maxIndex;
}

void PrintArray(string[] array)
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


