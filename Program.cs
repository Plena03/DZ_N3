//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine ("Программа показывает является ли число четным");

Console.WriteLine ("Введите число: ");

string? numberString = Console.ReadLine (); 

int number =  int.Parse (numberString!);

//int number2 = (number1 % 2);

if ((number / 2) *2 == number)
        {
        Console.WriteLine ("Число является четным!"); 
        }
else
    {
    Console.WriteLine ("Число не является четным!");
    }
