Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

int numberInt = int.Parse(number);
int i = 1;

while (i <= numberInt)
{
  if (i % 2 == 0)
  {
    Console.Write($"{i} ");
  }

  i++;

}
