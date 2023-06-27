/*
    Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    4 -> да
    -3 -> нет
    7 -> нет
*/

Console.Write("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0){
    Console.Write(number + " is even number.");
}
else{
    Console.Write(number + " isn't even number.");
}