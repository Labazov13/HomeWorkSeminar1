Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число");
int d = int.Parse(Console.ReadLine()!);

if (a > b & a > d)
{
    Console.WriteLine("Большее число a, равное " + a);
}
else if (b > a & b > d)
{
    Console.WriteLine("Большее число b, равное " + b);
}
else
{
    Console.WriteLine("Большее число d, равное " + d);
}
