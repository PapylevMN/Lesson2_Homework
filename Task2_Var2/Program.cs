Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int res = 0;
if (num<99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 99)
    {
        res = num % 10;
        num = num / 10;
    }
    Console.WriteLine(res);
}