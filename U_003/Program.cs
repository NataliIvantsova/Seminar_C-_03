// Задача 3: Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Promt(string message) // Promt - быстро
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение конверт32 из консоль редлайн
}
int x1 = Promt("введите координату х первой точки");
int y1 = Promt("введите координату y первой точки");
int x2 = Promt("введите координату х второй точки");
int y2 = Promt("введите координату y второй точки");

// пишем фукцию вычисления расстояния Distance
double Distance(double x1, double x2, double y1, double y2)
{
double a; 
double b;
a = x2 - x1;
b = y2 - y1;
return Math.Sqrt(a*a + b*b); // функция квадратного корня Math.Sqrt База математических фукций Math
}
System.Console.WriteLine($"расстояние между двумя точками {Distance(x1,x2,y1,y2)}"); //сразу выводим то что получилось
