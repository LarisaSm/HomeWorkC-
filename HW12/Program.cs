Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(SummOfDigit(number));

int SummOfDigit(int number)
{
  number = Math.Abs(number);
  int res = 0;
  while (number > 0)
  {
    res = res + number % 10;
    number = number / 10;
  }
  return res;
}