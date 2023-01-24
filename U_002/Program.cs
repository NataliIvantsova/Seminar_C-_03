// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

nt Promt(string message) // Promt - быстро
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение конверт32 из консоль редлайн
}
/*пишем фукцию которая будет возвращать строчку 
GetCoords - Cet - получать Coords координаты */

string CetCoords(int Quarter)// Quarter-четверть
{
    if (Quarter == 1)
    {
        return "x>0; y>0";
    }
    if (Quarter == 2)
    {
        return "x<0; y>0";
    }
    if (Quarter == 3)
    {
        return "x<0; y<0";
    }
    return "x>0; y<0";
}
int Chetvert = Promt("Введите номер четверти ");
if (Chetvert < 1 || Chetvert > 4)// а можно проверку внутри фукции CetCoords сделать
{
    System.Console.WriteLine("Такой четверти в двоичной системе координат нет");
}
else
{
    string result = CetCoords(Chetvert);  //объявляем переменную типа строки result и присваиваем ей фукцию от певведенных данных
    System.Console.WriteLine(result);
}


//для FOR

// for (int i=1; i <= n; i++)
// {
// double pow = Math.Pow(i, 2);
// Console.WriteLine(pow);
// }