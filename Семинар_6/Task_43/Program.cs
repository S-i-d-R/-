double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 = ReadNumber("Введите точку b1 первой прямой:");
double k1 = ReadNumber("Введите точку k1 первой прямой:");
double b2 = ReadNumber("Введите точку b2 второй прямой:");
double k2 = ReadNumber("Введите точку k2 второй прямой:");
double x = (b2 - b1) / (k1 - k2);
if(k1 == k2)
{
    Console.WriteLine("Линии параллельны друг другу.");
}
else
{
    double point1 = k1 * x + b1;
    double point2 = k2 * x + b2; 
    Console.WriteLine($"Точка пересечения прямых: ({point1};{point2})");
}