//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] arr = new int [8];
int sum = 0;
Random rand = new Random();
for( int i = 0; i < arr.Length; i++ )
 {
   arr[i] = rand.Next(1,9);
 }
 Console.WriteLine("[{0}]", string.Join(", ", arr)); // Для наглядности выводим все элементы массива
 for (int i = 0; i < arr.Length; i++ ) 
 {
    if (arr[i] % 2 == 1)
    sum += arr[i];
 }
 Console.WriteLine($" сумма не четных чисел равна {sum} ");