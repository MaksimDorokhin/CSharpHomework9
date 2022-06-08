// Показать натуральные числа от M до N, N и M заданы
void PrintNumber(int min, int max)
{
    if (max < min)
    {
        Console.WriteLine();
        return;
    }
    Console.Write(min + " ");
    PrintNumber(min + 1, max);
}
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (m > n)
{
    Console.WriteLine("Число M больше числа N, меняем их местами");
    int tmp = m; m = n; n = tmp;
}
Console.WriteLine("Диапазон чисел:");
PrintNumber(m, n);