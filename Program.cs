//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
int[] MNumbers(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        myArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void MoreZero(int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
          count++;
        }
    }    
    Console.WriteLine($"Кол-во элементов больше 0 -> {count}");
    
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] NewArray = MNumbers(a);
ShowArray(NewArray);
MoreZero(NewArray);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void InterPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if(k1 == k2) 
    Console.WriteLine("Прямые не пересекаются");
    else
    Console.WriteLine($"Прямые пересекаются в точке - > ({x};{y})");
}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

InterPoint(k1, b1, k2, b2);
 
