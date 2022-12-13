// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int EnterNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int n = EnterNum("Введите число: ");

int result = 0;
int res = n % 10;
for ( ; n / 10; )
{
    result = res + n % 10;
}

Console.WriteLine($"Сумма цифр в числе {n} равна {result} ");