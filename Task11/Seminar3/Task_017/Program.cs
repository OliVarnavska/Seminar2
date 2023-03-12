// 1) Задача №17. Напишите программу,
//  которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
Console.WriteLine("Введите два число x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите два число y:");
int y = Convert.ToInt32(Console.ReadLine());
if ((x > 0) && (y > 0)) 
Console.WriteLine($"Чиcло находится в плоскости 1");
else if ((x < 0) && (y > 0 ))
Console.WriteLine($"Чиcло находится в плоскости 2");
else if ((x < 0) && (y < 0 ))
Console.WriteLine($"Чиcло находится в плоскости 3");
else if ((x > 0) && (y < 0 ))
Console.WriteLine($"Чиcло находится в плоскости 4");
else
{
    Console.WriteLine($"x или у не могут быть равными 0");
}


