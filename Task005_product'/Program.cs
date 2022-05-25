// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Write("Введите размер массива: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[Number];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(-10,11);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int indexStart = 0;
int indexEnd = array.Length-1;
while(indexStart<=indexEnd)
{
    int product = array[indexStart] * array[indexEnd];
    Console.WriteLine($"Product of {indexStart} and {indexEnd} numbers of array is {product}.");
    indexStart++;
    indexEnd = indexEnd-1;
}

