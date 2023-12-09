using System;

class Program
{
    public static void Main(string [] arg)
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();
        int N = Int32.Parse(input);
        int number = 0;
        int result = 0;
        while (number <= N)
{
if (N == 0)
{
break;
}
result += number;
number++;
}
        Console.WriteLine($"Сумма чисел от 0 до {N} равна {result}");
        Console.WriteLine(GetSummaRec(N));
    }

    public static int GetSummaRec(int N)
    {
        if(N == 0)
        {
            return 0;
        }
        return N + GetSummaRec(N - 1);
    }
}