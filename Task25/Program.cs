// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень числа В
// 3, 5 -> 243 
// 2, 4 -> 16

int EnterNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numberA = EnterNum("Введите число А: ");
int numberB = EnterNum("введите число В: ");
int n = 1;
int result = 1;
for (n = 1; n <= numberB; n++)
   {
       result = result * numberA;   
   }

Console.WriteLine($"число {numberA} в степени числа {numberB} равно {result} ");