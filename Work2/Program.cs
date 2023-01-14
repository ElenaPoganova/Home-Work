Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"{a} == max {b} == min");
else if (a < b)
    Console.WriteLine($"{a} == min {b} == max");
else 
    Console.WriteLine($"{a} = {b}");