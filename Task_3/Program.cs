// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] array = {3.14, 2.718, 6.66, 9.99, 4.56};

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++) {
    if (array[i] > max) {
        max = array[i];
    } else if (array[i] < min) {
        min = array[i];
    }
}

Console.WriteLine($"Максимальное значение: {max}");
Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine($"Разница элементов: {max - min}");