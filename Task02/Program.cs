// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Data(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double b1 = Data ("Введите число b1 ");
double k1 = Data ("Введите число k1 ");
double b2 = Data ("Введите число b2 ");
double k2 = Data ("Введите число k2 ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine ($"b1 = {b1},k1 = {k1},b2 = {b2},k2 = {k2} -> ({x},{y})");

