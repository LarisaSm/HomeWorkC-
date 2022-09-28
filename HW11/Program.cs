Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень В: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine(Power(numberA, numberB));

int Power(int a, int b)
{
  int res = 1;
  for (int i = 1; i <= b; i++)
  {
    res = res * a;
  }
  return res;
}