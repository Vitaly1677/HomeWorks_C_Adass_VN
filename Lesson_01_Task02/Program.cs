// Задача 2: Напишите программу, которая на вход 
// принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите 1-е число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число больше второго {firstNumber} > {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Второе число больше первого {secondNumber} > {firstNumber}");
}
else
{
    Console.WriteLine($"Первое число равно второму {firstNumber} = {secondNumber}");
}
