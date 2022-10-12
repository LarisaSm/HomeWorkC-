
Random generator = new Random();

int[,] numbers = new int[generator.Next(4, 8), generator.Next(4, 8)];

FillPrint.FillPrint.FillArray(numbers);
FillPrint.FillPrint.PrintMassive(numbers);

SortMatrix(numbers);
System.Console.WriteLine();
FillPrint.FillPrint.PrintMassive(numbers);


void SortMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {


    for (int j = 0; j < matrix.GetLength(1); j++)
    {


      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        int nextK = k + 1;
        if (matrix[i, k] < matrix[i, nextK])
        {
          (matrix[i, k], matrix[i, nextK]) = (matrix[i, nextK], matrix[i, k]);
        }
      }
    }
  }
}