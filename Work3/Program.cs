Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.WriteLine($"{a} == max");
else if (b > a && b > c)
    Console.WriteLine($"{b} == max");
else if (c > a && c > b)
    Console.WriteLine($"{c} == max");
else 
    Console.WriteLine("Значения равны");
