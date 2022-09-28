Console.Write("Введите числа через запятую: ");
int[] masA = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

Console.WriteLine(String.Join(",", masA));
