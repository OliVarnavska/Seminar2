﻿//11) Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98



int N = new Random ().Next(99, 1000); //100 101 102 ....999
Console.WriteLine(N);

int x = N / 100;
int y = N % 10;
Console.Write(x);
Console.Write(y);