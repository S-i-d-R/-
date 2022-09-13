Console.WriteLine ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB)
{
  Console.WriteLine ("Числа равны");
}
else
{
if (numberA > numberB)
{
  Console.Write ("Большее число: ");
  Console.WriteLine (numberA); 
  Console.Write ("Меньшее число: ");
  Console.WriteLine (numberB); 
}
else 
{
  Console.Write ("Большее число: ");
  Console.WriteLine (numberB); 
  Console.Write ("Меньшее число: ");
  Console.WriteLine (numberA);   
}
}
