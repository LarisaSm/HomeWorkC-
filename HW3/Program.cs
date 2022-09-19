Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int numberInt = int.Parse(number);

if (numberInt % 2 == 0)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}
