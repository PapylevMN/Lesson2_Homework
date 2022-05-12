Console.Write("Введите номер дня недели : ");
int day = int.Parse(Console.ReadLine());
bool res = day == 7 || day == 6;
Console.WriteLine(res? "Да" : "Нет");