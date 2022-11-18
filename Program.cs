/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2;      1, -7, 567, 89, 223-> 3*/
/*
Console.WriteLine("How many nubers your're ganner to put?");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 0;
    for(int i = 0; i < digit; i++)
    {
        Console.WriteLine("Input nuber");
        int quonter = Convert.ToInt32(Console.ReadLine());
            if(quonter > 0)
                count += 1;
    }
Console.WriteLine($"You input {count} nubers upper 0");
*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
Console.WriteLine("Input the coefficient nuber: k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the coefficient nuber: k2");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the coefficient nuber: b2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the coefficient nuber: b1:");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
if(k1 == k2 && b1!= b2)
    Console.WriteLine("The straight lines are parallel"); // Параллельны

if(k1 == k2 && b1 == b2)
    Console.WriteLine("The straight lines are match");// Совпадают
    
if(k1 != k2 && b1 != b2)
    {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;     
    Console.WriteLine($"The straight lines intersect at the point: x = {x}; y = {y}"); // Пересекаются
    }
 */   