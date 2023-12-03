// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

int num = 456789;
int originalNum = num;

int count = 0;

while (num > 0) {
    num = num / 10;
    count = count + 1;
} 

int [] array = new int [count];

for (int i = count - 1; i >= 0 ; i--) {
    array[i] = originalNum % 10;
    originalNum = originalNum / 10;
    
}

int position = 0;
while (position < count) {
    Console.Write(array[position] + " ");
    position++;
}