Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
max = a;
if (a > b)
{
    max = a;
}
else (max = b);
if (b > c)
{
    Console.Write(max);
}
else (max = c);
Console.Write(max);