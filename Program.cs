﻿int n = 0;
int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
for  (int i = a; i < b+1; i++)
{
    n += i;
}
Console.WriteLine(n);