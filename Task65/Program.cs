// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string OutputNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return m.ToString();
    }
    return (m + ", " + OutputNaturalNumbers(m + 1, n));
}
// Вывод натуральных чисел от M до N

int m = EnterNumber("Input m: ");
int n = EnterNumber("Input n: ");
Console.WriteLine(OutputNaturalNumbers(m, n));
