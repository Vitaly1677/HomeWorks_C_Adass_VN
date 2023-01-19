// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countNumbers = CountNumbers(number);
Console.WriteLine($"Количество чисел в {number} -> {countNumbers}");
int CountNumbers(int num)
{
    if (num == 0) return 1;
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
