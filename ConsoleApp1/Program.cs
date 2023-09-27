using System;

//Task 1
Console.WriteLine("Enter first number:");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int second_number = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number:");
int third_number = int.Parse(Console.ReadLine());
int sum = 0;
if (first_number > 0 && first_number % 5 == 0)
{
    sum += first_number;
}
if (second_number > 0 && second_number % 5 == 0)
{
    sum += second_number;
}
if (third_number > 0 && third_number % 5 == 0)
{
    sum += third_number;
}
Console.WriteLine("Sumof numbe: " + sum);

//Task 2

int number = 278;
int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;
Console.WriteLine("Sum of digits=" + (a + b + c));