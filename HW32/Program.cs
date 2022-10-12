Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

int[][] pascaleArray = new int[N][];
FillPascal(pascaleArray);
PrintPascal(pascaleArray);

void PrintPascal(int[][] pascal)
{
  int left = Console.CursorLeft;
  int top = Console.CursorTop;
  for (int i = 0; i < pascal.Length; i++)
  {
    top++;
    left = 2 * N - 2 * i;
    Console.SetCursorPosition(left, top);
    for (int j = 0; j < pascal[i].Length; j++)
    {
      System.Console.Write($" {pascal[i][j]}  ");
    }
    System.Console.WriteLine();
  }
}

void FillPascal(int[][] pascaleArray)
{
  pascaleArray[0] = new int[] { 1 };

  for (int i = 1; i < N; i++)
  {
    pascaleArray[i] = new int[i + 1];

    for (int j = 0; j < i + 1; j++)
    {
      int parent1;
      int parent2;

      try
      {
        parent1 = pascaleArray[i - 1][j];
      }
      catch
      {
        parent1 = 0;
      }

      try
      {
        parent2 = pascaleArray[i - 1][j - 1];
      }
      catch
      {
        parent2 = 0;
      }
      pascaleArray[i][j] = parent1 + parent2;


    }
  }
}