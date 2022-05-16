// Написать цикл: принимает 2 числа. Число А возводится в степень В.
// A = 3 B = 5 -> 243 (3 в 5 степени)
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести число? ");
int numberB = Convert.ToInt32(Console.ReadLine());
int baseNumber = numberA;

for (int i = 1; i != numberB; i++)
{
    numberA *= baseNumber;
}

Console.WriteLine($"Число {baseNumber}, возведенное в степень {numberB} равно: {numberA}.");