// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int length, int min, int max) //создание массива

{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)

        Console.Write($"{array[i]} ");
    Console.WriteLine();

}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    
    }
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях =" + sum);
    return sum;
}

int[] array = CreateArray(15, -100, 100);
PrintArray(array);
FindSum(array);

