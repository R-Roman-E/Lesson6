// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
//пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Get(string msg)
{
    Console.Write(msg);
    double userNumber = Convert.ToDouble(Console.ReadLine());
    return userNumber;
}
string FunctionWrite(double a, double b)
{
    string result = "y = " + Convert.ToString(a) + "*x + " + Convert.ToString(b);
    return result;
}
string IntersectionCheck(double a, double b, double c, double d)
{
    double abscissa = (d - b) / (a - c);
    double ordinate = abscissa*a + b;
    string result = Convert.ToString(abscissa) + ";" + Convert.ToString(ordinate);

    return result;
}
double numberB1 = Get("Введите коэффициент b1: ");
double numberK1 = Get("Введите коэффициент k1: ");
double numberB2 = Get("Введите коэффициент b2: ");
double numberK2 = Get("Введите коэффициент k2: ");
Console.WriteLine();
string function1 = FunctionWrite(numberK1, numberB1);
string function2 = FunctionWrite(numberK2, numberB2);
string coordinates = IntersectionCheck(numberK1, numberB1, numberK2, numberB2);
Console.Write($" Точка пеерсечения двух прямых {function1} и {function2}:\n({coordinates})");