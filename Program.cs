// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = UserNumber("Введите число: ", "Ошибка ввода! ");

string res = Nums(n, 1);
Console.WriteLine(res);

int UserNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
        return num;
        Console.Write(errormessage);
    }
}

string Nums (int n, int min)
{
    if (n == min) return n.ToString();
    return n + " " + Nums(n-1, min);
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int m = UserNumber("Введите минимальное число: ", "Ошибка ввода! ");
int n = UserNumber("Введите максимальное число: ", "Ошибка ввода! ");
int res = GetSum(m,n);
Console.WriteLine(res);

int UserNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
        return num;
        Console.Write(errormessage);
    }
}

int GetSum(int min, int max)
{
    if(min==max) return max;
    return min + GetSum(min+1,max);
}


// Задача 68:Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int m = UserNumber("Введите минимальное число: ", "Ошибка ввода! ");
int n = UserNumber("Введите максимальное число: ", "Ошибка ввода! ");
int res = Akkerman(m,n);
Console.WriteLine($"Функция Аккермана равнa {res}");

int UserNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
        return num;
        Console.Write(errormessage);
    }
}
int Akkerman(int m, int n)
{
    if(m==0) return n+1;
    if(n==0) return Akkerman(m-1,1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}