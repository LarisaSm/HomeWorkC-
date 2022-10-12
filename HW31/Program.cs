
Console.Write("Введите размер массива через пробел: ");
int[] sizeArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();


int[,] numbers = new int[sizeArray[0], sizeArray[1]];
FillPrint.FillPrint.FillArray(numbers);
FillPrint.FillPrint.PrintMassive(numbers);

int minElement = FindMinElement(numbers);
(List<int> row, List<int> column) = FindIndexOfMin(numbers, minElement);
System.Console.WriteLine();
System.Console.Write($"Минимальный элемент массива = {minElement} с индексами: ");
for (int i = 0; i < row.Count; i++)
{
  System.Console.Write($" ({row[i]},{column[i]}) ");
}
System.Console.WriteLine();
int[,] numbersDel = DeleteRowsColumns(numbers, minElement, row, column);
System.Console.WriteLine();
System.Console.WriteLine("Итоговый массив без строк и столбцов, содержащих минимальный элемент");
FillPrint.FillPrint.PrintMassive(numbersDel);


int FindMinElement(int[,] array)
{
  int min = array[0, 0];
  int minI = 0;
  int minJ = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < min)
      {
        min = array[i, j];
      }
    }
  }
  return min;
}

(List<int>, List<int>) FindIndexOfMin(int[,] array, int min)
{
  List<int> row = new List<int>();
  List<int> column = new List<int>();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == min)
      {
        // if (!row.Contains(i)) row.Add(i);
        // if (!column.Contains(j)) column.Add(j);
        row.Add(i); column.Add(j);
      }
    }
  }
  return (row, column);
}

int[,] DeleteRowsColumns(int[,] array, int min, List<int> rowIn, List<int> columnIn)
{

  List<int> row = new List<int>();
  List<int> column = new List<int>();

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == min)
      {
        if (!row.Contains(i)) row.Add(i);
        if (!column.Contains(j)) column.Add(j);
      }
    }
  }


  int rowResult = array.GetLength(0) - row.Count;
  int columnResult = array.GetLength(1) - column.Count;

  int[,] result = new int[rowResult, columnResult];
  int bisI = 0;
  int bisJ = 0;
  int n = 0;
  int m = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (row.Contains(i) || column.Contains(j)) continue;
      else
      {
        result[m, n] = array[i, j];
        if (n < columnResult - 1) n++;
        else
        {
          if (m < rowResult)
          {
            m++;
            n = 0;
          }
          else
          {
            i = array.GetLength(0);
            j = array.GetLength(1);
          }
        }
      }
    }
  }
  return result;
}