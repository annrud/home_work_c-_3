Console.Clear();
Console.WriteLine("Программа принимает на вход число N и " +
                  "выдает таблицу кубов чисел от 1 до N");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
    
void PowNumber(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        Console.Write(Math.Pow(i, 3));
        if (i != numb)
            Console.Write(", ");
        else
        {
            Console.WriteLine();
        }
    }
}

PowNumber(number);    