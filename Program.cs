/*Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите число - размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] RandomArray()
{
    int[] array = new int[num];
    Random rnd = new Random();

    for (int i = 0; i < num; i++)
        array[i] = rnd.Next(100, 1000);

    return array;
}
//создаем массив из случайных трёхзначных чисел  

void PrintArray(int[] array)
{

    for (int i = 0; i < num; i++)
        Console.Write($"{array[i]} ");
}
// напечатать массив

int EvenNum(int[] array)
{
    int counter = 0;
    for (int i = 0; i < num; i++)
        if (array[i] % 2 == 0)
            counter++;
    return counter;
}
//считаем количество чётных чисел

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine("");
int counter = EvenNum(array);
Console.WriteLine($"ЧЁТНЫХ ЧИСЕЛ --->>> {counter}");
