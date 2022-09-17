/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 

Console.Clear();
Console.WriteLine("Найдите сумму натуральных элементов в промежутке от M до N");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {FindSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// int FindSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + FindSum(m, n - 1);
// }

int FindSum(int m, int n) 
{
    if(m > n) 
    {
        return 0;
    }
    return m + FindSum(m + 1, n);
}