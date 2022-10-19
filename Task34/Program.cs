// Задайте масив заполненный случайными трехзначнымиположительными числами
// Напишите программу, которая покажет число четных чисел в массиве

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

int[] RandomArray(int arrayLength, int minValue, int maxValue)
{
    int[] randomArray = new int[arrayLength];
    for (int index = 0; index < arrayLength; index++)
    {
        randomArray[index] = new Random().Next(minValue, maxValue + 1);
    }

    return randomArray;

}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.Write($"{array[array.Length - 1]}]");
}

int GetEven(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            count++;
    }
    return count;
}



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
int[] array = RandomArray(length, 100, 999);
PrintArray(array);
int count = GetEven(array);
Console.WriteLine($" -> {count}");