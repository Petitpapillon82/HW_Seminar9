/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

Console.Clear();
Console.WriteLine("Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
Console.WriteLine(EvenNumbers(m, n));
int EvenNumbers(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0 && m != 0)
        {
            Console.Write($"{m}, ");  
        }
        EvenNumbers(m + 1, n);
	}
    return 0;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

//ВАРИАНТ ОТ ПРЕПОДАВАТЕЛЯ:
// EvenNumbers(m, n);
// void EvenNumbers(int m, int n)
// {
// string delimiter = m == n || m == n - 1 ? "" : ",";
// if (m <= n)
// {
// if (m % 2 == 0 && m != 0)
// {
// Console.Write($"{m}{delimiter} ");

// }
// EvenNumbers(m + 1, n);
// }
// }