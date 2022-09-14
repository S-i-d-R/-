Console.WriteLine ("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int count = numberN;

while (count >= 1)
{
int remains = count % 2;
if (remains == 0) 
{    
Console.WriteLine (count);
}
count = count - 1;
}