// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 100);
}
//for (int i = 0; i < 8; i++)
//{
//    Console.Write($"{array[i]}");
//}


Console.WriteLine($"[{string.Join(", ", array)}]");
