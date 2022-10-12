

int[,,] martixA = new int[2, 2, 2];

FillArray(martixA);
System.Console.WriteLine();
FillPrint.FillPrint.PrintMassive(martixA);



void FillArray(int[,,] array)
{
  Random randGeneration = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        bool flag = true;
        while (flag)
        {
          int digit = randGeneration.Next(10, 100);
          if (!IsMatrixContain(array, digit, i))
          {
            array[i, j, k] = digit;
            flag = false;
          }
        }
      }
    }
  }
}

bool IsMatrixContain(int[,,] array, int digit, int i)
{
  bool contain = false;
  for (int m = 0; m < i; m++)
  {
    for (int l = 0; l < array.GetLength(1); l++)
    {
      for (int n = 0; n < array.GetLength(2); n++)
      {

        if (array[m, l, n] == digit) contain = true;

      }
    }
  }
  return contain;
}