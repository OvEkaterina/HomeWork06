// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void PositiveNumber (int []array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0) count++;
    }
    Console.WriteLine($"[{string.Join(",", array)}]-> {count}");
}

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент {0} :", i + 1);
    array[i] = int.Parse(Console.ReadLine());
}
PositiveNumber(array);