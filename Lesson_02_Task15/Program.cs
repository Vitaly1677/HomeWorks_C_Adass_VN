// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите номер дня недели, для определения выходного дня: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{day} -> {Weekend(day)}");
string Weekend(int nom)
{
    if (nom <= 7 && nom >= 1)
    {
        if (nom == 6 || nom == 7) return "Да";
        else return "Нет";
    }
    else return "Нет такого дня недели, он только в Ваших мечтах.";
}