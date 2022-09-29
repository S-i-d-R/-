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
int[] array = GetArray(123, 0, 123);
Console.WriteLine("Задан массив, из 123 элементов:");
Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < array.Length; i++)
if (array[i] > 9 && array[i] < 100)
{
    count = count + 1;
}
Console.WriteLine("Количество элементов, лежащих в отрезке от 10 до 99:");
Console.WriteLine(count);