// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Write("Введите размер массива: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[Number];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}
int countEven = 0;
int countOdd = 0;
for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) countEven++;
        else
        {
            countOdd++;
        }
    }
Console.Write($"The number of even in array is {countEven}.");
Console.WriteLine();
Console.Write($"The number of even in array is {countOdd}.");
