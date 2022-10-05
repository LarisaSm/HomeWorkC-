Console.WriteLine("Введите координаты точки А через \",\": ");
// int number = int.Parse(Console.ReadLine()!);

int[] pointA = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

Console.WriteLine("Введите координаты точки B через \",\": ");
int[] pointB = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

if (pointA.Length == 3 && pointB.Length == 3)
{
  double d = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2)
                      + Math.Pow(pointA[1] - pointB[1], 2)
                      + Math.Pow(pointA[2] - pointB[2], 2));
  Console.WriteLine("Расстояние между точкой А с координатами {0},{1},{2}"
                    + " и точкой В с координатами  {3},{4},{5}  = {6}"
                    , pointA[0], pointA[1], pointA[2],
                    pointB[0], pointB[1], pointB[2],
                    d.ToString("#.##"));
}
else
{
  Console.WriteLine("Введите корректные координаты для двух точек");
}