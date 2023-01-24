// Напишите программу, которая принимает на 
// вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и в
// ыдаёт номер четверти плоскости, в которой находится эта точка.

// ввод целого значения// она принимает строковый параметр мессендж/ пишем фукцию

// целое знач.- имя фукции -строчное сообщение - сообщение
int Promt(string message)
{
    System.Console.WriteLine($"{message} > ");// на консоли сообщение из строки выше
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение конверт32 из консоль редлайн, т.е. превращаем его в числ
    
}
//пишем белевскую фукцию которая проверяет не находятся ли точки Х и Y на оси координат
bool ValidateCoords(int xCoord, int yCoord)
{
    if(xCoord == 0 || yCoord ==0)
    {
        System.Console.WriteLine("Точка лежит хотя бы на одной оси");
        return false;
    }
    return true;   
}
//Создаем фукцию которая возвращает целое
int GetQuorter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0)
    {
        return 1;
    }
    if (xCoord > 0 && yCoord < 0)
    {
        return 4;
    }
    if (xCoord < 0 && yCoord < 0)
    {
        return 3;
    }
    return 2;
    
}



int x = Promt("Введите Х ");
int y = Promt("Введите Y ");
if(ValidateCoords(x, y))
{
    int quorter = GetQuorter(x, y);
    System.Console.WriteLine($"Номер четверти {quorter}");
}