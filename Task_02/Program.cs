/*Совместная работа
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
Указание
Использовать рекурсию.
Пример
123 => 6
63 => 9*/

System.Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

/*int Summa = 0;
while(true)
{
    if(n == 0) break;

    Summa+= n%10;
    n = n/10;
}
System.Console.WriteLine(Summa);*/

int SumRec(int n)
{
    if(n == 0)
        return 0;
    return (n%10 + SumRec(n/10));
}

System.Console.WriteLine(SumRec(n));
