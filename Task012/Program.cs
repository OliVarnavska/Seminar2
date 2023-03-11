//12) Напишите программу, которая будет принимать 
//на вход два числа и выводить, является ли второе число кратным 
//первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно



Console.WriteLine("Введите число x");
Console.WriteLine("Введите число y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int a = x % y;
if (x % y == 0)
{
    Console.WriteLine("Число является кратным");
}
 else
{
        Console.WriteLine(a);
}

