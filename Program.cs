using System;
Console.WriteLine("Calculator");

int num1 = 0, num2 = 0;
System.Console.Write("First Number: ");
num1 = int.Parse(Console.ReadLine());

System.Console.Write("Second Number: ");
num2 = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Qo'shish: {num1} + {num2} = {num1 + num2}");
System.Console.WriteLine($"Ayrish: {num1} - {num2} = {num1 - num2}");
System.Console.WriteLine($"Ko'paytirish: {num1} * {num2} = {num1 * num2}");
System.Console.WriteLine($"Bo'lish: {num1} / {num2} = {num1 / num2}");    