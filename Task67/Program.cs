// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int OutputSumOfDigits(int number)
{
    if (number < 10)
    {
        return number;
    }
    return number % 10 + OutputSumOfDigits(number / 10);
}
// Вывод натуральных чисел от  до N

int number = EnterNumber("Input number: ");
Console.WriteLine(OutputSumOfDigits(number));
