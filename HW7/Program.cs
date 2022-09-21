string[] array = { "рабочий", "рабочий", "рабочий", "рабочий", "рабочий", "выходной!", "выходной!" };
int number;

while (true)
{
  Console.Write("Введите цифру дня недели: ");
  number = int.Parse(Console.ReadLine()!);
  if (number <= array.Length - 1) break;

  Console.WriteLine("\nВ неделе всего 7 дней, введите пожалуйста корректное значение\n");
}

Console.WriteLine($"\n{number} день недели - это {array[number - 1]} день\n");

