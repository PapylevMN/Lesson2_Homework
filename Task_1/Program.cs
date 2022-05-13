Console.Write("Введите трехзначное число : ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Abs(num % 100 / 10));