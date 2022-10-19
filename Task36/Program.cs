// Задайте массив и найдите сумму элементов, стоящих на нечётныъ позициях


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
    Console.Write($"{array[array.Length - 1]}] -> ");
}

int GetSumElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            count += array[i];
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
int minValue = GetUserNumber("Введите значение минимального элемента массива: ", "Ошибка ввода!");
int maxValue = GetUserNumber("Введите значение максимального элемента массива: ", "Ошибка ввода!");
int[] array = RandomArray(length, minValue, maxValue);
PrintArray(array);
int sum = GetSumElements(array);
Console.WriteLine(sum);