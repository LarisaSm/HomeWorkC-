internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int[] elements = new int[number];

    while (true)
    {
      Console.Write($"Введите {number} цифр через запятую: ");
      elements = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();
      if (elements.Length == number) break;
      Console.WriteLine($"Нужно ввести {number} чисел через запятую");
    }

    PrintMassive(elements);
    System.Console.WriteLine();

    System.Console.WriteLine(FindSum(elements));

    int FindSum(int[] elements)
    {
      int count = 0;
      for (int i = 0; i < elements.Length; i++)
      {
        if (elements[i] > 0) count++;
      }
      return count;
    }
  }



  #region Fill&Print 
  // class FP
  // {


  static void FillArray(int[] array, int min, int max)
  {
    Random randGeneration = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = randGeneration.Next(min, max++);
    }
  }

  static void FillArray(double[] array)
  {
    Random randGeneration = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Math.Round(randGeneration.NextDouble() * 20, 2);
    }
  }


  static void PrintMassive(double[] array)
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

  static void PrintMassive(int[] array)
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

  static void PrintMassive(int[,] array)
  {
    Console.Write("[");
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
                                              // или так
                                              // int columns = numbers.GetUpperBound(1) + 1;

    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        Console.Write($"{array[i, j]} \t");
      }
      Console.WriteLine();
    }
    Console.Write("]");
  }
  // }
  #endregion
}