// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string AllNumbers(int num)
{
    string res = Convert.ToString(num);
    if (num == 1) return res;
    return res + ", " + AllNumbers(num - 1);
}



int num = Promt("Enter a number:");
System.Console.WriteLine(AllNumbers(num));
