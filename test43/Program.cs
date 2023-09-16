// Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}
void Coordinates (int k1, int k2, int b1, int b2)
{
    if(k1==k2 && b1==b2)
    Console.Write("прямые совпадают");
    else 
    if (k1==k2)
    Console.Write("прямые параллельны");
    else 
    {
        double x = (b1 -b2)/(k1-k2);
        double y = k1* x + b1;
        Console.WriteLine($"прямые пересекаются в точке  {x};{y}");
    }
}
int ratio1 = InputNum("введите значение K1: ");
int ratio2 = InputNum("введите значение K2: ");
int displ1 = InputNum("введите значение b1: ");
int displ2 = InputNum("введите значение b2: ");
Coordinates (ratio1, ratio2, displ1, displ2);   