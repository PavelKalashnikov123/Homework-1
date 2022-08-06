Console.WriteLine("Введите два числа и мы скажем какое больше");

int a, b;

Console.WriteLine("Введите первое число -");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число -");
b = Convert.ToInt32(Console.ReadLine());

bool number0 = a > b;
bool number1 = a == b;
bool number2 = a < b;

if (number0)
{
    Console.WriteLine($"число {a} больше чем {b}");
}
else if (number1)
{
    Console.WriteLine($"числа {a} и {b} равны");
}
else
{
    Console.WriteLine($"число {b} больше чем {a}");
}