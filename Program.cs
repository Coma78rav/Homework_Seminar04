// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// void questNumber () {
//     while(true) {
//         Console.WriteLine("Ввведите целое число: ");
//         string str = Console.ReadLine()!;
//         int number;
//         int num = 0;
//         if(str == "q") break;     
//         if(int.TryParse(str, out number)){
//             for(int i = 0; i < str.Length; i++){
//                 num += str[i] - '0';
//                 Console.WriteLine(num);
//             }
//             if(num % 2 == 0) break;
//         }
//     }
// }
// questNumber();


// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// void countEvenNumbers (int[] array) {
//     int count = 0;
//     Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
//     foreach (int element in array){
//         if (element % 2 == 0)
//             count++;
//     }
//     Console.WriteLine(count);
// }
// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];

// int[] inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000); // [100, 999]
//     return array;
// }
// countEvenNumbers(inputArray(array));


// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void expandArr (int[] array) {
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    int tmp;
    for (int i = 0; i < array.Length / 2; i++){
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
}
Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1001); // [1, 1000]
    return array;
}
expandArr(inputArray(array));