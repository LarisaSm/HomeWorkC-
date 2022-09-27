Console.WriteLine("Введите координаты точки А через \",\": ");
// int number = int.Parse(Console.ReadLine()!);

int[] masA = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

Console.WriteLine("Введите координаты точки B через \",\": ");
int[] masB = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

if (masA.Length == 3 && masB.Length == 3)
{
  double d = Math.Sqrt(Math.Pow(masA[0] - masB[0], 2) + Math.Pow(masA[1] - masB[1], 2) + Math.Pow(masA[2] - masB[2], 2));
  Console.WriteLine("Расстояние между точкой А с координатами {0},{1},{2} и точкой В с координатами  {3},{4},{5}  = {6}", masA[0], masA[1], masA[2], masB[0], masB[1], masB[2], d.ToString("#.##"));
}
else
{
  Console.WriteLine("Введите корректные координаты для двух точек");
}