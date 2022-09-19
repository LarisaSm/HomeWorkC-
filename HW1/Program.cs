Console.WriteLine("Введите первое число: ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string number2 = Console.ReadLine();

int number1Int = int.Parse(number1);
int number2Int = int.Parse(number2);

if (number1Int > number2Int)
{
  Console.WriteLine($"max = {number1Int}, min = {number2Int}");
}
else if (number1Int < number2Int)
{
  Console.WriteLine($"max = {number2Int}, min = {number1Int}");
}
else
{
  Console.WriteLine("Числа равны");
}