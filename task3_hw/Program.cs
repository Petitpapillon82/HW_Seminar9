/*Задача 68: Задайте значения M и N. 
Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7 */

Console.Clear();
Console.WriteLine("Найдите наибольший общий делитель чисел M и N");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Наибольший общий делитель чисел {m} и {n} равен {nod(m, n)}");

int nod(int m, int n)
{
    if (n == 0)
        return m;
    else
        return nod(n, m % n);
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
