Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.Write("max = {0} min = {1}", a, b);
else Console.Write("max = {0} min = {1}", b, a);