Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = number;

while (count > 999)
{
 count = count / 10;
}
if (count <= 999 && count > 99)
{
 int number3 = count % 10;
 Console.WriteLine ($"Третье число: {number3}"); 
}
else
{
 Console.WriteLine ("Третьего числа нет.");   
}