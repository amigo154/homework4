// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("vvedite chislo: "); // 
int num = int.Parse(Console.ReadLine());

int GetCountSum(int number)  // функция
{
    int sum = 0;
    int c = 0;
    while (number > 0)
    {
        c = number % 10;
        sum += c;
        number /= 10;
    }
    return sum;
}

int function = GetCountSum(num); // вызвали функцию
Console.WriteLine($"сумма цифр в числе {num} равна {function}");
