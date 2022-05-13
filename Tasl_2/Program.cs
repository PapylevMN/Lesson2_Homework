Console.Write("Введите число : ");
string s = Console.ReadLine();
if (s.Length < 3) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(s[2]);
