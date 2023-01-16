// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] arr = {7.12, 10.2, 5, 2.55, 22.5,};
double min = arr[0];
double max = arr[0];
double diff = 0;
Console.WriteLine("[{0}]", string.Join(", ", arr)); // Для наглядности выводим все элементы массив
if(arr[1] > max) max = arr[1];
if(arr[2] > max) max = arr[2];
if(arr[3] > max) max = arr[3];
if(arr[4] > max) max = arr[4];
if(arr[1] < min) min = arr[1];
if(arr[2] < min) min = arr[2];
if(arr[3] < min) min = arr[3];
if(arr[4] < min) min = arr[4];
Console.WriteLine($"разница между максимальным и минимальным числом массива равна {diff = max - min} ");