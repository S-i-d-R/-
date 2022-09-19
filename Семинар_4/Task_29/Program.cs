int [] array = new int [8];

Console.WriteLine ("Введите восемь элементов массива: ");

for (int i = 0; i < array.Length; i++)
{
array [i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write ("Ваш массив: ");
Console.WriteLine (string.Join (", ", array));