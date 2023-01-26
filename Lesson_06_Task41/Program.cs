// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = ReadIntNumder("Bведите колличество вводимых чисел: ");
int[] array = new int[count];
array = ReadNumberToArray(count);
PrintArray(array);
int countPositiveNumbers = CountPositiveNumbersArray(array);
Console.WriteLine(" -> " + countPositiveNumbers);

int[] ReadNumberToArray(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = ReadIntNumder("Введите число массива N " + (i + 1) + " из " + count + ": ");
    }
    return arr;
}

int ReadIntNumder(string ParamName)
{
    Console.Write(ParamName);
    return Convert.ToInt32(Console.ReadLine());
}

bool PositiveNumber(int num)
{
    return num > 0;
}

int CountPositiveNumbersArray(int[] arr)
{
    int cou = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (PositiveNumber(arr[i])) cou++;
    }
    return cou;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
}