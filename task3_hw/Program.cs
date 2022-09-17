/*Задача 68: Задайте значения M и N. 
Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7 */

Console.Clear();
Console.WriteLine("Найдите наибольший общий делитель чисел M и N");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Наибольший общий делитель чисел {m} и {n} равен {GreatestCommonDenominator(m, n)}");

int GreatestCommonDenominator(int m, int n)
{
    if (n == 0)
        return m;
    else
        return GreatestCommonDenominator(n, m % n);
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
