//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве. 
Console.WriteLine("Введите количество чисел: ");
int[] amount = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(amount);
Console.WriteLine("");
Multiplication(amount);
Console.WriteLine("");
void FillArray(int[] numbers)
{
    Console.Write("Массив: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 11);
        Console.Write(numbers[i] + " ");
    }
}
void Multiplication(int[] numbers)
{
    int[] multipliedNumbers = new int[numbers.Length];
    int length = numbers.Length;
    Console.Write("Произведение: ");
    int index = 0;
    while (index < length / 2)
    {
        multipliedNumbers[index] = numbers[index] * numbers[length -index -1];
        Console.Write(multipliedNumbers[index] + " ");
        index++;
    }
}