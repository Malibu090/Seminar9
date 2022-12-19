// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int OutputPower(int number, int power)
{
    if (power == 1) return number;
    return (number * OutputPower(number, power - 1));
}
// Вывод натуральных чисел от M до N

int number = EnterNumber("Input number: ");
int power = EnterNumber("Input power: ");
Console.WriteLine(OutputPower(number, power));