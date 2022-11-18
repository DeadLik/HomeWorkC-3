// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= -1) number = System.Math.Abs(number);

int temp = number;
int rev = 0;

void TheShifter(int num)
{
    while (num > 0)
    {
        int dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    }
}

if (number > 9999 && number < 100000)
{
    TheShifter(number);
    if (temp == rev) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.Write("Число не пятизначное");



