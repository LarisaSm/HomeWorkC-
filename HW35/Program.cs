Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Akkerman(m, n));


int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Akkerman(m - 1, 1);

  return Akkerman(m - 1, Akkerman(m, n - 1));
}