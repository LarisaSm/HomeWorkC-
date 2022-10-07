namespace FillPrint
{
  class FillPrint
  {
    public static void FillArray(int[] array, int min, int max)
    {
      Random randGeneration = new Random();
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = randGeneration.Next(min, max++);
      }
    }

    public static void FillArray(double[] array)
    {
      Random randGeneration = new Random();
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = Math.Round(randGeneration.NextDouble() * 20, 2);
      }
    }
    public static void FillArray(double[,] array)
    {
      Random randGeneration = new Random();
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = Math.Round(randGeneration.NextDouble() * 20, 2);
        }

      }
    }
    public static void FillArray(int[,] array, int min, int max)
    {
      Random randGeneration = new Random();
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = randGeneration.Next(min, max++);
        }
      }
    }

    public static void PrintMassive(double[] array)
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

    public static void PrintMassive(int[] array)
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

    public static void PrintMassive(int[,] array)
    {
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
    }
    public static void PrintMassive(double[,] array)
    {
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
    }
  }
}