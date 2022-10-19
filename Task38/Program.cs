// Задайте массив вещественных чисел инайдите разницу между максимальным и минимальным элементом

int GetUserNumber(string message, string errorMess)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMess);
    }
}

double[] RandomArray(int arrayLength)
{
    double[] randomArray = new double[arrayLength];
    for (int index = 0; index < arrayLength; index++)
    {
        randomArray[index] = new Random().NextDouble() * 10;
    }

    return randomArray;

}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]}, ");
    Console.Write($"{array[array.Length - 1]}] -> ");
}


double GetMinEl (double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMaxEl (double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}



///////////////////////////////////////
Console.Clear();

int length;
Console.Clear();
while (true)
{
    length = GetUserNumber("Введите количество элементов массива: ", "Ошибка ввода!");
    if (length > 0)
        break;
    else
        Console.WriteLine("Ошибка!");
}

double[] array = RandomArray(length);

PrintArray(array);

double maxEl = GetMaxEl(array);
double minEl = GetMinEl(array);

Console.WriteLine(maxEl - minEl);