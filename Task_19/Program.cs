Console.Clear();
Console.WriteLine("Программа принимает пятизначное число и" +
                  " проверяет является ли оно палиндромом.");
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 9999 || number > 99999)
    Console.WriteLine("Вы ввели не пятизначное число.");
else if (number / 10000 == number % 10 &&
         number / 1000 % 10 == number / 10 % 10)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
    