Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

int b = number % 100 / 10;
Console.WriteLine(b);