// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray( int length, int min, int max) //создание массива
{
    int[] array = new int [length];
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(min, max+1);
        if (i>=100) Console.Write(", ");
    }
    return array;
}  

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
        
        Console.Write($"{array[i]} ");
   
   Console.WriteLine(); 
}

int FindEvenNumArray(int[] arr) //подсчет количества четных элементов массива
{
    int Length = 0;
 
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            Length++;
 
    return Length;
}

int[] array = CreateArray(100, 100, 999);
PrintArray(array);
Console.WriteLine($"Количество четных элементов массива равно {FindEvenNumArray(array)}");