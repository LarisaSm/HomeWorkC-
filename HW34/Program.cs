Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);
PrintAllNatural(m, n);

void PrintAllNatural(int m, int n, int sum = 0)
{

  if (n < m)
  {
    System.Console.WriteLine($"Сумма всех натуральных элементов = {sum} ");
    return;
  }
  sum = sum + n;

  n--;
  PrintAllNatural(m, n, sum);
}
