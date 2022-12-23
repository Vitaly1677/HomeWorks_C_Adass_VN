// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6

Console.Write("Введите число, для отображения 3-ей цифры: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(ThirdNumberWrite(number) != -1 ? $"{number} -> {ThirdNumberWrite(number)}" : "А третьей цифры то нет... :)");
int ThirdNumberWrite(int num1)
{
    if (num1 > 999)
    {
        while (num1 > 999)
        {
            num1 = num1 / 10;
        }
        return num1 % 10;
    }
    else if (num1 > 99)
    {
        return num1 % 10;
    }
    else
    {
        return -1;
    }


}