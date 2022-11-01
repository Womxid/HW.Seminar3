// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число чтобы получить таблицу кубов от единицы до него");
double num = double.Parse(Console.ReadLine());
for(double i = 1; i<=num; i++) Console.WriteLine($"{Math.Pow((i),3)}");
if(num <= 0) Console.WriteLine("Неподходящее число");