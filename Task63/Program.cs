// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// 
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
    return (m + " " + OutputNaturalNumbers(m + 1, n));
}
// Вывод натуральных чисел от 1 до N

int n = EnterNumber("Input n: ");
Console.WriteLine(OutputNaturalNumbers(1, n));
