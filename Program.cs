int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
 Console.WriteLine("Вы ввели не трехзначное число");
 break;
}
else
{
 Console.WriteLine(number);
}
Console.WriteLine(number);
int a = number / 10 % 10;
Console.WriteLine(a);
break;

case 2:
//2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет."
int number1 = ReadInt("Введите число: ");
int count = number1.ToString().Length;
Console.Write(MakeArray(number1, count));
 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
 
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
 
        result = (a / c) % 10;
    }
return result;
}
break;


case 3:
Console.Write("Введите день недели ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("выходной");
	} else {
		Console.Write("будний день(((");
	}
} else {
	Console.Write("нет такого дня ");
}

break;

default:
begin = false;
break;
}
}

