/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetExponentiation(int numberA, int numberB)
{
    int count = 1;
    for (int i = 1; i <= numberB; i++)
    {
        count = count * numberA;
    }
    return count;
}

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponent = GetExponentiation(numberA, numberB);
Console.WriteLine("Результат: " + exponent);