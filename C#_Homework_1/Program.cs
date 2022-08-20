/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Вводим переменные 
int num1;

int num2;

// Просим пользователя ввести числа 
Console.Write("Введите первое число : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

// Сравниваем числа, выводим наибольшее на консоль 
if (num1 > num2){
    Console.WriteLine("Максимальное число " + num1); 
}
else
{
    Console.WriteLine("Максимальное число " + num2); 
}
*/


/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Вводим переменные 
int num1;

int num2;

int num3;
//Добовляем переменную макс 
int max;

// Просим пользователя ввести числа 
Console.Write("Введите первое число : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

// Сравниваем 1и 2  число, запоминаем максимальное
if (num1 > num2){
    max = num1;
}
else
    max = num2;

// Сравниваем максимальное с 3 числов, выводим максимальное на консоль 
if (num3 > max){
    max = num3;
    Console.WriteLine("Максимальное число " + max);
}
else
    Console.WriteLine("Максимальное число " + max);
*/


/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num;

Console.Write("Введите число для проверки на четность ");
num = Convert.ToInt32(Console.ReadLine());

// Определание на четность 
if (num % 2 == 0){
    Console.WriteLine("Число четное ");
}
else
    Console.WriteLine("Число не четное ");
*/


/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n;

Console.Write("Введите число ");
n = Convert.ToInt32(Console.ReadLine());

// Вводим счетчик 
for (int i = 1; i <= n; i++)
// провереяем на четность
    if (i % 2 == 0)
        Console.WriteLine(i);
    
if (n < 2)
{
    Console.WriteLine("В промежутке от 1 до числа N четных чисел нет ;) ");
}
*/

