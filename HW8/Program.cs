Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 10000 || number > 99999)
{
  Console.WriteLine("Для корректной работы программы необходимо ввести 5-ти значное число.");

}
else
{
  if ((number % 10 == number / 10000) && (number / 1000 % 10 == number / 10 % 10))
  {
    Console.WriteLine("Ваше число {0} является палиндромом", number);
  }
  else Console.WriteLine("Ваше число {0} НЕ палиндром", number);
}

