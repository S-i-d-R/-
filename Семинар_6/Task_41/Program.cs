Console.WriteLine("Введите числа, в конце введите слово: stop");

int countPositivNumber = 0;
while(true)
{
    string answer = Console.ReadLine();
    if(answer == "stop")
    {
        break;
    }
    else
    {
        int Number = Convert.ToInt32(answer);
        if(Number > 0)
        {
            countPositivNumber++;
        }
    }
}
Console.WriteLine($"Колличество чисел больше нуля = {countPositivNumber}");