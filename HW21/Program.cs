Console.WriteLine("Среднее всех введеных чисел - " + Average());

double Average(int count = 0, int summ = 0)
{
  Console.Write("Введите значение: ");
  int number = int.Parse(Console.ReadLine()!);

  if (number == -1)
  {
    return (double)summ / count;
  }
  else
  {
    return Average(++count, summ + number);
  }
}