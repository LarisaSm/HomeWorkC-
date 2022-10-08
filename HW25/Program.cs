
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Первые {N} чисел Фибоначчи:");
FillPrint.FillPrint.PrintMassive(Fibonachi(N));
System.Console.WriteLine();

double[] Fibonachi(int number)
{
  double[] fibonachi = new double[N];
  fibonachi[0] = 0;

  if (number == 1) return fibonachi;
  else
  {
    fibonachi[1] = 1;

    for (int i = 2; i < number; i++)
    {
      fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
    }
  }
  return fibonachi;
}