// Напишите программу, которая задаёт массив из 8 элементов 
// с клавиатуры и выводит массив на экран.

Console.Write("Введите колличество элементов массива (x): ");
int Num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Num];

for (int i = 0; i < Num; i++)
{
    array[i] = new Random().Next(Num + 1);
    Console.Write(array[i] + "; ");
}
//Console.WriteLine();


