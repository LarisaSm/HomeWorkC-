
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(ConvertIntToBin(number));

string ConvertIntToBin(int number, string result = "")
{
  if (number < 2)
    return Convert.ToString(number % 2);
  else
  {
    return ConvertIntToBin(number / 2, result) + number % 2 + result;
  }
}