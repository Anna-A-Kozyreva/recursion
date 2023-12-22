//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    if (start > end) return 0.ToString();
    return start + " " + PrintNumbers(start + 1, end);
}
Console.WriteLine($"Числа от {M} до {N} = {PrintNumbers(M, N)}");

//Напишите программу вычисления функции
//Аккермана с помощью рекурсии. Даны два
//неотрицательных числа m и n. 

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine($"{Ack(3, 2)}");

//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 1, 5, 4, 3, 2, 6, 7, 9, 8 };

int j = array.Length - 1;

void ShowArrReversed(int[] arr, int j)
{
    if (j < 0)
    {
        return;
    }
    Console.Write($"{arr[j]} ");
    ShowArrReversed(arr, j - 1);
}
ShowArrReversed(array, j);