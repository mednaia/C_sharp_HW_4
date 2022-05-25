// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0,10);
    Console.Write($"{array[i]} ");
}
int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) sumPos+=array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < 0) sumNeg+=array[i];
}
Console.WriteLine();
Console.Write($"Sum of positive numbers of array = {sumPos}.");
Console.WriteLine();
Console.Write($"Sum of negative numbers of array = {sumNeg}.");