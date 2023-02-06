// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN >= 0 && numberM >= 0)
{
    Console.Write("m = " + numberM + "; n = " + numberN + " -> A(m,n) = ");
    Console.WriteLine(AkkermanFunc(numberM, numberN));
}
else Console.WriteLine("Числа m и n должны быть неотрицательными.");

int AkkermanFunc(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return AkkermanFunc(numM - 1, 1);
    else return AkkermanFunc(numM - 1, AkkermanFunc(numM, numN - 1));
}