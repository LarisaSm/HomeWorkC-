using FillPrint;


internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Введите значение m: ");
    int numberM = int.Parse(Console.ReadLine()!);
    Console.Write("Введите значение n: ");
    int numberN = int.Parse(Console.ReadLine()!);

    double[,] doubleArray = new double[numberM, numberN];

    FillPrint.FillPrint.FillArray(doubleArray);
    FillPrint.FillPrint.PrintMassive(doubleArray);
  }
}