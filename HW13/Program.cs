Console.Write("Введите числа через запятую: ");
int[] massive = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

Console.WriteLine(String.Join(",", massive));
