Console.WriteLine("Введите положительное число N:");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
      Console.Write(i * i * i + " ");  
    }
}
else
{
  Console.WriteLine("Введено отрицательное число!");  
}