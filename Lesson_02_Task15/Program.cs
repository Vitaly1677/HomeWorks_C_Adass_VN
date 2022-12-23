// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет
begin:
Console.Write("Введите номер дня недели, для определения выходного дня: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1)
{
    Console.WriteLine("Вы ввели не верный день недели, попробуйте еще раз.");
    goto begin;
}
Console.WriteLine(Weekend(day) ? "Да" : "Нет");

bool Weekend(int nom)
{
    return nom == 6 || nom == 7;
}