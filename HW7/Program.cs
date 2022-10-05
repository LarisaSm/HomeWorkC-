string[] week = { "рабочий", "рабочий", "рабочий", "рабочий", "рабочий", "выходной!", "выходной!" };
int day;

while (true)
{
  Console.Write("Введите цифру дня недели: ");
  day = int.Parse(Console.ReadLine()!);
  if (day <= week.Length - 1) break;

  Console.WriteLine("\nВ неделе всего 7 дней, введите пожалуйста корректное значение\n");
}

Console.WriteLine($"\n{day} день недели - это {week[day - 1]} день\n");

