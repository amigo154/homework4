// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int [] array = GetArray(8);
Console.WriteLine($"[ {String.Join(", ", array)}]");

int [] GetArray(int size)
{
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(-50, 50);
    }
    return result;
}
