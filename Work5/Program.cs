Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n / n;
while (m <= n)
{
   if (m % 2 == 0)
    Console.Write($"{m}");
    m = m + 1;
}