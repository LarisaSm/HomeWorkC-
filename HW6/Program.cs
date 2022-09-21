Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

var list = new List<int>();
int index = number;
while (index != 0)
{
  list.Add(index % 10);
  index /= 10;
}

if (list.Count > 2)
  Console.WriteLine($"Третья цифра из {number} - это {list[list.Count - 3]}");
else
  Console.WriteLine("В вашем числе {0} нет третьей цифры", number);

