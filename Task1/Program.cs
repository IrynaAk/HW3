// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


using System;
using static System.Console;
Clear();

WriteLine("Please type a 5-digits number");
int number = Convert.ToInt32(ReadLine());

if(number<10000 || number>99999)
{
    WriteLine($"{number} is not a 5-digits number");
}
else
{
int i = 0;
int j=10000;
int convNumber = 0;
int auxNumber = number;
while(i<5)
{
convNumber = convNumber + (auxNumber%10)*j;
auxNumber/=10;
j/=10;
i++;
}
WriteLine(convNumber==number? $"{number} is a palindrome" : $"{number} is not a palindrome");
}
