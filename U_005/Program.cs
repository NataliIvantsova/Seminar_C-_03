﻿// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел
// из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5

//                           (включается число, исключается)

int b = 0; // вводим счетчик чисел больше 5/ в него будем соблюдать результат

for (int i = 0; i < 10; i++)
{
    int a = new Random().Next(1, 11);
    System.Console.WriteLine($"Сгенерировалось случайное число " + a); // выводим на консоль счетчик чтобы контролировать результат
    if (a > 5)
        b++; //увеличиваем внутри цикла а выводим данные за циклом// if внутри цикла чтобы не потерять значение А
}
System.Console.WriteLine($"сгенерировалось чисел больше 5" + b);