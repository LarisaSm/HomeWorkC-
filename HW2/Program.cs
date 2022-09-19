Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
  max = number2;
}
if (max < number3)
{
  max = number3;
}
Console.WriteLine($"Максимальное число: {max}");

