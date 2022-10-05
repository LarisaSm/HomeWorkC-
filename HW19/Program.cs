Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(F(b1, k1, b2, k2));

(double, double) F(int b1, int k1, int b2, int k2)
{
  double x = (double)(b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;

  return (x, y);
}