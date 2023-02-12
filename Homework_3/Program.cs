//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число a: ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b =int.Parse(Console.ReadLine());
int p = 1;
for (int i = a; i <=b; i++)
{
    p = p * i;
}

Console.WriteLine("Произведения: " +p);