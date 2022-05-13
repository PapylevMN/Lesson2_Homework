Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int res = 0;
if (num < 100 && num > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (Math.Abs(num) > 99)
    {
        res = Math.Abs(num) % 10;
        num = Math.Abs(num) / 10;
    }
    Console.WriteLine(res);
}