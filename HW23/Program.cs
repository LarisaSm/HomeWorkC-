using FillPrint;


Console.Write("Введите позицию искомого элемента через пробел (строка столбец): ");
int[] searchIndex = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();


Random generator = new Random();
int rows = generator.Next(1, 10);
int columns = generator.Next(1, 10);

int[,] numbers = new int[rows, columns];

System.Console.WriteLine($"Массив [{rows}, {columns}]:");
FillPrint.FillPrint.FillArray(numbers, 1, 9);
FillPrint.FillPrint.PrintMassive(numbers);
System.Console.WriteLine();
SearchIndex(numbers, searchIndex);



void SearchIndex(int[,] array, int[] index)
{

  if (index[0] > 0 && index[1] > 0
  && index[0] < array.GetLength(0)
  && index[1] < array.GetLength(1))
  {
    System.Console.WriteLine($"Элемент с индексом [{index[0]}, {index[1]}] = {array[index[0], index[1]]}");
  }
  else System.Console.WriteLine($"Элемента с индексом [{index[0]}, {index[1]}] не существует");

}
