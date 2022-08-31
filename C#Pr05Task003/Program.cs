// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray(int length, int min, int max)  // создает массив, заполняет его рандомно
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*(max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

double FindDifference(double[] array) //  сравнивает максимальное значение с минимальным
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double difference = max - min;
    return difference;
}

void PrintArray(double[] array) // выводит массив на консоль
{
    for (int i = 0; i < array.Length; i++)
        
        Console.Write($"{array[i]} ");
   
   Console.WriteLine();    
}



double[] array = CreateArray(15, -100, 100);
PrintArray(array);
double difference = FindDifference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
