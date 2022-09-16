Console.WriteLine ("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
{
 Console.WriteLine ("Это будний день.");
}
if (number > 5 && number < 8)
{ 
Console.WriteLine ("Это выходной день.");
}
if (number > 7 ^ number < 1)
{
 Console.WriteLine ("Такого порядкового номера дня недели, НЕТ.");
}
