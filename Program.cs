// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Please enter some numbers separated by a space and I will say how much numbers are more then 0");
string SomeNumbers = Console.ReadLine()!;
Console.WriteLine($"You entered {PositiveNumbersCounter(SomeNumbers)} positive numbers");
Console.WriteLine("--------------------------------------------------------------------");

int PositiveNumbersCounter(string SomeString)
{
    string[] numbers = SomeString.Split(' ');
    int counter = 0;
    foreach (var item in numbers)
    {
        if (Convert.ToInt64(item) > 0)
        {
            counter++;
        }
    }
    return counter;
} 

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("This program will calculate the coordinates of the intersection of two lines according to the given equation: [y = k1 * x + b1, y = k2 * x + b2]");
Console.WriteLine("The next four steps you should enter numbers k1; b1; k2; b2 step by step");
Console.WriteLine("Enter first number");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter third number");
double c = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter fourth number");
double d = double.Parse(Console.ReadLine()!);

double[] result = FindIntersectionPoint(a, b, c, d);
if (b == d)
{
    Console.WriteLine("Straight lines don't intersect.");
}
else
{
Console.WriteLine($"The intersection point is [{String.Join(";", result)}]");
}
Console.WriteLine("--------------------------------------------------------------------");

double[] FindIntersectionPoint (double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = 5 * result[0] + 2;
    return result;
}   

// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

Console.WriteLine("Введите число");
int NumberForChechGlobal = int.Parse(Console.ReadLine()!);
int[] Array = GetArray();
Console.WriteLine($"Получен массив [{String.Join(" ", Array)}]");
Console.WriteLine($"Результат вычисления произведения всех чисел в массиве, которые < {NumberForChechGlobal}: {DunnoHowToNameMethod(Array, NumberForChechGlobal)}");

int[] GetArray ()
{
    int[] res = new int [10];

    for (int i = 0; i < 10; i++)
    {
        res[i] = new Random().Next(50, 101);
    }
    return res;
}

double DunnoHowToNameMethod (int[] SomeArray, int NumberForCheck)
{
    double result = 1;
    int counter = 0;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if(SomeArray[i] < NumberForCheck)
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        foreach (var item in SomeArray)
        {
            if (item < NumberForCheck)
            {
                result = result * item;
            }
            
        }
    }
    else
    {
        result = 0;
    }
    return result;
}

