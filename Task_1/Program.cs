// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] arr = new int [15];
int count = 0;
Random rand = new Random();
for( int i = 0; i < arr.Length; i++ )
 {
   arr[i] = rand.Next(100,999);
 }
 Console.WriteLine("[{0}]", string.Join(", ", arr)); // Для наглядности выводим все элементы массива
for (int j = 0; j < arr.Length; j++ ) 
{
   if (arr[j] % 2 == 0)
    count++;
}
Console.WriteLine($"В массиве {count} четных чисел(а) ");