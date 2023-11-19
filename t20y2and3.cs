//Урок 2
Random r = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(21);
    Console.WriteLine(mas[i] + " ");

}

double value(int[] mas)
{
    double value = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        value += mas[i];
    }
    value /= mas.Length;
    return value;
}
Console.WriteLine($"AVG = {value(mas):f2}");

//Урок 3

Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine());
Console.WriteLine("выберите операцию:\n[0] - логическое сложение \n[1] - логическое умножение \n[2] - шифрование\n[3] - инверсия");
int operation = int.Parse(Console.ReadLine());
long Foo(long x, long y)
{
    long res = 0;
    switch (y)
    {
        case 1:
            {
                res = x | x;
            }
            break;
        case 2:
            {
                res = x & x;
            }
            break;
        case 3:
            {
                Console.WriteLine("Введите пароль");
                int password = int.Parse(Console.ReadLine());
                res = x >> key;
            }
            break;
        case 4:
            {
                res = ~x;
            }
            break;
    }
    return res;
}

Console.WriteLine(Foo(number, operation));