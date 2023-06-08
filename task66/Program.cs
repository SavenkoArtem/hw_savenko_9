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

int SumNumbers(int num1, int num2)
{    
    if (num2 == num1) return num2;
    return num2 + SumNumbers(num1, num2 - 1);
}

int num1 = Promt("Enter a number 1:");
int num2 = Promt("Enter a number 2:");
System.Console.WriteLine(SumNumbers(num1, num2));