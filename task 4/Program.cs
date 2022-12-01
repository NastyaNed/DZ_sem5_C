//  Задайте одномерный массив из 123 случайных чисел. 
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

void FillArray(int[] arrayA)
{
    int numA = arrayA.Length;
    int countA = 0;
    while (countA < numA)
    {
        arrayA[countA] = new Random().Next(0, 201);
        countA++;
    }
}
void PrintArray(int[] arrayB)
{
    int numB = arrayB.Length;
    int countB = 0;
    while (countB < numB)
    {
        Console.Write($"{arrayB[countB]} ");
        countB++;
    }
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++) if (array[i] > 9 && array[i] < 100) count++;
Console.Write(count);
