// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int FindAckerman(int m, int n)
{    
    if (m == 0) return n + 1;
    if (n == 0) return FindAckerman(m - 1, 1);
    return FindAckerman(m - 1, FindAckerman(m, n - 1));
}

int m = Promt("Enter a number m:");
int n = Promt("Enter a number n:");
System.Console.WriteLine(FindAckerman(m, n));