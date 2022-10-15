Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
PrintAllNatural(N);

void PrintAllNatural(int n)
{

  if (n == 1)
  {
    System.Console.Write($" {n} ");
    return;
  }

  System.Console.Write($" {n} ");
  n--;
  PrintAllNatural(n);
}
