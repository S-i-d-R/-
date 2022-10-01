int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int [size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = GetArray(6, 0, 100);
Console.Write("Задан массив случайных чисел: ");
Console.WriteLine(string.Join(", ", array));
int max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array [i] > max) max = array [i];
}
Console.Write("Максимальное число в массиве: ");
Console.WriteLine(max);
int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array [i] < min) min = array [i];
}
Console.Write("Минимальное число в массиве: ");
Console.WriteLine(min);
int difference = max - min;
Console.Write("Разница между макс и мин числом: ");
Console.WriteLine(difference);