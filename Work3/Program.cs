Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
while ( (a = b) || (b = c) || (a = c) )
{
    Console.Write("Числа равны между собой!\nВведите 1-ое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-ое число: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 3-е число: ");
    с = Convert.ToInt32(Console.ReadLine());
}
if (a > b && a > c)
    Console.WriteLine($"{a} == max");
else if (b > a && b > c)
    Console.WriteLine($"{b} == max");
else 
    Console.WriteLine($"{c} == max");
