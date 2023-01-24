// Задача 4: Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Promt(string message) // Promt - быстро
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение конверт32 из консоль редлайн
}

int n = Promt("Введите число N ");
//Math.Pow(n,2);// фукция выведения степени в квадрате, если 2
int i = 1; // индекс равен единице

while(i <= n)
{
    double result = Math.Pow(i,2);
    System.Console.WriteLine($"Квадрат числа {i} = " + result);
    i++;
}