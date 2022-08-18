// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (14212 -> нет, 23432 -> да, 12821 -> да)

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10000;
int number2 = (number / 1000) % 10;
int number4 = (number / 10) % 10;
int number5 = number % 10;

if (number <= 9999 || number > 99999)
{
    Console.WriteLine("Число введено неверно, попробуйте еще раз");
}

else if (number1 == number5 && number2 == number4 && number > 10000 && number < 100000)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}

else
{
    Console.WriteLine("Число " + number + " не является палиндромом");
}