Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(Summ(number));

int Summ(int a)
{
  a = Math.Abs(a);
  int res = 0;
  while (a > 0)
  {
    res = res + a % 10;
    a = a / 10;
  }
  return res;
}