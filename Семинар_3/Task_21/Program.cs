Console.WriteLine("Введите координату точки A по Х:");
int pointAx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Y:");
int pointAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Z:");
int pointAz = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите координату точки B по Х:");
int pointBx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Y:");
int pointBy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Z:");
int pointBz = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(pointBx -pointAx, 2) + Math.Pow(pointBy -pointAy, 2) + Math.Pow(pointBz -pointAz, 2));
Console.WriteLine($"{result:f2}");