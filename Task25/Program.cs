// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int B = Convert.ToInt32(Console.ReadLine());

int c = 1;
for (int i = 1; i <= B; i++)
{
    c = c * A;
}
Console.WriteLine($"Введенное число {A} в степени {B} будет равно {c}");
