using System.Runtime.CompilerServices;

int m = int.Parse(Console.ReadLine()); // пользователь вводит значеине перемнной m
double n = double.Parse(Console.ReadLine()); // пользователь вводит значеине переменной n
double x; // объявление переменной x
double y; // объявление переменной y
double z; // объявление переменной z

if (m > 5) // m больше 5
{
    x = Math.Sin(m + n);
}
else // иначе...
    x = n + 5 * Math.Sqrt(m * n * n - 2.1 * n);

if (x <= 0) // x юольше или равно 0
{
    Math.Log(m * n + x);
}
else
    y = Math.Cos(m * x) * Math.Sin(n * x);

        z = (2 * x + 3 * 0)  / (m * m + 5); // вычисление z
