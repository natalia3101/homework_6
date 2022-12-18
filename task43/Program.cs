/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter another number.");
        }
    }
    return result;
}

double b1 = GetNumber("Enter point b1");
double k1 = GetNumber("Enter point k1");
double b2 = GetNumber("Enter point b2");
double k2 = GetNumber("Enter point k2");

double x;
double y;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;


Console.WriteLine($"The point of intersection is ({x}, {y}).");


